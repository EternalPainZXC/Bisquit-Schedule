using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Бисквит_Расписание
{




    public partial class Form3 : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form3()
        {



            /*
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
            */

            //Size resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
            //Location = new Point(0, 0 + resolution.Height);
            //ClientSize = new Size(400, 75);

            Size resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;

            Location = new Point(resolution.Width - 300, 0);

            InitializeComponent();







        }

        /*
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //empty implementation
            e.Graphics.FillRectangle(Brushes.LimeGreen, e.ClipRectangle);
        }
        */

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {



        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Size resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;

            this.Visible = true;

            Location = new Point(resolution.Width - 300, 0);


        }


        private void button1_Click(object sender, EventArgs e)
        {

            panel1.Visible = false;

        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {

            Opacity = 1.0D;

        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                Form1 SettingsForm1 = new Form1();
                SettingsForm1.Show();
                //panel1.Visible = true;
                this.Close();

            }
            else
            {



                Form1 NewForm1 = new Form1();
                NewForm1.Show();
                this.Close();

            }
            this.Close();

        }
    }









}
