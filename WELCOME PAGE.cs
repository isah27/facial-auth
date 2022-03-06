using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Face;
using Emgu.CV.CvEnum;
using System.Diagnostics;
using System.Data.SQLite;
using AForge.Video;
using AForge.Video.DirectShow;
namespace Authentication
{
    public partial class WELCOME_PAGE : Form
    {
        public static bool isTrained = false;
        private bool faceDetected = false;
        List<string> personNames = new List<string>();
        LBPHFaceRecognizer recognizer = new LBPHFaceRecognizer(1, 8, 9, 9, double.PositiveInfinity);
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        CascadeClassifier faceCascadeClasifier = new CascadeClassifier("haarcascade_frontalface_default.xml");
        private Capture videoCapture = null;
        private Image<Bgr, Byte> currentFrame = null;
        Mat frame = new Mat();
        List<Image<Gray, Byte>> TrainFaces = new List<Image<Gray, byte>>();
        List<int> personlabes = new List<int>();
        
        public WELCOME_PAGE()
        {
            InitializeComponent();
        }
        public void captions()
        {
            videoCaptureDevice = new VideoCaptureDevice();
            //dispose of capture if it was created before
            if (videoCapture != null) videoCapture.Dispose();
            videoCapture = new Capture();
            //videoCapture.ImageGrabbed += processFrame;
            Application.Idle += processFrames;
            //videoCapture.Start();
        }

        private void ProceedBtn_Click(object sender, EventArgs e)
        {
            captions();
            faceDetected = true;
            isTrained = true;
            TrainImageFromDb();
            ProceedBtn.Visible = false;
            BypassBtn.Visible = true;
        }
        
        public void processFrames(object sender, EventArgs e)
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
                            
                            //recognize the face
                            if (isTrained)
                            {

                                Image<Gray, Byte> grayFaceResult = resultImages.Convert<Gray, Byte>().Resize(200, 200, Inter.Cubic);
                                Image<Gray, Byte> EiggrayFaceResult = resultImages.Convert<Gray, Byte>().Resize(200, 200, Inter.Cubic);
                                CvInvoke.EqualizeHist(grayFaceResult, grayFaceResult);
                                var result = recognizer.Predict(grayFaceResult);
                                
                                Debug.WriteLine(result.Label + ". " + result.Distance);
                                // here result found known faces
                                //if (result.Label>0 && result.Distance>1000)
                               
                                if (result.Distance < 90 ) 
                                {
                                    CvInvoke.PutText(currentFrame, personNames[result.Label], new Point(face.X - 2, face.Y - 2),
                                        FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);
                                    videoCapture.Stop();
                                    videoCapture.Dispose();
                                    HOME f3 = new HOME();
                                    f3.Show();
                                    this.Hide();


                                }
                                // here result not found any known faces!.
                              
                                else
                                {
                                   
                                    CvInvoke.PutText(currentFrame, "Unknown Face", new Point(face.X - 2, face.Y - 2),
                                        FontFace.HersheyComplex, 1.0, new Bgr(Color.Red).MCvScalar);                                    
                                }
                            }
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

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                    SQLiteDataAdapter sqldt = new SQLiteDataAdapter("SELECT NAME,Image FROM Face", con);
                    DataTable dt = new DataTable();
                    sqldt.Fill(dt);
                    int dataRow = dt.Rows.Count;
                   
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
                            Debug.WriteLine(imageCount + ". " + name);
                            imageCount++;
                            
                        }

                        
                        if (TrainFaces.Count() > 0)
                        {
                            //recognizer.Train(TrainFaces.ToArray(), personlabes.ToArray());
                            recognizer.Train(TrainFaces.ToArray(), personlabes.ToArray());
                            
                            isTrained = true;
                            Debug.WriteLine(imageCount);
                            //Debug.WriteLine(isTrained);
                            //return true;m
                            
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Image, Please Capture your Face..", ex.Message);
            }
        }
        private void WELCOME_PAGE_Load(object sender, EventArgs e)
        {
           
                filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                foreach (FilterInfo filterInfo in filterInfoCollection)
                    cboCamera.Items.Add(filterInfo.Name);
                cboCamera.SelectedIndex = 0;
                videoCaptureDevice = new VideoCaptureDevice();

        }

        private void BypassBtn_Click(object sender, EventArgs e)
        {
            BACKUP b = new BACKUP();
            b.Show();
            this.Hide();
            videoCapture.Dispose();
        }
    }

}
