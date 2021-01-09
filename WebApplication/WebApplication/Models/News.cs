namespace WebApplication.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string AuthorName { get; set; }
        public bool IsFake { get; set; }

        public override string ToString()
        {
            return string.Format("Id: {0}, Title: {1}, Text:{2}, Author:{3}, Is Fake: {4} ", Id, Title, Text, AuthorName, IsFake);
        }
    }
}