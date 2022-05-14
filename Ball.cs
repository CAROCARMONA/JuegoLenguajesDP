using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AtraparBooFinal
{
    class Ball : SPRITE
    {
        Point velocidad1;
        Point velocidad2;
        Game1 ruta;

        public Ball(Game1 laruta, Point laposicion) : base(laposicion, new Point(50, 50))
        {
            velocidad1 = new Point(10, 0);
            velocidad2 = new Point(12, 1);
            ruta = laruta;
            this.imagen1 = "bola1";
            this.LoadContent();

        }
        private void LoadContent()
        {
            imagen = this.ruta.Content.Load<Texture2D>(imagen1);
        }





    }
}
