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
    public partial class Sign_in : Form
    {
        private User_Logic users_Logic = new User_Logic();
        private Achievement_Logic achievement_Logic = new Achievement_Logic();
        public Sign_in()
        {
            InitializeComponent();
            dataGridView1.DataSource = users_Logic.GetAllInfoUser(Login.id);
            dataGridView2.DataSource = achievement_Logic.YourAchievement(Login.id);
            dataGridView3.DataSource = achievement_Logic.GetAll();
            comboBox1.DataSource = users_Logic.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Achievement f = new Add_Achievement();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UpdateUser f = new UpdateUser();
            f.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = users_Logic.GetAllInfoUser(Login.id);
            dataGridView2.DataSource = achievement_Logic.YourAchievement(Login.id);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            users_Logic.Remove(Login.id);
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = achievement_Logic.GetAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteAchievement f = new DeleteAchievement();
            f.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateAchievement f = new UpdateAchievement();
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FindAchievement f = new FindAchievement();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddUserAchievement f = new AddUserAchievement();
            f.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            DeleteUserAchievement f = new DeleteUserAchievement();
            f.Show();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            User a = (User)comboBox1.SelectedItem;
            dataGridView4.DataSource = users_Logic.GetInfoUser(a.ID);
            dataGridView5.DataSource = achievement_Logic.YourAchievement(a.ID);
        }
    }
}
