using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class FindAchievement : Form
    {
        private Achievement_Logic achievement_Logic = new Achievement_Logic();
        public FindAchievement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           dataGridView1.DataSource = achievement_Logic.Find(textBox1.Text);

        }
    }
}
