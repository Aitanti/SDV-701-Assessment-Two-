﻿using System;

using System.Windows.Forms;

namespace camerashop
{
    public partial class frmQuestion : Form
    {
       
        
            private string _Answer;

            public frmQuestion(string prQuestion)
            {
                InitializeComponent();
                lblQuestion.Text = prQuestion;
                lblError.Text = "";
                txtAnswer.Focus();
                ShowDialog();
            }

            private void btnOK_Click(object prSender, EventArgs prE)
            {
                _Answer = txtAnswer.Text;
                DialogResult = DialogResult.OK;
            }

            private void btnCancel_Click(object prSender, EventArgs prE)
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }

            public string Answer
            {
                get { return _Answer; }
                //set { mAnswer = value; }
            }
        }
    }
