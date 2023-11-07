namespace MiniBlogi.Models
{
    public class Comment
    {
        public int Id_comment { get; set; }
        public DateTime Date_comment {  get; set; }

        public string Content { get; set; }

        public string Ip_computer { get; set; }

        public int Id_note { get; set; }
    }
}
