using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A player has a name and stats which are the basis for his skill level.The stats a player has are endurance, sprint, dribble, passing and shooting.
//Each stat can be in the range[0..100]. The overall skill level of a player is calculated as the average of his stats.Only the name of a player
//and his stats should be visible to all of the outside world.Everything else should be hidden.
//•	A name cannot be null, empty or white space. If not, print "A name should not be empty. "
//•	Stats should be in the range 0..100. If not, print "[Stat name] should be between 0 and 100. "
namespace _06_FootballTeamGenerator
{
    public class Player
    {
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"A {nameof(this.Name).ToLower()} should not be empty.");
                }

                this.name = value;
            }
        }

        public int Endurance
        {
            get { return this.endurance; }
            private set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentException($"{nameof(this.Endurance)} should be between 0 and 100.");
                }

                this.endurance = value;
            }
        }
        public int Sprint
        {
            get { return this.sprint; }
            private set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentException($"{nameof(this.Sprint)} should be between 0 and 100.");
                }

                this.sprint = value;
            }
        }
        public int Dribble
        {
            get { return this.dribble; }
            private set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentException($"{nameof(this.Dribble)} should be between 0 and 100.");
                }

                this.dribble = value;
            }
        }

        public int Passing
        {
            get { return this.passing; }
            private set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentException($"{nameof(this.Passing)} should be between 0 and 100.");
                }

                this.passing = value;
            }
        }

        public int Shooting
        {
            get { return this.shooting; }
            private set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentException($"{nameof(this.Shooting)} should be between 0 and 100.");
                }

                this.shooting = value;
            }
        }

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }

        public int AverageStat ()
        {
            return (int)Math.Round((double)(this.Endurance + this.Sprint + this.Dribble + this.Passing + this.Shooting) / 5d);
        }
    }
}
