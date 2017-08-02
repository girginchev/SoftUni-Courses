namespace TeamworkProjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Team
    {
        public Team(string name, string creatorName)
        {
            Name = name;
            CreatorName = creatorName;
            Members = new List<string>();
        }

        public string Name { get; set; }

        public List<string> Members { get; set; }

        public string CreatorName { get; set; }
    }
    public class TeamworkProjects
    {
        public static void Main()
        {
            var teams = new List<Team>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var teamCreate = Console.ReadLine().Split('-');
                var creatorName = teamCreate[0];
                var teamName = teamCreate[1];
                var team = new Team(teamName, creatorName);
                if (teams.Select(x => x.Name).Contains(teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                else if (teams.Select(x => x.CreatorName).Contains(creatorName))
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                    continue;
                }
                else
                {
                    Console.WriteLine($"Team {team.Name} has been created by {team.CreatorName}!");
                    teams.Add(team);
                }
            }

            var input = Console.ReadLine();

            while (input != "end of assignment")
            {
                var memberJoin = input.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var member = memberJoin[0];
                var team = memberJoin[1];
                if (teams.Select(x => x.Name).Contains(team))
                {

                    if (teams.Any(b => b.Members.Contains(member)) || teams.Any(b => b.CreatorName == member))
                    {
                        Console.WriteLine($"Member {member} cannot join team {team}!");
                    }
                    else
                    {
                        teams.First(d => d.Name == team).Members.Add(member);
                    }
                }
                else
                {
                    Console.WriteLine($"Team {team} does not exist!");
                }

                input = Console.ReadLine();
            }
            var teamWithMembers = teams.Where(x => x.Members.Count > 0).ToList();
            var teamWithoutMembers = teams.Where(x => x.Members.Count == 0).ToList().OrderBy(x=>x.Name);

            foreach (var team in teamWithMembers.OrderByDescending(x => x.Members.Count()).ThenBy(x => x.Name))
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.CreatorName}");
                foreach (var member in team.Members)
                {
                    Console.WriteLine("{0} {1}", new string('-', 2), member);
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (var team in teamWithoutMembers)
            {
                Console.WriteLine($"{team.Name}");
            }

        }
    }
}

