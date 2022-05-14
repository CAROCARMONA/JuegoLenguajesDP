using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace AtraparBooFinal
{
    class FondoNivel : SpriteMas
    {
        Game1 ruta;
        private int XXX = -1;
        private int Tiempo = 0;


        public FondoNivel(Game1 Laruta) : base(new Point(0, -100), new Point(1700, 900), 2)
        {
            this.ruta = Laruta;


            this.LoadContent();
        }
        private void LoadContent()
        {
            for (int i = 0; i < 2; i++)
            {
                imagenes[i] = this.ruta.Content.Load<Texture2D>("fondoNivel" + (i + 1));
            }


        }
        public void MoviDerecha()
        {
            XXX += 1;
            rectangulo = new Rectangle(XXX, -100, 1700, 900);
        }
        public void MoviIzqui()
        {
            XXX -= 1;
            rectangulo = new Rectangle(XXX, -100, 1700, 900);
        }
        public void Update(GameTime gameTime)
        {
            Tiempo += 1;
            rectangulo.X = XXX;
            if (Tiempo < 300)
            {
                MoviIzqui();
            }
            if (Tiempo >= 300)
            {
                MoviDerecha();
            }
            if (Tiempo == 600)
            {
                Tiempo = 0;
            }






        }
        public new void Draw(GameTime gameTime, SpriteBatch spriteBatch, Color _COLOR)
        {

            spriteBatch.Draw(imagenes[cambiarI], rectangulo, _COLOR);

        }
    }
}
