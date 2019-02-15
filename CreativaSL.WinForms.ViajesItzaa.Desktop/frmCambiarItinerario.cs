using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CreativaSL.Dll.ViajesItzaa.Global;
using CreativaSL.Dll.ViajesItzaa.Negocio;
using CreativaSL.LibControls.WinForms;
using System.IO;

namespace CreativaSL.WinForms.ViajesItzaa.Desktop
{
    public partial class frmCambiarItinerario : Form_Creativa
    {
        int j = 1;

        public frmCambiarItinerario()
        {
            InitializeComponent();
        }

        private void frmCambiarItinerario_Load(object sender, EventArgs e)
        {
            try
            {
                this.LlenarListView();
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "frmCambiarItinerario_Load");
            }
        }

        private void LlenarListView()
        {
            try
            {
                Estado estado = new Estado();
                estado.Conexion = Comun.Conexion;
                estado.Opcion = 1;
                estado.IDPais = 143;
                Estado_Negocio en = new Estado_Negocio();
                int Posx = 0, Posy = 0, WidthTextBox = 0, WidthPB = 0, heigthtextBox = 0, HeightPB = 0, Espacio = 10;
                Posx = 50;
                Posy = 250;
                WidthPB = 20;
                HeightPB = 20;
                WidthTextBox = 100;
                heigthtextBox = 20;
                int i = 0;
                foreach (Estado item in en.LlenarComboEstados(estado))
                {
                    if (i < 5)
                    {
                        i++;                    
                    }
                    else
                    {
                        Posx = Posx + WidthPB + Espacio + WidthTextBox + Espacio;
                        Posy = 250;
                        i = 1;
                    }
                    this.AgregarTextBox(item, Posx, Posy, WidthTextBox, WidthPB, heigthtextBox, HeightPB, Espacio);
                    Posy = Posy + heigthtextBox + Espacio;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void AgregarTextBox(Estado estado, int Posx, int Posy, int anchoTB, int anchoPB, int altoTB, int altoPB, int separacion )
        {
            try
            {
                TextBox textBox = new TextBox();
                textBox.Tag = estado.IDEstado;
                textBox.Name = "txt" + estado.IDEstado.ToString();
                textBox.Click += new System.EventHandler(this.textBox1_Click);
                textBox.Size = new Size(anchoTB, altoTB);
                textBox.Text = estado.NombreEstado;
                textBox.Location = new Point(Posx + anchoPB + separacion, Posy);
                PictureBox pb = new PictureBox();
                pb.Name = "tb" + estado.IDEstado.ToString();
                pb.Size = new Size(anchoPB, altoPB);                
                pb.Location = new Point(Posx, Posy);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                this.panelTextBox.Controls.Add(textBox);
                this.panelTextBox.Controls.Add(pb);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        private void textBox1_Click(object sender, EventArgs e)
        {
            try
            {
                TextBox aux = (TextBox)sender;
                PictureBox pb = (PictureBox)this.Controls.Find("tb" + aux.Tag.ToString(), true)[0];
                if (pb.Image == null)
                {
                    pb.Image = this.getImage(j);
                    pb.Tag = j;
                    j++;
                }
                else
                {
                    if (Convert.ToInt32(pb.Tag) == (j - 1))
                    {
                        pb.Image = null;
                        j--;
                    }
                }
            }
            catch (Exception ex)
            {
                Comun_Negocio.AddExcFileTxt(ex, "textBox1_Click");
            }
        }

        private Image getImage(int i)
        {
            Image imagen;
            switch (i)
            {
                case 1: imagen = Image.FromFile(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\IcoNumbers\number01.png"));
                    break;
                case 2: imagen = Image.FromFile(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\IcoNumbers\Number02.ico"));
                    break;
                case 3: string url = Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\IcoNumbers\Number03.png");
                    imagen = Image.FromFile(url);
                    break;
                case 4: imagen = Image.FromFile(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\IcoNumbers\numbre04.png"));
                    break;
                default: imagen = Image.FromFile(Path.Combine(System.Windows.Forms.Application.StartupPath, @"Resources\IcoNumbers\number01.png"));
                    break;
            }
            return imagen;
        }
    }
}
