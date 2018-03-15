
namespace _03_Mordor_sCrueltyPlan
{
    public class Mushrooms : FoodFactory
    {
        public new const int HappinessPoints = -10;
        public Mushrooms(string name)
            :base(name)
        {

        }
    }
}