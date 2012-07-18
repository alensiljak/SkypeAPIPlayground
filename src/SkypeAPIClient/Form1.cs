using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SkypeAPIClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sanitize_input();
                send_message(UsernameTextBox.Text, MessageTextBox.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                // throw;
            }
        }

        private void sanitize_input()
        {
            if (string.IsNullOrWhiteSpace(UsernameTextBox.Text))
            {
                throw new ArgumentException("Username can not be blank.");
            }
            UsernameTextBox.Text = UsernameTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(MessageTextBox.Text))
            {
                throw new ArgumentException("Message should not be blank.");
            }
            MessageTextBox.Text = MessageTextBox.Text.Trim();
        }

        private void send_message(string username, string message)
        {
            
        }
    }
}
