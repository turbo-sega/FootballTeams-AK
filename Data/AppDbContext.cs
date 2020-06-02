using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {
        }
        
        public DbSet<Team> Teams { get; set; }
        
        public DbSet<Player> Players { get; set; }
        
        public DbSet<Championship> Championships { get; set; }

        public DbSet<TeamStatistic> TeamStatistics { get; set; }
        

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedData(builder);
        }

        private void SeedData(ModelBuilder builder)
        {
            var teamJuventus = new Team { Id = 1, Name = "Ювентус", City = "Турин", Coaches = "Мауріціо Саррі", Country = "Італія", GameScheme = "2-4-4" };
            var teamBarca = new Team { Id = 2, Name = "Барселона", City = "Барселона", Coaches = "Ернесто Вальверде", Country = "Іспанія", GameScheme = "2-4-4" };
            var teamLiverpool = new Team { Id = 3, Name = "Ліверпуль", City = "Енфілд", Coaches = "Юрген Клопп", Country = "Англія", GameScheme = "2-4-4" };

            builder.Entity<Team>().HasData(teamJuventus, teamBarca, teamLiverpool);

            builder.Entity<Player>().HasData(new List<Player>
            {
                new Player {Id = 1, TeamId = 1, Name = "Войчех Шченсний", Number = "1"},
                new Player {Id = 2, TeamId = 1, Name = "Леонардо Бонуччі", Number = "19"},
                new Player {Id = 3, TeamId = 1, Name = "Матейс де Лігт", Number = "4"},
                new Player {Id = 4, TeamId = 1, Name = "Алекс Сандро", Number = "12"},
                new Player {Id = 5, TeamId = 1, Name = "Даніло", Number = "13"},
                new Player {Id = 6, TeamId = 1, Name = "Миралем Пяніч", Number = "5"},
                new Player {Id = 7, TeamId = 1, Name = "Блез Матюіді", Number = "14"},
                new Player {Id = 8, TeamId = 1, Name = "Айрон Ремзі", Number = "8"},
                new Player {Id = 9, TeamId = 1, Name = "Пауло Дібала", Number = "10"},
                new Player {Id = 10, TeamId = 1, Name = "Фредеріко Бернандескі", Number = "33"},
                new Player {Id = 11, TeamId = 1, Name = "Кріштіану Роналду", Number = "7"},

                new Player {Id = 12, TeamId = 2, Name = "Марк-Андре тер Штеген", Number = "22"},
                new Player {Id = 13, TeamId = 2, Name = "Нелсон Семеду", Number = "2"},
                new Player {Id = 14, TeamId = 2, Name = "Жерар Піке", Number = "3"},
                new Player {Id = 15, TeamId = 2, Name = "Жоржи Альба", Number = "18"},
                new Player {Id = 16, TeamId = 2, Name = "Самюель Умтіті", Number = "23"},
                new Player {Id = 17, TeamId = 2, Name = "Артуро Відаль", Number = "22"},
                new Player {Id = 18, TeamId = 2, Name = "Френкі де йонг", Number = "21"},
                new Player {Id = 19, TeamId = 2, Name = "Усман Дембеле", Number = "11"},
                new Player {Id = 20, TeamId = 2, Name = "Антуан Грізман", Number = "17"},
                new Player {Id = 21, TeamId = 2, Name = "Луіс Суарес", Number = "9"},
                new Player {Id = 22, TeamId = 2, Name = "Ліонель Мессі", Number = "10"},

                new Player {Id = 23, TeamId = 3, Name = "Алісон Беккер", Number = "13"},
                new Player {Id = 24, TeamId = 3, Name = "Трент Александр-Арнольд", Number = "66"},
                new Player {Id = 25, TeamId = 3, Name = "Вірджил ван Дейк", Number = "4"},
                new Player {Id = 26, TeamId = 3, Name = "Джо Гомес", Number = "12"},
                new Player {Id = 27, TeamId = 3, Name = "Ендрю Робертсон", Number = "26"},
                new Player {Id = 28, TeamId = 3, Name = "Садіо Мане", Number = "10"},
                new Player {Id = 29, TeamId = 3, Name = "Джордан Хендерсон", Number = "14"},
                new Player {Id = 30, TeamId = 3, Name = "Фабіньйо", Number = "3"},
                new Player {Id = 31, TeamId = 3, Name = "Мохамед салах", Number = "11"},
                new Player {Id = 32, TeamId = 3, Name = "Роберто Фірміно", Number = "9"},
                new Player {Id = 33, TeamId = 3, Name = "Дивок Орігі", Number = "27"}
            });

            var championshipSeriaA = new Championship {Id = 1, Name = "Серія А", Country = "Італія", IsNational = true};
            var championshipItalyCup = new Championship {Id = 2, Name = "Кубок Італії", Country = "Італія", IsNational = true};
            var championshipLaLiga = new Championship {Id = 3, Name = "Ла-Ліга", Country = "Іспанія", IsNational = true};
            var championshipSpainCup = new Championship {Id = 4, Name = "Кубок Іспанії", Country = "Іспанія", IsNational = true};
            var championshipPremierLeague = new Championship { Id = 5, Name = "Прем\'єр-ліга", Country = "Англія", IsNational = true };
            var championshipEnglandCup = new Championship { Id = 6, Name = "Кубок Англії", Country = "Англія", IsNational = true };
            var championshipUEFA = new Championship { Id = 7, Name = "Ліга чемпіонів УЄФА", Country = "", IsNational = false };
            builder.Entity<Championship>().HasData(championshipSeriaA, championshipItalyCup, championshipLaLiga, 
                championshipSpainCup, championshipPremierLeague, championshipEnglandCup, championshipUEFA);

            var teamStatistics = new List<TeamStatistic>();
            var id = 1;
            
            // Ювентус - Серія А (1)
            teamStatistics.AddRange(GenerateTeamStatistics(teamJuventus, championshipSeriaA, 
                new []{"1983/84", "1985/86", "1994/95", "1996/97", "1997/98", "2001/02", "2002/03", "2004/05", "2005/06", "2011/12", 
                    "2012/13", "2013/14", "2014/15", "2015/16", "2016/17", "2017/18", "2018/19"}, id, out id));
            // Ювентус - Кубок Італії (2)
            teamStatistics.AddRange(GenerateTeamStatistics(teamJuventus, championshipItalyCup, 
                new []{"1982/83", "1989/90", "1994/95", "2014/15", "2015/16", "2017/18"}, id, out id));
            // Ювентус - Ліга чемпіонів УЄФА (7)
            teamStatistics.AddRange(GenerateTeamStatistics(teamJuventus, championshipUEFA, 
                new []{"1984/85", "1995/96"}, id, out id));
            

            // Барселона - Ла-Ліга (3)
            teamStatistics.AddRange(GenerateTeamStatistics(teamBarca, championshipLaLiga, 
                new []{"1992/93", "1994/95", "1998/99", "2004/05", "2005/06", "2008/09", "2009/10", "2010/11", "2012/13", "2014/15", 
                    "2015/16", "2017/18"}, id, out id));
            // Барселона - Кубок Іспанії (4)
            teamStatistics.AddRange(GenerateTeamStatistics(teamBarca, championshipSpainCup, 
                new []{"1978", "1981", "1988", "1990", "1997", "1998", "2009", "2012", "2015", "2016", "2017", "2018"}, id, out id));
            // Барселона - Ліга чемпіонів УЄФА (7)
            teamStatistics.AddRange(GenerateTeamStatistics(teamBarca, championshipUEFA, 
                new []{"1992", "2006", "2009", "2011", "2015"}, id, out id));
            

            // Ліверпуль - Прем'єр-ліга (5)
            teamStatistics.AddRange(GenerateTeamStatistics(teamLiverpool, championshipPremierLeague, 
                new []{"1979/80", "1981/82", "1985/86", "1987/88", "1989/90"}, id, out id));
            // Ліверпуль - Кубок Англії (6)
            teamStatistics.AddRange(GenerateTeamStatistics(teamLiverpool, championshipEnglandCup, 
                new []{"1965", "1974", "1986", "1989", "1992", "2001", "2006"}, id, out id));
            // Ліверпуль - Ліга чемпіонів УЄФА (7)
            teamStatistics.AddRange(GenerateTeamStatistics(teamLiverpool, championshipUEFA, 
                new []{"1977", "1978", "1981", "1984", "2005", "2019"}, id, out id));


            builder.Entity<TeamStatistic>().HasData(teamStatistics);
        }
        
        private List<TeamStatistic> GenerateTeamStatistics(Team team, Championship championship, string[] years, int currentId, out int nextId)
        {
            nextId = currentId;
            var list = new List<TeamStatistic>();
            foreach (var year in years)
            {
                list.Add(new TeamStatistic {Id = currentId, TeamId = team.Id, ChampionshipId = championship.Id, Years = year, IsChampion = true});
                currentId++;
            }
            nextId = currentId;
            return list;
        }
    }
}

