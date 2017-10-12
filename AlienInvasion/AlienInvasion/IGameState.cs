using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace AlienInvasion
{
    interface IGameState
    {
        void Initialize(Alien a, SpriteBatch spriteBatch);
        void Load(ContentManager content);
        void Update(GameTime gameTime);
        void Draw();
    }
}