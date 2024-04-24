using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundeRally.Domain.Interfaces
{
    public interface IObstacleRepository
    {
        Task<IEnumerable<Obstacle>> GetAllObstaclesAsync();

    }
}
