using System;
using System.Drawing;
using System.Windows.Forms;

namespace RagnarokPlayer
{
    public partial class Form1 : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);

                    if ((int)m.Result == HTCLIENT)
                        m.Result = (IntPtr)HTCAPTION;
                    return;
            }

            base.WndProc(ref m);
        }

        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Fuchsia;
            this.TransparencyKey = Color.Fuchsia;
            picAbout.MouseEnter += new EventHandler(button1_MouseEnter);
            picAbout.MouseLeave += new EventHandler(button1_MouseLeave);
            picMinimize.MouseEnter += new EventHandler(button2_MouseEnter);
            picMinimize.MouseLeave += new EventHandler(button2_MouseLeave);
            picMaximize.MouseEnter += new EventHandler(button3_MouseEnter);
            picMaximize.MouseLeave += new EventHandler(button3_MouseLeave);
        }

        // Botão 1
        void button1_MouseLeave(object sender, EventArgs e)
        {
            this.picAbout.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.sys_base_off));

        }


        void button1_MouseEnter(object sender, EventArgs e)
        {
            this.picAbout.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.sys_base_on));

        }

        // Botão 2
        void button2_MouseLeave(object sender, EventArgs e)
        {
            this.picMinimize.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.sys_mini_a));

        }


        void button2_MouseEnter(object sender, EventArgs e)
        {
            this.picMinimize.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.sys_mini_b));

        }

        // Botão 3
        void button3_MouseLeave(object sender, EventArgs e)
        {
            this.picMaximize.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.sys_close_a));

        }


        void button3_MouseEnter(object sender, EventArgs e)
        {
            this.picMaximize.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.sys_close_b));

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ragnarok Music Player é uma criação de Keven Castilho\nTodas as musicas utilizadas fazem parte da BGM do jogo\nRagnarok Online.", "Sobre", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
