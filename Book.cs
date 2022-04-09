using System;
 struct Book
{
    public int BookId;
    public string title;
    public float price;
    public Books bookType;
    public enum Books

    { Magazine, Novel, ReferenceBook, Miscellaneous };

    public void Getdetails(int id, string tit, float pr, Books bt)
    {
        BookId = id;
        title = tit;
        price = pr;
        bookType = bt;
    }
    public void DisplayDetails()
    {
        Console.WriteLine("Book Id ={0}", BookId);
        Console.WriteLine("Book Title={0}", title);
        Console.WriteLine("Book Price={0}", price);
        Console.WriteLine("Book Typr={0}", bookType);

    }
};
 public class StructureMain
{ static void Main()
    {
        

        Book b = new Book();
        Book b1 = new Book();
        Book b2 = new Book();
        Book b3 = new Book();

        b.Getdetails(2677,"Love of Life",50.34F,Book.Books.Magazine);
        b1.Getdetails(2678, "President", 80.34F, Book.Books.Novel);
        b2.Getdetails(2679, "Long Journey", 500.34F, Book.Books.ReferenceBook);
        b3.Getdetails(2680, "January", 490.34F, Book.Books.Miscellaneous);
        b.DisplayDetails();
        b1.DisplayDetails();
        b2.DisplayDetails();
        b3.DisplayDetails();



        Console.ReadKey();
        }
    
}
