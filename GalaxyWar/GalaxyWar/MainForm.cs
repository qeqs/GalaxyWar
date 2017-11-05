using GalaxyWar.controllers;
using GalaxyWar.logic;
using GalaxyWar.logic.impls;
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
            this.comboBoxStrategy.Items.AddRange(new string[]
            {
                CivilizationStrategy.aggresive.ToString(),
                CivilizationStrategy.defensive.ToString(),
                CivilizationStrategy.passive.ToString()
            });
        }

        private GameController controller;
        private GalaxyBuilder builder;
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
            enableAllControlls();
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            enableAllControlls();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            if (field == null || controller ==null || !controller.Started) return;
            e.Graphics.Clear(Color.Black);
            e.Graphics.DrawImage(field, 0, 0);
        }


        private void buttonPlanet_Click(object sender, EventArgs e)
        {
            buttonPlanet.Enabled = !buttonPlanet.Enabled;

        }

        private void buttonStar_Click(object sender, EventArgs e)
        {
            buttonStar.Enabled = !buttonStar.Enabled;
        }
        

        private void enableAllControlls()
        {
            if (buttonStar.Enabled && buttonPlanet.Enabled) return;

            buttonStar.Enabled = !buttonStar.Enabled;
            buttonPlanet.Enabled = !buttonPlanet.Enabled;
        }

        private void changeControlsVisibility()
        {
            panelObjectsCreation.Visible = !panelObjectsCreation.Visible;
            groupBoxInfo.Visible = !groupBoxInfo.Visible;
            buttonExit.Visible = !buttonExit.Visible;
            buttonNew.Visible = !buttonNew.Visible;
            buttonStart.Visible = !buttonStart.Visible;
        }
        
        private void changeGalaxy(PointF location)
        {
            if (!buttonStar.Enabled)
            {
                builder.buildStar(controller.Galaxy, location);
            }
            if (!buttonPlanet.Enabled)
            {
                Civilization civ = null;
                if (checkBoxCivilization.Checked)
                    civ = builder.buildCivilization(
                             controller.Galaxy,
                             chooseCivilizationStrategy((CivilizationStrategy)Enum.Parse(typeof(CivilizationStrategy),
                             comboBoxStrategy.SelectedText
                             )));

                if (checkBoxRandom.Checked)
                {
                    builder.buildPlanet(controller.Galaxy, location, civ);
                }
                else
                {
                    builder.buildPlanet(controller.Galaxy, location,numericMetal.Value, numericCarbon.Value, numericOrganic.Value, civ);
                }

            }

        }

        private CivilizationBehavior chooseCivilizationStrategy(CivilizationStrategy strategy)
        {
            switch (strategy)
            {
                case CivilizationStrategy.aggresive:
                    return new AggresiveCivilizationBehavior();
                case CivilizationStrategy.defensive:
                    return new DefenceCivilizationBehavior();
                case CivilizationStrategy.passive:
                    return new PassiveCivilizationBehavior();
                default: return null;
            }


        }



        enum CivilizationStrategy
        {
            aggresive, defensive, passive
        }
        
    }
}
