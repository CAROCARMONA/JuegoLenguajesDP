using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AtraparBooFinal
{
    class Men2 : SpriteMas
    {
        Game1 ruta;

        private int TIEMPO = 0;
        private int TIEMPO2 = 0;
        public int contaM = 0;
        private int VISIBLE = 0;
        public int SSY = 100;
        public int SSX = 1200;

        //code de ball
        public int XXball = 1200;
        public int YYball = 400;
        public int tiro = 0;
        //codigo de objetos
        public Ball ball;
        public Men2(Game1 Laruta, Point laposicion) : base(laposicion, new Point(150, 400), 2)
        {
            this.ruta = Laruta;

            ball = new Ball(Laruta, new Point(1000, 300));
            this.LoadContent();
        }
        private void LoadContent()
        {
            for (int i = 0; i < 2; i++)
            {
                imagenes[i] = this.ruta.Content.Load<Texture2D>("2hombre" + (i + 1));
            }
        }
        public void tiro1()
        {

            // Posicion -= velocidad1;
            //  rectangulo = new Rectangle(Posicion, new Point(50, 50));
            XXball -= 10;
            ball.rectangulo.X = XXball;
        }
        public void tiro2()
        {
            XXball -= 15;
            YYball = -1;
            ball.rectangulo.X = XXball;
            ball.rectangulo.Y = YYball;

        }
        public void Update(GameTime gameTime)
        {
            TIEMPO += 1;

            if (TIEMPO % 200 == 0)
            {
                XXball = 1100;

                SSY += 20;
                YYball = SSY;

                rectangulo.Y = SSY;

                contaM += 1;
                cambiarI = 1;

            }
            if (VISIBLE == 1 && TIEMPO2 % 50 == 0)
            {
                VISIBLE = 0;
                contaM = 0;
                cambiarI = 0;

            }
            if (SSY == 300)
            {
                SSY = 100;
            }


            if (VISIBLE != 1)
            {

                tiro1();


            }



        }
        public new void Draw(GameTime gameTime, SpriteBatch spriteBatch, Color _COLOR)
        {


            if (VISIBLE != 1)
            {

                ball.Draw(gameTime, spriteBatch, Color.White);
                spriteBatch.Draw(imagenes[cambiarI], rectangulo, _COLOR);

            }
            if (contaM == 1)
            {

                spriteBatch.Draw(imagenes[cambiarI], rectangulo, Color.White);
                VISIBLE = 1;
                TIEMPO2 += 1;

                ball.rectangulo.Y = SSY + 200;
                ball.rectangulo.X = SSX;

            }


        }

    }
}

