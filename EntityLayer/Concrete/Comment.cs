namespace EntityLayer.Concrete
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string CommentMailAddress { get; set; }
        public string CommentTitle { get; set; }
        public string CommentContent { get; set; }
        public DateTime CommentDate { get; set; }
        public bool CommentStatus { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
