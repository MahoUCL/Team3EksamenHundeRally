using Domain;
using HundeRally.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundeRally.Application.Services
{
    public class ObstacleService : IObstacleService
    {
        private readonly IObstacleRepository _obstacleRepository;

        public ObstacleService(IObstacleRepository obstacleRepository)
        {
            _obstacleRepository = obstacleRepository;
        }

        public async Task<IEnumerable<Obstacle>> GetAllObstaclesAsync()
        {
            return await _obstacleRepository.GetAllObstaclesAsync();
        }
    }
}
