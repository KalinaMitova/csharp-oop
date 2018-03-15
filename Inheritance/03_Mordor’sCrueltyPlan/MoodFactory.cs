using System;

namespace _03_Mordor_sCrueltyPlan
{
   public class MoodFactory
    {
        private int totalPointsOfHappiness;

        public  int TotalPointsOfHappiness
        {
            get
            {
                return this.totalPointsOfHappiness;
            }
            set
            {
                this.totalPointsOfHappiness = value;
            }
        }

        public MoodFactory(int totalPointsOfHappiness)
        {
            this.totalPointsOfHappiness = totalPointsOfHappiness;
        }

        public override string ToString()
        {
            string result = null;
            if (this.totalPointsOfHappiness < -5)
            {
                result = $"{this.totalPointsOfHappiness}{Environment.NewLine}Angry";
            }

            else if (this.totalPointsOfHappiness >= -5 && this.totalPointsOfHappiness <=0)
            {
                result = $"{this.totalPointsOfHappiness}{Environment.NewLine}Sad";
            }

            else if (this.totalPointsOfHappiness > 0 && this.totalPointsOfHappiness <= 15)
            {
                result = $"{this.totalPointsOfHappiness}{Environment.NewLine}Happy";
            }

            else if (this.totalPointsOfHappiness > 15)
            {
                result = $"{this.totalPointsOfHappiness}{Environment.NewLine}JavaScript ";
            }

            return result;
        }
    }
}
