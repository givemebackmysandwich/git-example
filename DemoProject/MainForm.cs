using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoProject
{
    public partial class MainForm : Form
    {
        
        private int count = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnClickThis_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "Hello World!";
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void changeColorButton_Click(object sender, EventArgs e)
        {
            changeColorButton.BackColor = Color.SkyBlue;
        }
        
        private void CounterButton_Click(object sender, EventArgs e) {
            count++;
            countResult.Text = Convert.ToString(count);
        }
    }
}