//new List<TeamStatistic>
            //{
            //    // Ювентус - Серія А (1)
            //    new TeamStatistic {Id = 1, TeamId = 1, ChampionshipId = 1, Years = "1983/84", IsChampion = true},
            //    new TeamStatistic {Id = 2, TeamId = 1, ChampionshipId = 1, Years = "1985/86", IsChampion = true},
            //    new TeamStatistic {Id = 3, TeamId = 1, ChampionshipId = 1, Years = "1994/95", IsChampion = true},
            //    new TeamStatistic {Id = 4, TeamId = 1, ChampionshipId = 1, Years = "1996/97", IsChampion = true},
            //    new TeamStatistic {Id = 5, TeamId = 1, ChampionshipId = 1, Years = "1997/98", IsChampion = true},
            //    new TeamStatistic {Id = 6, TeamId = 1, ChampionshipId = 1, Years = "2001/02", IsChampion = true},
            //    new TeamStatistic {Id = 7, TeamId = 1, ChampionshipId = 1, Years = "2002/03", IsChampion = true},
            //    new TeamStatistic {Id = 8, TeamId = 1, ChampionshipId = 1, Years = "2004/05", IsChampion = true},
            //    new TeamStatistic {Id = 9, TeamId = 1, ChampionshipId = 1, Years = "2005/06", IsChampion = true},
            //    new TeamStatistic {Id = 10, TeamId = 1, ChampionshipId = 1, Years = "2011/12", IsChampion = true},
            //    new TeamStatistic {Id = 11, TeamId = 1, ChampionshipId = 1, Years = "2012/13", IsChampion = true},
            //    new TeamStatistic {Id = 12, TeamId = 1, ChampionshipId = 1, Years = "2013/14", IsChampion = true},
            //    new TeamStatistic {Id = 13, TeamId = 1, ChampionshipId = 1, Years = "2014/15", IsChampion = true},
            //    new TeamStatistic {Id = 14, TeamId = 1, ChampionshipId = 1, Years = "2015/16", IsChampion = true},
            //    new TeamStatistic {Id = 15, TeamId = 1, ChampionshipId = 1, Years = "2016/17", IsChampion = true},
            //    new TeamStatistic {Id = 16, TeamId = 1, ChampionshipId = 1, Years = "2017/18", IsChampion = true},
            //    new TeamStatistic {Id = 17, TeamId = 1, ChampionshipId = 1, Years = "2018/19", IsChampion = true},

            //    // Ювентус - Кубок Італії (2)
            //    new TeamStatistic {Id = 18, TeamId = 1, ChampionshipId = 2, Years = "1983/84", IsChampion = true},

            //});