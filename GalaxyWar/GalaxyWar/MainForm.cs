using GalaxyWar.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        }

        private GameController controller;

        private void buttonNew_Click(object sender, EventArgs e)
        {
            controller.Galaxy = new Galaxy();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
           
        }
    }
}
