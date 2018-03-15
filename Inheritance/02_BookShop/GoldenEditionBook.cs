
namespace _02_BookShop
{
   public class GoldenEditionBook : Book
    {
        public override double Price
        {
            get
            {
                return base.Price*1.3;
            }
        }

        public GoldenEditionBook(string author, string title, double price)
            :base(author,title,price)
        {

        }
    }
}
