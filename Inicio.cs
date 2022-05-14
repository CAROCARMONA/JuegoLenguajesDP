using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
namespace AtraparBooFinal
{
    class Inicio : SPRITE
    {
        Game1 ruta;
        private int PLAY = 0;

        //llamados de objetos

        Dog dog;
        Men men;
        Men2 men2;
        public Win win;
        GameOver gameover;
        FondoNivel fondonivel;

        private int tiro = 0;
        public Inicio(Game1 Laruta, Point laposicion) : base(laposicion, new Point(1000, 500))//LLAMDA DEL CONTRUCTOR ANTERIOR
        {
            this.ruta = Laruta;
            this.imagen1 = "Bienvenida";
            Posicion = laposicion;
            //codigo de men

            dog = new Dog(Laruta, new Point(200, 300));
            win = new Win(Laruta);
            gameover = new GameOver(Laruta);
            fondonivel = new FondoNivel(Laruta);
            men = new Men(Laruta, new Point(1200, 300));
            men2 = new Men2(Laruta, new Point(1200, 300));
            this.LoadContent();
        }
        public void LoadContent()
        {
            imagen = this.ruta.Content.Load<Texture2D>(imagen1);

        }
        public void Update(GameTime gameTime)
        {
            var kState = Keyboard.GetState();
            if (kState.IsKeyDown(Keys.Enter))
            {
                rectangulo = new Rectangle(2000, 20, 1000, 500);
                PLAY = 1;

            }
            if (kState.IsKeyDown(Keys.X))
            {
                rectangulo = new Rectangle(200, 100, 1000, 500);
                PLAY = 0;
            }
            if (PLAY == 1)
            {
                fondonivel.Update(gameTime);
                dog.Update(gameTime);
                gameover.Update(gameTime);

                if (win.nivel == 1)
                {


                    men.Update(gameTime);
                    if (men.boomeran.rectangulo.Intersects(dog.rectangulo))
                    {
                        men.contaM = 1;
                        win.ATRAPADAS += 1;

                    }
                }
                if (win.nivel == 2)
                {

                    men2.Update(gameTime);
                    if (men2.ball.rectangulo.Intersects(dog.rectangulo))
                    {
                        men2.contaM = 1;
                        win.ATRAPADAS += 1;

                        tiro = 1;
                    }
                    if (tiro == 1)
                    {
                        men2.XXball = -100;
                        tiro = 0;
                    }
                }

                if (win.ATRAPADAS == 5 && win.nivel == 1)
                {

                    win.ATRAPADAS = 0;
                    gameover.TiempoLimite = 13500;
                    gameover.SEGUNDOS = 45;
                    fondonivel.cambiarI = 1
                        
                        ;
                    win.nivel = 2;

                }
            }
            if (PLAY == 0)
            {
                win.ATRAPADAS = 0;
                gameover.TiempoLimite = 18000;
                gameover.SEGUNDOS = 60;
                fondonivel.cambiarI = 0;
                win.nivel = 1;
                //aca muevo el nivel
            }
            if (win.ATRAPADAS == 5 && gameover.SEGUNDOS == 1)
            {
                rectangulo = new Rectangle(200, 100, 1000, 500);

                PLAY = 0;
            }
           

        }
        public new void Draw(GameTime gameTime, SpriteBatch spriteBatch, Color _COLOR)
        {

            base.Draw(gameTime, spriteBatch, Color.White);

            if (PLAY == 1)
            {
                fondonivel.Draw(gameTime, spriteBatch, Color.White);
                dog.Draw(gameTime, spriteBatch, Color.Beige);


                if (win.nivel == 1)
                {

                    men.Draw(gameTime, spriteBatch, Color.White);
                }
                if (win.nivel == 2)
                {

                    men2.Draw(gameTime, spriteBatch, Color.White);
                }

                win.Draw(gameTime, spriteBatch, Color.White);
                gameover.Draw(gameTime, spriteBatch, Color.White);
            }


        }

    }
}
