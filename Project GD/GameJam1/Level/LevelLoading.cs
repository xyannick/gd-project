using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GameJam1
{
    partial class Level : GameObjectList
    {

        public void LoadTiles(string path)
        {
            int width;
            List<string> textlines = new List<string>();
            StreamReader fileReader = new StreamReader(path);
            string line = fileReader.ReadLine();
            width = line.Length;
            while (line != null)
            {
                textlines.Add(line);
                line = fileReader.ReadLine();
            }
            TileField tiles = new TileField(textlines.Count - 1, width, 1, "tiles");

            this.Add(tiles);
            tiles.CellWidth = 32;
            tiles.CellHeight = 32;

            for (int x = 0; x < width; ++x)
            {
                for (int y = 0; y < textlines.Count - 1; ++y)
                {
                    Tile t = LoadTile(textlines[y][x], x, y);
                    tiles.Add(t, x, y);
                }
            }
        }

        private Tile LoadTile(char tileType, int x, int y)
        {
            switch (tileType)
            {
                case '.': //Ondergrond
                    return LoadBasicTile("spr_ground",TileType.Background);
                case 'X'://Wall
                    return LoadBasicTile("spr_wall", TileType.Normal);
                default:
                    return new Tile("");
            }
        }

        private Tile LoadBasicTile(string name, TileType tileType)
        {
            Tile t = new Tile("Sprites/TileSprites/"+name, tileType, 0);
            return t;
        }

    }
}
