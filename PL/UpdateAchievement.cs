using BL;
using Entities;
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
    public partial class UpdateAchievement : Form
    {
        private Achievement_Logic achievement_Logic = new Achievement_Logic();
        public UpdateAchievement()
        {
            InitializeComponent();
            comboBox1.DataSource = achievement_Logic.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Achievement c = (Achievement)comboBox1.SelectedItem;
            achievement_Logic.Update(c.ID, textBox1.Text);
            Close();
        }
    }
}
