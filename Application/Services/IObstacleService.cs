﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundeRally.Application.Services
{
    public interface IObstacleService
    {
        Task<IEnumerable<Obstacle>> GetAllObstaclesAsync();
        //Resterende CRUD operationer herunder
    }
}
