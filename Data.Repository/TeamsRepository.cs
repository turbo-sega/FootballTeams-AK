using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Data.Repository
{
    public class TeamsRepository : IDisposable
    {
        private readonly AppDbContext _dbContext;

        public TeamsRepository(string connectionString)
        {
            var dbOptions = new DbContextOptionsBuilder<AppDbContext>().UseSqlServer(connectionString).Options;
            _dbContext = new AppDbContext(dbOptions);
        }

        public async Task<List<Team>> GeTeams()
        {
            var teams = await _dbContext.Teams.ToListAsync();

            return teams;
        }

        public async Task<List<Player>> GetTeamPlayers(int teamId)
        {
            var players = await _dbContext.Players.Where(p => p.TeamId == teamId).ToListAsync();

            return players;
        }

        public async Task<List<Championship>> GetTeamChampionships(int teamId)
        {
            var teamChampionshipIds = await _dbContext.TeamStatistics
                .Where(s => s.TeamId == teamId)
                .Select(s => s.ChampionshipId)
                .Distinct()
                .ToListAsync();

            var championships = await _dbContext.Championships
                .Where(c => teamChampionshipIds.Contains(c.Id))
                .ToListAsync();

            return championships;
        }

        public async Task<List<TeamStatistic>> GetTeamStatistics(int teamId, int championshipId)
        {
            var teamStatistics = await _dbContext.TeamStatistics
                .Where(s => s.TeamId == teamId && s.ChampionshipId == championshipId)
                .ToListAsync();

            return teamStatistics;
        }

        public void Dispose()
        {
            _dbContext?.Dispose();
        }
    }
}