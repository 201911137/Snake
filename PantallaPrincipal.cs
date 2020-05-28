using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;


namespace Snake
{
    public partial class PantallaPrincipal : Form
    {
        Cuerpo Cabeza;
        Comida comida;
        Graphics GrpAreaDeJuego;
        int IntPuntuacion = 0;
        int DireccionX = 0, DireccionY = 0;
        int IntCuadro = 10;
        int IntLogros = 0;
        Boolean EjeX = true, EjeY = true;  //Controla el moviento de la serpiente (para que no retorne en la misma direccion)
        
        public PantallaPrincipal()
        {
            InitializeComponent();
            Cabeza = new Cuerpo(10, 10);
            comida = new Comida();
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
            comida.LienzoComida(GrpAreaDeJuego);
            Movimiento();
            ColisionCuerpo();
            ColisionarParedes();
            if (Cabeza.Interseccion(comida))
            {
                comida.MoverComida();
                Cabeza.Crecer();
                IntPuntuacion++;
                TxtPuntos.Text = IntPuntuacion.ToString();
                ProgressBar();
                SoundPlayer simpleSound = new SoundPlayer(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Multimedia\Sonidos\Coin.wav");
                simpleSound.Play();
            }
        }

        public void ProgressBar()
        {
            PbrPuntosLogro.Value = IntPuntuacion;
            if (PbrPuntosLogro.Value == PbrPuntosLogro.Maximum)
            {
                IntLogros++;
                PbrPuntosLogro.Maximum = PbrPuntosLogro.Maximum + PbrPuntosLogro.Maximum;
                LblLogrosAlcanzados.Text = IntLogros.ToString();
                LblProximoLogro.Text = PbrPuntosLogro.Maximum.ToString() + " puntos";
                PbrPuntosLogro.Value = IntPuntuacion;
            }
        }

        public void FinalizarJuego()
        {
            IntPuntuacion = 0;
            TxtPuntos.Text = "0";
            EjeX = true;
            EjeY = true;
            DireccionX = 0;
            DireccionY = 0;
            Cabeza = new Cuerpo(10, 10);
            comida = new Comida();
            PbrPuntosLogro.Maximum = 10;
            PbrPuntosLogro.Minimum = 0;
            PbrPuntosLogro.Value = 0;
            LblLogrosAlcanzados.Text = "0";
            LblProximoLogro.Text = "10 puntos";
            SoundPlayer simpleSound = new SoundPlayer(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Multimedia\Sonidos\GameOver.wav");
            simpleSound.Play();
            MessageBox.Show("Game Over!");
        }
        public void ColisionarParedes()
        {
            if (Cabeza.ObtenerX() < 0 || Cabeza.ObtenerX() > 770 || Cabeza.ObtenerY() < 0 || Cabeza.ObtenerY() > 380)
            {
                FinalizarJuego();
            }
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            PbrPuntosLogro.Maximum = 10;
            PbrPuntosLogro.Minimum = 0;
            PbrPuntosLogro.Step = 1;
            LblLogrosAlcanzados.Text = "0";
            LblProximoLogro.Text = "10 puntos";
            SoundPlayer simpleSound = new SoundPlayer(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Multimedia\Sonidos\Inicio.wav");
            simpleSound.Play();
        }

        public void ColisionCuerpo()
        {
            Cuerpo CuerpoTemporal;
            try
            {
                CuerpoTemporal = Cabeza.MuestraSiguiente().MuestraSiguiente();
            }catch (Exception err)
            {
                CuerpoTemporal = null;
            }
            while (CuerpoTemporal != null)
            {
                if (Cabeza.Interseccion(CuerpoTemporal))
                {
                    FinalizarJuego();
                }
                else
                {
                    CuerpoTemporal = CuerpoTemporal.MuestraSiguiente();
                }
            }
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
