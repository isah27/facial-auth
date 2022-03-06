namespace Authentication
{
    public class ContactModel
    {
        public int id { get; set; }
        public string Name { get; set; }
        
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }

       
    }
    public class connections
    {
        public static string connectionStrings()
        {
            string connect = "Data Source=MYDb.db;Version=3";
            return connect;
        }
    }
   
}
