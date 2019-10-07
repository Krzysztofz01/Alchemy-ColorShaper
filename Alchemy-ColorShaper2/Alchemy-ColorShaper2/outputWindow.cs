using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alchemy_ColorShaper2
{
    public partial class outputWindow : Form
    {
        public outputWindow(string imageLocation)
        {
            InitializeComponent();

            pictureBox.ImageLocation = imageLocation;

            panel1.BackColor = Processing.hextoColor(Output.outputColors[0]);
            panel2.BackColor = Processing.hextoColor(Output.outputColors[1]);
            panel3.BackColor = Processing.hextoColor(Output.outputColors[2]);
            panel4.BackColor = Processing.hextoColor(Output.outputColors[3]);
            panel5.BackColor = Processing.hextoColor(Output.outputColors[4]);
            panel6.BackColor = Processing.hextoColor(Output.outputColors[5]);
            panel7.BackColor = Processing.hextoColor(Output.outputColors[6]);
        }
    }
}
