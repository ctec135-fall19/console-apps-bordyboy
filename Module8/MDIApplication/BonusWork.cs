using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIApplication
{
    public partial class BonusWork : Form
    {
        public BonusWork()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if statement to check for a yes dialog result then runs the code inside which changes a label text(that
            //I inentionally left empty) to the word Saved.
            if (DialogResult.Equals(DialogResult.Yes))
            {
                AMClassLabel.Text = "Saved!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if statement to check for a yes dialog result then runs the code inside which changes a label text(that
            //I inentionally left empty) to the word Saved.
            if (DialogResult.Equals(DialogResult.OK))
            {
                PMClassLabel.Text = "Saved!";
            }
        }
    }
}
