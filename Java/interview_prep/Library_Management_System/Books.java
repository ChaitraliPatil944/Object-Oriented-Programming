public class Books {
    int bookId;
    String bookName;
    String authorName;
    static int bookCount= 0;

    public Books (int bookId, String bookName, String authorName) {
        this.bookId= bookId;
        this.bookName= bookName;
        this.authorName= authorName;
        bookCount++;
    }

    void displayBookDetails() {
        System.out.println("Book ID: " + bookId);
        System.out.println("Book Name: " + bookName);
        System.out.println("Author Name: " + authorName);
    }

    void displayTotalBooks() {
        System.out.println("Total Books: " + bookCount);
    }
}
