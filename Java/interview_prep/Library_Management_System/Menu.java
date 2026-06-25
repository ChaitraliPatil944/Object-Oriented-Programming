public class Menu {
    public static void main(String[] args) {
        Books [] books = new Books[5]; // Assuming a maximum of 5 books
        int bookIndex = 0; // Index to keep track of the number of books added

        while(true){
            System.out.println("Welcome to the Library Management System");
            System.out.println("1. Add Book");
            System.out.println("2. Display Book Details");
            System.out.println("3. Display Total Books");
            System.out.println("4. Exit");

        int choice = 0; // Assume this is obtained from user input

        switch (choice) {
            case 1:
                Books newBook = new Books(bookIndex, ) ;
                // Code to add a book
                break;
            case 2:
                // Code to display book details
                break;
            case 3:
                // Code to display total books
                break;
            case 4:
                System.out.println("Exiting the system. Goodbye!");
                return; // Exit the program
            default:
                System.out.println("Invalid choice. Please try again.");
        }
       }
    }
    
}
