using System;
using System.Collections.Generic;

using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AlienInvasion
{
    class MainGame
    {
        public Alien Alien { get; private set; }
        public ContentManager ContentManager { get; private set; }

        private IGameState gameState;

        public SpriteBatch SpriteBatch { get; private set; }

        public void Initialize(Alien alien, SpriteBatch spriteBatch)
        {
            Alien = alien;

            SpriteBatch = spriteBatch;

            gameState = new InGame();
            gameState.Initialize(this, SpriteBatch);
        }

        public void Load(ContentManager contentManager)
        {
            ContentManager = contentManager;
        }

        public void UnLoad()
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