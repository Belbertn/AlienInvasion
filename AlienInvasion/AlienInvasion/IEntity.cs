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
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AlienInvasion
{
    interface IEntity
    {
        Vector2 Position { get; set; }
        void Initialize(Alien a, SpriteBatch spriteBatch);
        void Load();
        void Update(GameTime gameTime);
        void Draw();
    }
}