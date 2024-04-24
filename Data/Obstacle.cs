using System.Runtime.CompilerServices;

namespace Domain
{
    public class Obstacle
    {
        int ObstacleId { get; set; }
        string Name { get; set; }
        bool IsSign { get; set; }
        string Image { get; set; }

        public Obstacle(int obstacleId, string name, bool isSign, string image)
        {
            ObstacleId = obstacleId;
            Name = name;
            IsSign = isSign;
            Image = image;
        }


    }
}
