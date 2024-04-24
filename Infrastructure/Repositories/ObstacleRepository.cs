﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundeRally.Infrastructure.Repositories
{
    public class ObstacleRepository : IObstacleRepository
    {
        private readonly ApplicationDbContext _context;

        public ObstacleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Obstacle>> GetAllObstaclesAsync()
        {
            return await Task.FromResult(_context.Obstacles);
        }
    }
}
