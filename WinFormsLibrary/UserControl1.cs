using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.ComboBox;

namespace WinFormsLibrary
{
    public partial class UserControl1 : UserControl
    {
        public ObjectCollection GetItems {
            get { return ComboBox.Items; } 
        }
        public string GetSelectedItem
        {
            get { 
                if (ComboBox.SelectedIndex == -1) { return null; }
                else { return ComboBox.SelectedValue.ToString(); }
            }
            set {
                ComboBox.Items.Add(value); 
                ComboBox.SelectedValue = value; }
        }
        public UserControl1()
        {
            InitializeComponent();
        }
        public void DisposeComboBox()
        {
            ComboBox.Items.Clear();
        }
        
    }
}
