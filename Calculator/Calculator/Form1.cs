using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Andy : Form
    {
        private static Point olde_loc, default_loc;
        private static bool isfull = false;
        private static Size olde_size, default_size;
        private static int changement = 0;

        public Andy()
        {
            InitializeComponent();
        }

        private void moveImage(object sender)
        {
            Guna.UI2.WinForms.Guna2Button b = (Guna.UI2.WinForms.Guna2Button)sender;
            imageSlider.Location = new Point(b.Location.X + 50, b.Location.Y - 34);
            imageSlider.SendToBack();
        }
        private void btnCalculatorSimple_CheckedChanged(object sender, EventArgs e)
        {
            moveImage(sender);
        }

        public static void SetInit(Form form)
        {
            olde_loc = form.Location;
            olde_size = form.Size;

            default_loc = form.Location;
            default_size = form.Size;
        }

        public static void DoFullscreen(Form form)
        {
            if (isfull == false) // app not fullscreen; then fullscreen it !
            {
                olde_loc = new Point(form.Location.X, form.Location.Y);
                olde_size = new Size(form.Size.Width, form.Size.Height);
                Fullscreen(form);
                isfull = true;
            }
            else // app is currently fullscreen; then make it normal
            {
                form.Location = olde_loc;
                form.Size = olde_size;
                isfull = false;
            }
        }





        private static void Fullscreen(Form form)
        {
            if (form.WindowState == FormWindowState.Maximized)
            {
                changement = 1;
                form.WindowState = FormWindowState.Normal;
            }
            else if (form.WindowState == FormWindowState.Normal)
            {
                changement = 0;
                form.WindowState = FormWindowState.Maximized;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            Minimize(this);
        }

        private static void Minimize(Form form)
        {
            if (form.WindowState == FormWindowState.Minimized)
                form.WindowState = FormWindowState.Normal;
            else if (form.WindowState == FormWindowState.Normal)
                form.WindowState = FormWindowState.Minimized;
            else
                form.WindowState = FormWindowState.Minimized;

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelheurMinute.Text = DateTime.Now.ToString("HH:mm");
            labelSeconde.Text = DateTime.Now.ToString("ss");
            labelMoisDateAnne.Text = DateTime.Now.ToString("MMM dd yyyy");
            labelJour.Text = DateTime.Now.ToString("dddd");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private static void Maximized(Form form)
        {
            int x = SystemInformation.WorkingArea.Width;
            int y = SystemInformation.WorkingArea.Height;
            form.WindowState = FormWindowState.Normal;
            form.Location = new Point(0, 0);
            form.Size = new Size(x, y);
        }

        private static int Changement
        {
            get { return changement; }
            set { changement = value; }
        }
    }
}
