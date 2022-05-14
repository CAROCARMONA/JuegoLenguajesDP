using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;

namespace AtraparBooFinal
{
    class Men : SpriteMas
    {
        Game1 ruta;

        private int TIEMPO = 0;
        private int TIEMPO2 = 0;
        public int contaM = 0;
        private int VISIBLE = 0;
        public int SSY = 400;
        public int SSX = 1200;
        private int CONTA = 0;

        //codigo de objetos
        public Boome boomeran;
        //Song sonido1;
        public Men(Game1 Laruta, Point laposicion) : base(laposicion, new Point(150, 400), 2)
        {
            this.ruta = Laruta;

            boomeran = new Boome(Laruta, new Point(1200, 300));
            this.LoadContent();
        }
        private void LoadContent()
        {
            for (int i = 0; i < 2; i++)
            {
                imagenes[i] = this.ruta.Content.Load<Texture2D>("hombre" + (i + 1));
            }
            //sonido1 = this.ruta.Content.Load<Song>("BOOMERANsonido");
   
        }
        public void Update(GameTime gameTime)
        {
            TIEMPO += 1;

            if (TIEMPO % 200 == 0)
            {
                SSY += 25;
                rectangulo.Y = SSY;

                contaM += 1;
                cambiarI = 1;

            }
            if (VISIBLE == 1 && TIEMPO2 % 50 == 0)
            {
                VISIBLE = 0;
                contaM = 0;
                cambiarI = 0;
                CONTA += 1;
            }
            if (SSY == 400)
            {
                SSY = 100;
            }



            //code boomeran
            boomeran.rectangulo.X = boomeran.ssx;
            boomeran.rectangulo.Y = boomeran.ssy;

            if (VISIBLE != 1)
            {

                if (boomeran.ssy >= 400)
                {
                    boomeran.tiro1();
                }
                if (boomeran.ssy < 400)
                {
                    boomeran.tiro2();
                    // MediaPlayer.Play(sonido1);

                }
                boomeran.velocidadBoomeran += 2;

                if (boomeran.velocidadBoomeran == 14)
                {
                    boomeran.velocidadBoomeran = 4;
                }

            }




        }
        public new void Draw(GameTime gameTime, SpriteBatch spriteBatch, Color _COLOR)
        {


            if (VISIBLE != 1)
            {
                boomeran.Draw(gameTime, spriteBatch, Color.White);
                spriteBatch.Draw(imagenes[cambiarI], rectangulo, _COLOR);

            }
            if (contaM == 1)
            {
                spriteBatch.Draw(imagenes[cambiarI], rectangulo, Color.White);
                VISIBLE = 1;
                TIEMPO2 += 1;
                boomeran.ssy = 400;
                boomeran.ssx = 1200;


            }

        }

    }
}
