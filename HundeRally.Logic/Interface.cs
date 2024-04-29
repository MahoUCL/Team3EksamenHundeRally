using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundeRally.Logic
    public interface interface
{
    public interface IObstacleRepository
    {
        IEnumerable<Obstacle> GetAllObstacles();
        Obstacle GetObstacleById(int id);
        void AddObstacle(Obstacle obstacle);
        // ... other methods for CRUD operations on obstacles
    }

    public interface IObstacleCourseRepository
    {
        IEnumerable<ObstacleCourse> GetAllCourses();
        ObstacleCourse GetCourseById(int id);
        void AddCourse(ObstacleCourse course);
        bool ValidateCourse(ObstacleCourse course); // Reuse validation logic
                                                    // ... other methods for CRUD operations on obstacle courses
    }
}
