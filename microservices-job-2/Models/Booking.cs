namespace microservices_job_2.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public string PickUpPoint { get; set; }
        public string Destination { get; set; }
        public long? Current_Location_Latitude { get; set; }
        public long? Current_Location_Longitude { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? Time { get; set; }
    }
}
