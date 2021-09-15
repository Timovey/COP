using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WinFormsLibrary
{
    public partial class UserControl2 : UserControl
    {
        public string Template { set { template = value; } }
        private string template = @"^\(\d{3}\) \d{3}-\d{4}$";

        public string Example { set { example = value; } }
        private string example = "*-***-**";

        public string Value { 
            get { 
                if (IsNumber(TextBox.Text)) { return TextBox.Text; }
                else
                { throw new Exception("Ошибочка"); }
            }
            set { TextBox.Text = value; }
        }
        public UserControl2()
        {
            InitializeComponent();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            ToolTip.SetToolTip(TextBox, example);
        }
        private bool IsNumber(string number)
        {
            return Regex.IsMatch(number, template);
        }
    }
}
