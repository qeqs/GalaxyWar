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
            builder = new GalaxyBuilder();
            this.DoubleBuffered = true;
            this.comboBoxStrategy.Items.AddRange(new string[]
            {
                CivilizationStrategy.aggresive.ToString(),
                CivilizationStrategy.defensive.ToString(),
                CivilizationStrategy.passive.ToString()
            });

            timer1.Interval = 1;
            controller.OnRender += ((sender, args) => draw());

        }
        private GameController controller;
        private GalaxyBuilder builder;
        private volatile Bitmap field;
        private Point mouseLoc;
        private Graphics graphics;
        private Graphics fieldGraphics;

        private void init()
        {
            controller.Galaxy = new Galaxy();
            controller.Started = false;
            field = new Bitmap(this.Width, this.Height);
            fieldGraphics = Graphics.FromImage(field);
        }

        private void draw()
        {
            constructDraw(fieldGraphics);
            graphics.DrawImage(field as Image, 0, 0);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            init();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            changeControlsVisibility();
            controller.Started = true;
            controller.init();
            timer1.Start();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            GameController.Log("Button has been pressed");
            if (e.KeyCode == Keys.Pause || e.KeyCode == Keys.Escape)
            {
                changeControlsVisibility();
                controller.Started = !controller.Started;
                timer1.Stop();
            }

        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (controller.Started) return;
            mouseLoc = e.Location;
            draw();

        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (controller == null || controller.Started) return;
            changeGalaxy(e.Location);
            enableAllControlls();
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

            buttonStar.Enabled = true;
            buttonPlanet.Enabled = true;
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

        public void constructDraw(Graphics g)
        {
            if (controller == null && controller.Started) return;

            g.Clear(Color.Black);
            controller.draw(g);

            int x = this.Size.Width;
            int y = this.Size.Height;
            string locationString = mouseLoc.X + ":" + mouseLoc.Y;
            Size textSize = TextRenderer.MeasureText(locationString, Font, Size);

            g.DrawString(locationString, Font, Brushes.White, x - textSize.Width, 0 + textSize.Height);
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            controller.gameLoop(fieldGraphics);
            graphics.DrawImage(field as Image, 0, 0);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            graphics = CreateGraphics();
            init();
            draw();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {

        }

        enum CivilizationStrategy
        {
            aggresive, defensive, passive
        }
    }
}
