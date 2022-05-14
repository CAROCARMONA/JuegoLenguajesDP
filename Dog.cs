using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace AtraparBooFinal
{
    class Dog : SpriteMas
    {
        Game1 ruta;
        public int ssX = 50;
        public int ssY = 200;
        private int contatiempo = 0;
        private int TIEMPO = 0;
        private int contasaltos = 0;
        private int contasaltos2 = 0;
        public Dog(Game1 Laruta, Point laposicion) : base(laposicion, new Point(100, 100), 8)
        {
            this.ruta = Laruta;


            this.LoadContent();
        }
        private void LoadContent()
        {
            for (int i = 0; i < 8; i++)
            {
                imagenes[i] = this.ruta.Content.Load<Texture2D>("perro" + (i + 1));
            }
        }
        public void Update(GameTime gameTime)
        {
            var kState = Keyboard.GetState();

            rectangulo.X = ssX;
            rectangulo.Y = ssY;

            contatiempo++;
            if (kState.IsKeyDown(Keys.Up))//arriba
            {
                if (ssY > 10)
                {
                    cambiarI += 1;//todrau
                    ssY -= 10;
                    ssX += 3;

                    if (cambiarI > 7)
                    {
                        cambiarI = 4;
                    }
                }
            }

            if (kState.IsKeyDown(Keys.Down))//abajo
            {
                if (ssY < 740)
                {
                    cambiarI += 1;//todrau
                    ssY += 10;
                    ssX += 3;


                    if (cambiarI > 7)
                    {
                        cambiarI = 4;
                    }
                }


            }
            if (kState.IsKeyDown(Keys.Right))//derecha
            {

                if (ssX < 1000)
                {
                    cambiarI += 1;//todrau
                    ssX += 10;

                    if (cambiarI > 7)
                    {
                        cambiarI = 5;
                    }
                }
            }
            if (kState.IsKeyDown(Keys.Left))//izquierda
            {

                if (ssX > 5)
                {
                    cambiarI += 1;//todrau
                    ssX -= 10;

                    if (cambiarI > 4)
                    {
                        cambiarI = 0;
                    }

                }

            }


            if (kState.IsKeyDown(Keys.Space) == true)
            {
                TIEMPO += 1;

            }
            if (TIEMPO >= 40 && TIEMPO < 60)
            {

                cambiarI = 4;
                ssY -= 200;
                contasaltos2 = 1;
                TIEMPO = 0;
            }
            if (contasaltos2 == 1)
            {

                if (contatiempo % 50 == 0)
                {

                    if (ssY > 10)
                    {

                        cambiarI += 1;//todrau

                        ssY += 200;
                        contasaltos2 = 0;

                        if (cambiarI > 7)
                        {
                            cambiarI = 5;
                        }
                    }
                }
            }
            if (TIEMPO > 3 && TIEMPO < 20)
            {
                cambiarI = 4;
                ssY -= 50;
                contasaltos = 1;
                TIEMPO = 0;

            }

            if (contasaltos == 1)
            {
                if (contatiempo % 50 == 0)
                {

                    if (ssY > 10)
                    {

                        cambiarI += 1;//todrau

                        ssY += 75;
                        contasaltos = 0;

                        if (cambiarI > 7)
                        {
                            cambiarI = 5;
                        }
                    }
                }
            }


        }
        public new void Draw(GameTime gameTime, SpriteBatch spriteBatch, Color _COLOR)
        {

            spriteBatch.Draw(imagenes[cambiarI], rectangulo, _COLOR);

        }
    }
}

