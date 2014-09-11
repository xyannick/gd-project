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

    public class GameJam1 : GameEnvironment
    {

        static void Main()
        {
            using (var game = new GameJam1())
                game.Run();
        }

        public GameJam1()
            : base()
        {
            Content.RootDirectory = "Content";
        }

        protected override void LoadContent()
        {
            base.LoadContent();
            screen = new Point(1280, 720);
            this.SetFullScreen(true);
            this.IsMouseVisible = true;

            gameStateManager.AddGameState("playingState", new PlayingState(Content));

            gameStateManager.SwitchTo("playingState");
        }
    }
}
