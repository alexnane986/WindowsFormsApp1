using System.Windows.Forms;

using System.Threading; //allows the use of Thread.Sleep() 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Simpson1 : Form
    {
        public Simpson1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void reactor2label_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {

            //change the colour of the state labels 

            reactor1StateLabel.BackColor = Color.Red;

            reactor2StateLabel.BackColor = Color.Red;



            //change the message in the output label 

            outputLabel.Text = "Meltdown Imminent";


        }
    }
}
