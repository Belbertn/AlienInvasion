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

        public void Initialize(Alien alien)
        {
            Alien = alien;
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

        public void Draw(SpriteBatch spriteBatch)
        {

        }
    }
}