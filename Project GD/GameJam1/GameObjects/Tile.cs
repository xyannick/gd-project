using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace GameJam1
{
    enum TileType
    {
        Background,
        Normal,
        Platform
    }

    class Tile : SpriteGameObject
    {
        protected TileType type;

        public Tile(string assetname, TileType tp = TileType.Background, int layer = 0, string id = "")
            : base(assetname, layer, id)
        {
            type = tp;

        }

        public override void Draw(Microsoft.Xna.Framework.GameTime gameTime, Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch)
        {
            base.Draw(gameTime, spriteBatch);
        }

        public TileType TileType
        {
            get { return type; }
        }

    }
}
