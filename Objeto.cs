using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Aqui estaran todas las propiedades comunes del juego.

namespace Snake
{
    class Objeto
    {
        protected int IntX, IntY, IntAncho;  //Tamanio de los cuadros, de la serpiente y de la comida.
        public Objeto()
        {
            IntAncho = 10; //Ancho de todos los objetos.
        }
        public Boolean Interseccion(Objeto ObjObjeto2)  //Funcion que permite detectar colisiones.
        {
            //Se calculan las diferencias de los distintos objetos para saber si estan colisionando
            int difx = Math.Abs(this.IntX - ObjObjeto2.IntX);
            int dify = Math.Abs(this.IntY - ObjObjeto2.IntY);
            if (difx >= 0 && difx < IntAncho && dify >= 0 && dify < IntAncho)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
