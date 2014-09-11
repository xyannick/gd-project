using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GameJam1
{
    class PlayingState : GameObjectList
    {
        GameObjectList levels;

        public PlayingState()
        {
            levels = new GameObjectList(0,"levels");
            levels.Add(new Level(1));
            this.Add(levels);
        }

        public override void Update(Microsoft.Xna.Framework.GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(Microsoft.Xna.Framework.GameTime gameTime, Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch)
        {
            base.Draw(gameTime, spriteBatch);
        }
    }
}
