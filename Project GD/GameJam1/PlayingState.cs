<<<<<<< HEAD
﻿#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;
#endregion

namespace GameJam1
{
    class PlayingState : GameObjectList
    {                                      
        public PlayingState(ContentManager Content)
            : base()
        {
            //Add player1
            this.Add(new Player());


        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }
    }
}
=======
﻿using System;
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
>>>>>>> 79062ed69eca7aa14fc2d2afe6c4a44b9ba03db1
