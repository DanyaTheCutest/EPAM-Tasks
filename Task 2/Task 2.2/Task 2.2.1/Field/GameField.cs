using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2._2._1.Characters;
using Task_2._2._1.Characters.Enemies;
using Task_2._2._1.Bonuses;
namespace Task_2._2._1.Field
{
    enum ObstacleType
    {
        Bush,
        Mushroom,
        Pit,
        Rock
    }
    enum EnemyType
    {
        Bear,
        Squirrel,
        Wolf
    }
    enum BonusType
    {
        Apple,
        Berry,
        Cone
    }
    class GameField
    {
        public int Width { get; init; }
        public int Height { get; init; }
        EnemySpawner spawner = new EnemySpawner();
        public GameField(int width, int height)
        {
            throw new NotImplementedException();
        }       
    }
}
