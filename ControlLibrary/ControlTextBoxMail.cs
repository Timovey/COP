using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace ControlLibrary
{
	public partial class ControlTextBoxMail : UserControl
	{
        /// <summary>
        /// свойство для установки значения шаблона
        /// </summary>
        public string Template { set { template = value; } get { return template; } }
        //private string template = @"^[0-9]+$";
        private string template = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

        private string example = "8 888 888";

        /// <summary>
        /// свойство установки и получения значения в TextBox
        /// </summary>
        public string Value
        {
            get
            {
                if (IsRegex(TextBox.Text)) { return TextBox.Text; }
                else
                { return null; }
            }
            set { TextBox.Text = value; }
        }
        public ControlTextBoxMail()
        {
            InitializeComponent();

        }
        /// <summary>
        /// метод установки примера 
        /// </summary>
        public void SetExample(string value)
        {
            example = value;
        }

        private bool IsRegex(string number)
        {
            return Regex.IsMatch(number, template);
        }

		private void labelExample_MouseHover(object sender, EventArgs e)
		{
            labelExample.Text = example;
		}

	}
}
