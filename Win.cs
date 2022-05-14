using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace AtraparBooFinal
{
    class Win : SPRITE
    {
        Game1 ruta;
        private SpriteFont letra;
        public int ATRAPADAS = 0;
        public int nivel = 1;
        public Win(Game1 Laruta) : base(new Point(10, 10), new Point(1400, 600))//LLAMDA DEL CONTRUCTOR ANTERIOR
        {
            this.ruta = Laruta;
            this.imagen1 = "ganoEljuego";

            this.LoadContent();
        }
        public void LoadContent()
        {
            imagen = this.ruta.Content.Load<Texture2D>(imagen1);
            letra = this.ruta.Content.Load<SpriteFont>("File");
        }

        public new void Draw(GameTime gameTime, SpriteBatch spriteBatch, Color _COLOR)
        {

            spriteBatch.DrawString(letra, " Boomeras atrapados " + ATRAPADAS, new Vector2(500, 50), Color.Purple);
            spriteBatch.DrawString(letra, " Nivel " + nivel, new Vector2(1100, 10), Color.Orange);

            if (ATRAPADAS == 5)
            {
                spriteBatch.Draw(imagen, rectangulo, _COLOR);
            }


        }
    }
}
