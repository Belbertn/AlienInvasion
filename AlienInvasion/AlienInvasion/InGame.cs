﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;

namespace AlienInvasion
{
    class InGame : IGameState
    {
        private MainGame mainGame;
        private SpriteBatch spriteBatch;

        public List<IEntity> Entities { get; set; }

        public void Initialize(MainGame mainGame, SpriteBatch spriteBatch)
        {
            this.mainGame = mainGame;
            this.spriteBatch = spriteBatch;

            Entities = new List<IEntity>();
        }

        public void UnLoad()
        {

        }

        public void Load()
        {

        }

        public void Update(GameTime gameTime)
        {

        }

        public void Draw()
        {

        }
    }
}