using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class PantallaPrincipal : Form
    {
        Cuerpo Cabeza;
        Graphics GrpAreaDeJuego;
        int DireccionX = 0, DireccionY = 0;
        int IntCuadro = 10;
        Boolean EjeX = true, EjeY = true;  //Controla el moviento de la serpiente (para que no retorne en la misma direccion)
        public PantallaPrincipal()
        {
            InitializeComponent();
            Cabeza = new Cuerpo(10, 10);
            GrpAreaDeJuego = AreaDeJuego.CreateGraphics(); //Area donde se movera la serpiente.
        }

        //Funcion para que la serpiente se mueva
        public void Movimiento()
        {
            Cabeza.AplicarXY(Cabeza.ObtenerX() + DireccionX, Cabeza.ObtenerY() + DireccionY); //Mueve el cuerpo de 10 en 10.
        }
        private void bucle_Tick(object sender, EventArgs e)
        {
            GrpAreaDeJuego.Clear(Color.White); //Esto limpia la pantalla para ahcer el efecto de movimiento.
            Cabeza.Lienzo(GrpAreaDeJuego);
            Movimiento();
        }

        private void PantallaPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (EjeX)
            {
                if (e.KeyCode == Keys.Up)
                {
                    DireccionY = -IntCuadro;
                    DireccionX = 0; //Nos movemos solo en el eje Y
                    EjeX = false;
                    EjeY = true;
                }
                if (e.KeyCode == Keys.Down)
                {
                    DireccionY = IntCuadro;
                    DireccionX = 0; //Nos movemos solo en el eje Y
                    EjeX = false;
                    EjeY = true;
                }
            }
            if (EjeY)
            {
                if (e.KeyCode == Keys.Right)
                {
                    DireccionY = 0; //Nos movemos solo en el eje X
                    DireccionX = IntCuadro;
                    EjeX = true;
                    EjeY = false;
                }
                if (e.KeyCode == Keys.Left)
                {
                    DireccionY = 0; //Nos movemos solo en el eje X
                    DireccionX = -IntCuadro;
                    EjeX = true;
                    EjeY = false;
                }
            }
        }
    }
}
