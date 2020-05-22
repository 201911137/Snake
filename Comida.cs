using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Comida : Objeto
    {
        public Comida() 
        {
            this.IntX = CrearComida(78);
            this.IntY = CrearComida(39);
        }
        public void LienzoComida(Graphics GrpAreaDeJuego)
        {
            GrpAreaDeJuego.FillRectangle(new SolidBrush(Color.Red), this.IntX, this.IntY, this.IntAncho, this.IntAncho);
        }
        public void MoverComida() //Mueve la comida a un lugar random
        {
            this.IntX = CrearComida(78);
            this.IntY = CrearComida(39);
        }
        public int CrearComida(int n) //Crea la cominda en un lugar random
        {
            Random random = new Random();
            int NumRandom = random.Next(0, n) * 10;
            return NumRandom;
        }
    }
}
