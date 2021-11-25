namespace gas_station.Domains
{
    public class Comment
    {
        public int CommentId { get; set; }
        public object Data { get; set; }
        public Station Refueling { get; set; }
        public Error Error { get; set; }
    }
}