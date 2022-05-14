using Microsoft.Xna.Framework;

using Microsoft.Xna.Framework.Graphics;

namespace AtraparBooFinal
{
    class GameOver : SPRITE
    {
        Game1 ruta;

        private SpriteFont letra;
        public int SEGUNDOS = 60;
        public int TiempoLimite = 18000;
        public GameOver(Game1 Laruta) : base(new Point(0, 0), new Point(1400, 700))//LLAMDA DEL CONTRUCTOR ANTERIOR
        {
            this.ruta = Laruta;
            this.imagen1 = "gameover";


            this.LoadContent();
        }
        public void LoadContent()
        {
            imagen = this.ruta.Content.Load<Texture2D>(imagen1);
            letra = this.ruta.Content.Load<SpriteFont>("File");
        }
        public void Update(GameTime gameTime)
        {
            TiempoLimite -= 1;
            if (TiempoLimite % 30 == 0 && TiempoLimite > 0)
            {
                SEGUNDOS -= 1;
            }
        }
        public new void Draw(GameTime gameTime, SpriteBatch spriteBatch, Color _COLOR)
        {

            spriteBatch.DrawString(letra, " tiempo LIMITE 60 segundos.  Tiempo que llevas: " + SEGUNDOS + " segundos", new Vector2(150, 10), Color.Red);


            if (SEGUNDOS <= 0)
            {
                spriteBatch.Draw(imagen, rectangulo, _COLOR);
            }


        }
    }
}
