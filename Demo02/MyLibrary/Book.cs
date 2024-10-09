using MyLibrary;

namespace MyLibrary
{
    public class Book : Product
    {
        public string Title { get; }
        public Book(int id, string name, decimal unirprice, int unitsInStock, string title) :
            base(id, name, unirprice, unitsInStock)
        {
            Title = title;
        }
    }
}
public class Book2(int id, string name, decimal unirprice, int unitsInStock, string title) :
    Product(id, name, unirprice, unitsInStock)
{
    public string Title => Title;
    }



