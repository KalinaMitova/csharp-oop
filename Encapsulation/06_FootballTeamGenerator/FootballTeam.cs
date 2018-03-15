using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//A team should expose a name, a rating (calculated by the average skill level of all players in the team) and methods for adding and removing 
//players.
//•	If you receive a command to remove a missing player, print "Player [Player name] is not in [Team name] team. "
//•	If you receive a command to add a player to a missing team, print "Team [team name] does not exist."
//•	If you receive a command to show stats for a missing team, print "Team [team name] does not exist."
namespace _06_FootballTeamGenerator
{
    public class FootballTeam
    {
        private string name;
        private Dictionary<string,Player> players;
        private double raiting;

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

        public double Raiting => this.raiting;

        public FootballTeam()
        {
            this.players = new Dictionary<string, Player>();
        }

        public FootballTeam(string name)
        {
            this.Name = name;
            this.players = new Dictionary<string, Player>();
        }

        public void AddPlayer (Player player)
        {
            this.players.Add(player.Name,player);
            this.raiting += player.AverageStat();
        }

        public void RemovePlayer (string playerName)
        {
            if (this.players.ContainsKey(playerName))
            {
                this.raiting -= players[playerName].AverageStat();
                players.Remove(playerName);
            }
            else
            {
                throw new OperationCanceledException($"Player {playerName} is not in {this.Name.ToString()} team." );
            }
        }

        private int GetRaiting()
        {
            if (this.players.Count == 0)
            {
                return 0;
            }
            else
            {
                return (int) Math.Round((raiting / players.Count));
            }
        }
        public override string ToString()
        {
            return $"{this.Name} - {GetRaiting()}";
        }
    }
}
