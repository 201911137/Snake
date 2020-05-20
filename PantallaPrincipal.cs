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
        public PantallaPrincipal()
        {
            InitializeComponent();
            Cabeza = new Cuerpo(10, 10);
            GrpAreaDeJuego = AreaDeJuego.CreateGraphics(); //Area donde se movera la serpiente.
        }
        private void bucle_Tick(object sender, EventArgs e)
        {
            GrpAreaDeJuego.Clear(Color.White); //Esto limpia la pantalla para ahcer el efecto de movimiento.
            Cabeza.Lienzo(GrpAreaDeJuego);
        }
    }
}
