using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//A football team has variable number of players, a name and a rating. 
//A player has a name and stats which are the basis for his skill level.The stats a player has are endurance, sprint, dribble, passing and shooting.
//Each stat can be in the range[0..100]. The overall skill level of a player is calculated as the average of his stats.Only the name of a player
//and his stats should be visible to all of the outside world.Everything else should be hidden.
//A team should expose a name, a rating (calculated by the average skill level of all players in the team) and methods for adding and removing 
//players.
//Your task is to model the team and the players following the proper principles of Encapsulation.Expose only the properties that needs to be 
//visible and validate data appropriately.
//Data Validation
//•	A name cannot be null, empty or white space. If not, print "A name should not be empty. "
//•	Stats should be in the range 0..100. If not, print "[Stat name] should be between 0 and 100. "
//•	If you receive a command to remove a missing player, print "Player [Player name] is not in [Team name] team. "
//•	If you receive a command to add a player to a missing team, print "Team [team name] does not exist."
//•	If you receive a command to show stats for a missing team, print "Team [team name] does not exist."

namespace _06_FootballTeamGenerator
{
   public class FootballTeamGenerator
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, FootballTeam> teams = new Dictionary<string, FootballTeam>();

            FootballTeam team = new FootballTeam();

            while (input[0] != "END")
            {
                switch (input[0])
                {
                    case "Team":
                        {
                            try
                            {
                                team = new FootballTeam(input[1]);
                                if (!teams.ContainsKey(input[1]))
                                {
                                    teams.Add(input[1], team);
                                }
                            }
                            catch (ArgumentException ex)
                            {

                                Console.WriteLine(ex.Message);
                            }
                        }
                        break;
                    case "Add":
                        {
                            
                            if (teams.ContainsKey(input[1]))
                            {
                                try
                                {
                                    Player player = new Player(input[2], int.Parse(input[3]), int.Parse(input[4]),
                                    int.Parse(input[5]), int.Parse(input[6]), int.Parse(input[7]));
                                    teams[input[1]].AddPlayer(player);
                                }
                                catch (ArgumentException ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }   
                            }
                            else
                            {
                                Console.WriteLine($"Team {input[1]} does not exist.");
                            }
                        }
                        break;
                    case "Remove":
                        {
                            if (teams.ContainsKey(input[1]))
                            {
                                try
                                {
                                    teams[input[1]].RemovePlayer(input[2]);
                                }
                                catch (OperationCanceledException ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Team {input[1]} does not exist.");
                            }
                        }
                        break;
                    case "Rating":
                        {
                            if (teams.ContainsKey(input[1]))
                            {
                                Console.WriteLine(teams[input[1]]);
                            }
                            else
                            {
                                Console.WriteLine($"Team {input[1]} does not exist.");
                            }
                        }
                        break;
                }

                input = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            }              
        }
    }
}
