﻿using BL;
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
    public partial class UpdateUser : Form
    {
        private User_Logic users_Logic = new User_Logic();
        public UpdateUser()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan age = DateTime.Now - dateTimePicker1.Value;
            users_Logic.Update(Login.id, textBox2.Text, textBox3.Text, dateTimePicker1.Value, age.Days / 365);
            Close();
        }
    }
}
