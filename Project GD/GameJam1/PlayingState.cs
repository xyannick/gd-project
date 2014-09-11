#region Using Statements
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
