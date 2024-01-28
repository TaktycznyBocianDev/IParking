﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IParkingClient
{
    public partial class CreateNewAccountForm : Form
    {

        CreateNewAccountView createNewAccountView;

        public CreateNewAccountForm()
        {
            InitializeComponent();

            createNewAccountView = new CreateNewAccountView();

            // Set up event handlers for text changed events
            EmailBox.TextChangedComplete += EmailBox_TextChangedComplete;
            PassBox.TextChangedComplete += PassBox_TextChangedComplete;
            SecPassBox.TextChangedComplete += SecPassBox_TextChangedComplete;

            // Set up password character and checkbox initial states
            PassBox.UseSystemPasswordChar = true;
            SecPassBox.UseSystemPasswordChar = true;
            ShowPass.Checked = false;
            ShowSecPass.Checked = false;

        }

        private void CreateNewAccountForm_Load(object sender, EventArgs e)
        {

        }

        // Validate UserName and Surname provided. Adjust their TextBoxes, if neccesary.

        private void UserNameBox_TextChanged(object sender, EventArgs e)
        {
           
            if (!createNewAccountView.NameAndSurnameValidation(UserNameBox.Text))
            {
                UserNameBox.Text = UserNameBox.Text.Substring(0, UserNameBox.Text.Length - 1);
                SetCursorAtTheWordEnd(UserNameBox);
                
            }
        }

        private void SurnameBox_TextChanged(object sender, EventArgs e)
        {
            if (!createNewAccountView.NameAndSurnameValidation(SurnameBox.Text))
            {
                SurnameBox.Text = SurnameBox.Text.Substring(0, SurnameBox.Text.Length - 1);
                SetCursorAtTheWordEnd(SurnameBox);
            }
        }


        //Email, Password and Second password Validation, perform after user stops changing text.

        private void EmailBox_TextChangedComplete(object? sender, EventArgs e)
        {
            if (EmailBox.Text != null || EmailBox.Text == "")
            {
                createNewAccountView.EmailValidation(EmailBox.Text);
            }

        }

        private void PassBox_TextChangedComplete(object? sender, EventArgs e)
        {
            if (PassBox.Text != null || PassBox.Text != "")
            {
                createNewAccountView.PasswordValidation(PassBox.Text);
            }
        }

        private void SecPassBox_TextChangedComplete(object? sender, EventArgs e)
        {
            if (SecPassBox.Text != null || SecPassBox.Text != "")
            {
                createNewAccountView.RepeatPasswordValid(PassBox.Text, SecPassBox.Text);
            }
        }
  
        private void ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            PassBox.UseSystemPasswordChar = !ShowPass.Checked;
        }

        private void ShowSecPass_CheckedChanged(object sender, EventArgs e)
        {
            SecPassBox.UseSystemPasswordChar = !ShowSecPass.Checked;
        }
    
        private void SetCursorAtTheWordEnd(TextBox textBox)
        {
            textBox.SelectionStart = UserNameBox.Text.Length;
            textBox.SelectionLength = 0;
        }

    }
}