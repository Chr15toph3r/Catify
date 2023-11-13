using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using NAudio.Wave;
using System.IO;
namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
    private bool mouseDown;
    private Point lastLocation;
    private Point originalLocation;
    private Size originalSize;
    private bool isMaximized = false;
    //iconos que cambian de tamaño al pasar el mouse
    private Size originalSizeIcono; //boto controlador de canciones...
    private Point originalLocationIcono;
    private Size originalSizeIcono1; //boton controlador de playlists...
    private Point originalLocationIcono1;
    private Size originalSizeIcono2;    //boton de play
    private Point originalLocationIcono2;
    private bool isPlaying = false;
    //botones atras y siguiente
    
        
    //funcionalidad NAudio    
    private WaveOutEvent outputDevice;
    private AudioFileReader audioFile;

    
        
        //bordes redondeados
    [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect,     // x-coordinate of upper-left corner
        int nTopRect,      // y-coordinate of upper-left corner
        int nRightRect,    // x-coordinate of lower-right corner
        int nBottomRect,   // y-coordinate of lower-right corner
        int nWidthEllipse, // width of ellipse
        int nHeightEllipse // height of ellipse
    );
        //form principal
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; //desactivador de opciones de ventana
            this.Ventana.MouseDown += new MouseEventHandler(Ventana_MouseDown);
            this.Ventana.MouseMove += new MouseEventHandler(Ventana_MouseMove);
            this.Ventana.MouseUp += new MouseEventHandler(Ventana_MouseUp);
            MinimizarVentana.Click += new EventHandler(miBotonMinimizar_Click);
            //iconos que cambian de tamaño
            originalSizeIcono = CancionIcono.Size;
            originalLocationIcono = CancionIcono.Location;
            originalSizeIcono1 = PlaylistIcono.Size;
            originalLocationIcono1 = PlaylistIcono.Location;
            originalSizeIcono2 = playbutton.Size;
            originalLocationIcono2 = playbutton.Location;


            this.Load += (sender, e) =>
            {
                this.FormBorderStyle = FormBorderStyle.None; // Remueve el borde estándar del formulario
                IntPtr ptr = CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20); // 20 es el grado de curvatura
                this.Region = Region.FromHrgn(ptr);
            };

            // Asegúrate de que la región se actualice si el formulario cambia de tamaño
            this.SizeChanged += (sender, e) =>
            {
                IntPtr ptr = CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20);
                this.Region = Region.FromHrgn(ptr);
            };

        }
        //barra opciones de ventana personalizado
        private void Ventana_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDown = true;
                lastLocation = e.Location;
            }
        }

        private void Ventana_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, 
                    (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }



        private void Ventana_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void miBotonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void CancionIcono_MouseEnter(object sender, EventArgs e)
        {
            Size newSize = new Size((int)(originalSizeIcono.Width * 1.1), (int)(originalSizeIcono.Height * 1.1));
            Point newLocation = new Point(originalLocationIcono.X - (int)(originalSizeIcono.Width * 0.05), originalLocationIcono.Y - (int)(originalSizeIcono.Height * 0.05));

            // Aplica el nuevo tamaño y posición
            CancionIcono.Size = newSize;
            CancionIcono.Location = newLocation;
        }

        private void CancionIcono_MouseLeave(object sender, EventArgs e)
        {
            CancionIcono.Size = originalSizeIcono;
            CancionIcono.Location = originalLocationIcono;
        }

        private void PlaylistIcono_MouseEnter(object sender, EventArgs e)
        {
                PlaylistIcono.Size = new Size((int)(originalSizeIcono1.Width * 1.1), (int)(originalSizeIcono1.Height * 1.1));
                PlaylistIcono.Location = new Point(originalLocationIcono1.X - (int)(originalSizeIcono1.Width * 0.05), originalLocationIcono1.Y - (int)(originalSizeIcono1.Height * 0.05));
        }

        private void PlaylistIcono_MouseLeave(object sender, EventArgs e)
        {
            PlaylistIcono.Size = originalSizeIcono1;
            PlaylistIcono.Location = originalLocationIcono1;
        }

        private void playbutton_MouseEnter(object sender, EventArgs e)
        {
            playbutton.Size = new Size((int)(originalSizeIcono2.Width * 1.1), (int)(originalSizeIcono2.Height * 1.1));
            playbutton.Location = new Point(originalLocationIcono2.X - (int)(originalSizeIcono2.Width * 0.05), originalLocationIcono2.Y - (int)(originalSizeIcono2.Height * 0.05));
        }

        private void playbutton_MouseLeave(object sender, EventArgs e)
        {
            playbutton.Size = originalSizeIcono2;
            playbutton.Location = originalLocationIcono2;
        }

        private void playbutton_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                // Cambia a la imagen "play"
                playbutton.BackgroundImage = Properties.Resources.playbutton_on;
            }
            else
            {
                // Cambia a la imagen "pause"
                playbutton.BackgroundImage = Properties.Resources.playbutton_off;
            }
            isPlaying = !isPlaying; // Invierte el estado
        }

        private void PlaySiguiente_MouseEnter(object sender, EventArgs e)
        {

        }

        private void PlaySiguiente_MouseLeave(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CancionIcono_Click(object sender, EventArgs e)
        {
            
        }
        //




    }
}
