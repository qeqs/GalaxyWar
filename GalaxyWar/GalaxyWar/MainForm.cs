using GalaxyWar.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GalaxyWar
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            controller = new GameController(new Galaxy());
            this.DoubleBuffered = true;
        }

        private GameController controller;
        private volatile Bitmap field;
        private Thread thread;

        private void buttonNew_Click(object sender, EventArgs e)
        {
            controller.Galaxy = new Galaxy();
            field = new Bitmap(this.Width, this.Height);
            thread = new Thread(controller.loop);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            changeControlsVisibility();
            Dictionary<String, Object> param = new Dictionary<string, object>();
            param.Add("graphics", Graphics.FromImage(field as Image));
            param.Add("form", this);
            thread.Start(param);
            controller.Started = !controller.Started;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            try
            {
                if (thread != null)
                {
                    thread.Join();
                    thread.Interrupt();
                }
            }
            finally
            {
                this.Close();
            }

        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (thread == null) return;

            if(e.KeyCode == Keys.Pause || e.KeyCode == Keys.Escape)
            {
                changeControlsVisibility();
                controller.Started = !controller.Started;
            }
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            if (field == null || controller ==null || !controller.Started) return;

            e.Graphics.DrawImage(field, 0, 0);
        }

        private void changeControlsVisibility()
        {
            panelCivilizationCreation.Visible = !panelCivilizationCreation.Visible;
            panelObjectsCreation.Visible = !panelObjectsCreation.Visible;
            groupBoxInfo.Visible = !groupBoxInfo.Visible;
            buttonExit.Visible = !buttonExit.Visible;
            buttonNew.Visible = !buttonNew.Visible;
            buttonStart.Visible = !buttonStart.Visible;
        }

        private void buttonPlanet_Click(object sender, EventArgs e)
        {

        }

        private void buttonStar_Click(object sender, EventArgs e)
        {

        }

        private void buttonCivilization_Click(object sender, EventArgs e)
        {

        }
    }
}
