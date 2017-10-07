using System;
using System.Collections.Generic;

using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AlienInvasion
{
    class MainGame
    {
        public Alien alien { get; private set; }
        public ContentManager contentManager { get; private set; }

        public void Initialize(Alien alien)
        {
            this.alien = alien;
        }

        public void Load(ContentManager contentManager)
        {
            this.contentManager = contentManager;
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