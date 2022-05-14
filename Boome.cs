using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AtraparBooFinal
{
    class Boome : SpriteMas
    {
        Game1 ruta;
        public int ssy = 400;
        public int ssx = 1400;
        public int velocidadBoomeran = 4;
        public int valorX = 10;
        public int valorY = 3;


        //invoco a rec de men

        public Boome(Game1 Laruta, Point laposicion) : base(laposicion, new Point(60, 100), 4)
        {
            this.ruta = Laruta;



            this.LoadContent();
        }
        private void LoadContent()
        {
            for (int i = 0; i < 4; i++)
            {
                imagenes[i] = this.ruta.Content.Load<Texture2D>("Boomeran" + (i + 1));
            }

        }
        public void tiro2()// boomeran
        {
            if (ssx > -1 && ssx < 1331)
            {
                cambiarI += 1;
                ssx += valorX + velocidadBoomeran;
                if (ssx < 700)
                {
                    ssy -= (valorY + velocidadBoomeran);
                }
                else if (ssx >= 700)
                {
                    ssy += valorY + velocidadBoomeran;
                }
                if (cambiarI > 3)
                {
                    cambiarI = 0;
                }
            }

        }
        public void tiro1()//por abajo
        {

            if (ssx < 1800 && ssx > 0)
            {
                cambiarI += 1;
                ssx -= (valorX + velocidadBoomeran);
                if (ssx > 700)
                {
                    ssy += valorY + velocidadBoomeran;
                }
                else if (ssx <= 700)
                {
                    ssy -= (valorY + velocidadBoomeran);
                }
                if (cambiarI > 3)
                {
                    cambiarI = 0;
                }

            }


        }

        public new void Draw(GameTime gameTime, SpriteBatch spriteBatch, Color _COLOR)
        {

            spriteBatch.Draw(imagenes[cambiarI], rectangulo, Color.Black);
        }
    }
}

