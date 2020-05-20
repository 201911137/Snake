using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Clase donde se disenia el cuerpo de la culebrita.

namespace Snake
{
    class Cuerpo : Objeto
    {
        public Cuerpo(int IntX, int IntY)
        {
            this.IntX = IntX;
            this.IntY = IntY;
        }
        //Lienzo donde dibujaremos la culebrita y la comida
        public void Lienzo(Graphics GrpAreaDeJuego)
        {
            GrpAreaDeJuego.FillRectangle(new SolidBrush(Color.Blue), this.IntX, this.IntY, this.IntAncho, this.IntAncho);
        }
        public void AplicarXY(int IntX, int IntY) //Funcion que permite mover el cuerpo de la culebra.
        {
            this.IntX = IntX;
            this.IntY = IntY;
        }

        //Obtiene los valores de "X" y "Y"
        public int ObtenerX()
        {
            return this.IntX;
        }
        public int ObtenerY()
        {
            return this.IntY;
        }
    }
}
