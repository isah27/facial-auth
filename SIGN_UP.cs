using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Face;
using Emgu.CV.CvEnum;
using System.IO;
using System.Data.SQLite;
using AForge.Video.DirectShow;


namespace Authentication
{
    public partial class SIGN_UP : Form
    {
        
        #region variable
        private Capture videoCapture = null;
        private Image<Bgr, Byte> currentFrame = null;
        private Mat frame = new Mat();
        private bool faceDetected = false;
        CascadeClassifier faceCascadeClasifier = new CascadeClassifier("haarcascade_frontalface_default.xml");
        List<Image<Gray, Byte>> TrainFaces = new List<Image<Gray, byte>>();
        List<int> personlabes = new List<int>();
        public bool enableSaveImage = false;
        public static bool isTrained = false;
        LBPHFaceRecognizer recognizer = new LBPHFaceRecognizer(1, 8, 8, 8, double.PositiveInfinity);
        List<string> personNames = new List<string>();
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        #endregion
        private void XBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void camBtn_Click(object sender, EventArgs e)
        {

            if (nameTbox.Text != "")
            {
                try
                {
                    //dispose of capture if it was created before
                    if (videoCapture != null) videoCapture.Dispose();
                    videoCapture = new Capture();
                    Application.Idle += processFrame;
                    //
                    pictureBox1.Visible = true;
                    detectedFace.Visible = true;
                    capturBtn.Visible = true;
                    faceDetected = true;
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please input your name!!");
            }
        }
        
        public SIGN_UP()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cboCamera.Items.Add(filterInfo.Name);
            cboCamera.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();
        }
       

        void TrainImageFromDb()
        {
            try
            {   
                TrainFaces.Clear();
                personlabes.Clear();
                
              
                using (SQLiteConnection con = new SQLiteConnection(connections.connectionStrings()))
                {
                    con.Open();
                    SQLiteDataAdapter sqldt = new SQLiteDataAdapter( "SELECT Name,Image FROM Face", con);
                    DataTable dt = new DataTable();
                    sqldt.Fill(dt);
                    if (dt.Rows.Count>1)
                    {
                        int imageCount = 0;
                        foreach (DataRow dr in dt.Rows)
                        {
                            string Names = (string)dr[0];
                            byte[] image = (byte[])dr[1];
               
                            MemoryStream msn = new MemoryStream(image);
                            msn.Position = 0;
                            Image imag = Image.FromStream(msn, true);
                            Image<Gray, byte> trainedImage = new Image<Gray, byte>((Bitmap)imag);
                            trainedImage.Resize(200, 200, Inter.Cubic);
                            CvInvoke.EqualizeHist(trainedImage, trainedImage);
                            TrainFaces.Add(trainedImage);
                            personlabes.Add(imageCount);
                            string name = Names.ToString();
                            personNames.Add(name);
                       
                            imageCount++;
                           
                        }
                        if (TrainFaces.Count() > 0)
                        {
                            recognizer.Train(TrainFaces.ToArray(), personlabes.ToArray());
                            BACKUP f2 = new BACKUP();
                            f2.Show();
                            this.Hide();
                            if (videoCapture != null)
                            {
                                videoCapture.Stop();
                                videoCapture.Dispose();
                            }

                            isTrained = true;
                            
                            //Debug.WriteLine(isTrained);
                            //return true;

                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("NO image, Please capture your face!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Image, Please Capture your Face..",ex.Message);
            }
        }
        private void capturBtn_Click(object sender, EventArgs e)
        {
            enableSaveImage = true;
            
        }
      
        private void processFrame(object sender, EventArgs e)
        {
            if (videoCapture != null && videoCapture.Ptr != IntPtr.Zero)
            {


                // step1 video capture
                videoCapture.Retrieve(frame, 0);
                currentFrame = frame.ToImage<Bgr, byte>().Resize(pictureBox1.Width, pictureBox1.Height, Inter.Cubic);
                // step2: face Detection
                if (faceDetected)
                {
                    // convert from bgr to gray
                    Mat grayImage = new Mat();
                    CvInvoke.CvtColor(currentFrame, grayImage, ColorConversion.Bgr2Gray);
                    // Enhance theimage to get better result
                    CvInvoke.EqualizeHist(grayImage, grayImage);

                    Rectangle[] faces = faceCascadeClasifier.DetectMultiScale(grayImage, 1.1, 5, Size.Empty, Size.Empty);
                    if (faces.Length > 0)
                    {


                        foreach (var face in faces)
                        {
                            // draw square around each faces
                            CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Blue).MCvScalar, 2);
                            // assign the detected face to the detectedFace Box
                            Image<Bgr, Byte> resultImages = currentFrame.Convert<Bgr, Byte>();
                            resultImages.ROI = face;
                            detectedFace.SizeMode = PictureBoxSizeMode.StretchImage;
                            detectedFace.Image = resultImages.ToBitmap();
                            if (enableSaveImage)
                            {

                                
                                // to avoid hang GUI we will create a new task
                                Task.Factory.StartNew(() => {
                                    for (int d = 0; d < 10; d++)
                                    {
                                        Image img = resultImages.Bitmap;
                                        byte[] arr;
                                        ImageConverter converter = new ImageConverter();
                                        arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
                                        using (SQLiteConnection conn = new SQLiteConnection(connections.connectionStrings()))
                                        {
                                            conn.Open();
                                            SQLiteCommand cmd = new SQLiteCommand("insert into Face (Name,Image) values (@Name,@Image)", conn);
                                            cmd.Parameters.AddWithValue("@Name", nameTbox.Text);
                                            cmd.Parameters.AddWithValue("@Image", arr);
                                            cmd.ExecuteNonQuery();
                                            
                                        }

                                    }
                                });
                                MessageBox.Show("Image saved");
                                TrainImageFromDb();
                            }
                            enableSaveImage = false;
                            
                        }
                    }
                }
                // Render the video capture into the picture box pictureBox1
                pictureBox1.Image = currentFrame.ToBitmap();
            }
            if (currentFrame != null)
            {
                currentFrame.Dispose();
            }
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            AddUserHelp h = new AddUserHelp();
            h.Show();
        }
    }
}
