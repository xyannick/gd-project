using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameJam1
{
    partial class Level : GameObjectList
    {

        public Level(int levelIndex)
        {

            levelIndex = 1;
            LoadTiles("Content/Levels/level" + levelIndex + ".txt");
        }
    }
}