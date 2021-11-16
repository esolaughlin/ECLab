namespace ECLab
{
    public class Book
    {
        private string isbn;
        private string title;
        private Author author;
        public Book(string tempIsbn, string tempTitle, Author tempAuthor){
            isbn = tempIsbn;
            title = tempTitle;
            author = tempAuthor;
        }
        public string GetIsbn(){
            return isbn;
        }
        public void SetIsbn(string isbn){
            this.isbn = isbn;
        }
        public string GetTitle(){
            return title;
        }
        public void SetTitle(string title){
            this.title = title;
        }
        public Author GetAuthor(){
            return author;
        }
        public void SetAuthor(Author author){
            this.author = author;
        }
        public override string ToString(){
            return $"isbn: {isbn} Title: {title} {author.ToString()}";
        }
    }
}