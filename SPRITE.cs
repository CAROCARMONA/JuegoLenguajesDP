﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AtraparBooFinal
{
    class SPRITE
    {
        protected Point Posicion { get; set; }
        public Point size { get; set; }

        protected string imagen1;
        protected Texture2D imagen;
        //Rectangle rectangulo;
        public Rectangle rectangulo;
        public SPRITE(Point _POSICION, Point _SIZE)
        {
            this.Posicion = _POSICION;
            size = _SIZE;
            rectangulo = new Rectangle(Posicion, _SIZE);
        }
        public void Draw(GameTime gameTime, SpriteBatch spriteBatch, Color _COLOR)
        {

            spriteBatch.Draw(imagen, rectangulo, _COLOR);

        }
    }
}
