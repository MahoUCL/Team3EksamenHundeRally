using Domain;
using HundeRally.Domain.Interfaces;
using HundeRally.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundeRally.Infrastructure.Repositories
{
    public class ObstacleRepository : IObstacleRepository
    {
        private readonly AppDbContext _context;

        public ObstacleRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Obstacle>> GetAllObstaclesAsync()
        {
            return await _context.Obstacles.ToListAsync();
        }

        public async Task<Obstacle> GetObstacleByIdAsync(int id)
        {
            return await _context.Obstacles.FindAsync(id);
        }

        public async Task AddObstacleAsync(Obstacle obstacle)
        {
            _context.Obstacles.Add(obstacle);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateObstacleAsync(Obstacle obstacle)
        {
            _context.Obstacles.Update(obstacle);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteObstacleAsync(int id)
        {
            var obstacle = await _context.Obstacles.FindAsync(id);
            _context.Obstacles.Remove(obstacle);
            await _context.SaveChangesAsync();
        }


    }
}

    
