﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biometrics_server
{
    public partial class frmConnect : Form
    {
        public frmConnect()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkEmpty() == true)
            {
                biometrics_server.Config.DB_Host = txtHost.Text;
                biometrics_server.Config.DB_Name = txtName.Text;
                biometrics_server.Config.DB_User = txtUser.Text;
                biometrics_server.Config.DB_Pass = txtPassword.Text;
                MessageBox.Show(this, "Database config successfully updated", "Information");
                biometrics_server.Config.saveSettings();
            }
            else
            {
                MessageBox.Show(this, "Please fill out all fields", "Information");
            }
            

        }

        private bool checkEmpty()
        {
            if (txtHost.Text == "")
            {
                return false;
            }
            else
            {
                if (txtName.Text == "")
                {
                    return false;
                }
                else
                {
                        if (txtUser.Text == "")
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    
                }
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmConnect_Load(object sender, EventArgs e)
        {
            txtHost.Text = Properties.Settings.Default.DB_Host;
            txtName.Text = Properties.Settings.Default.DB_Name;
            txtUser.Text = Properties.Settings.Default.DB_User;
            txtPassword.Text = Properties.Settings.Default.DB_Pass;
        }

    }
}
