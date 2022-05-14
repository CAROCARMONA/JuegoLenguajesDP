using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AtraparBooFinal
{
    class SpriteMas
    {
        protected Point Posicion { get; set; }
        public Point size { get; set; }


        protected Texture2D[] imagenes;

        public Rectangle rectangulo;
        public int cambiarI;
        public SpriteMas(Point _POSICION, Point _SIZE, int NumImagenes)
        {
            this.Posicion = _POSICION;
            size = _SIZE;
            imagenes = new Texture2D[NumImagenes];
            rectangulo = new Rectangle(Posicion, _SIZE);
        }
        public void Draw(GameTime gameTime, SpriteBatch spriteBatch, Color _COLOR)
        {
            spriteBatch.Begin();
            spriteBatch.Draw(imagenes[cambiarI], rectangulo, _COLOR);
            spriteBatch.End();
        }
    }
}