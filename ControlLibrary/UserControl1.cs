using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.ComboBox;

namespace ControlLibrary
{
    public partial class UserControl1 : UserControl
    {
		private event EventHandler _selected;

		public event EventHandler Selected
		{
			add { _selected += value; }
			remove { _selected -= value; }
		}
        

        //Свойство получения выбранного элемента списка или установка значения 
		public string GetSelectedItem
        {
            get
            {
                if (ComboBox.SelectedIndex == -1) { return null; }
                else { return ComboBox.SelectedItem.ToString(); }
            }
            set
            {
                if(value != null) { 
                    ComboBox.Items.Add(value);
                    ComboBox.SelectedItem = value;
                }
            }
        }
        // метод заполнения списка строковыми значениями
        public void Fill(params string[] strings)
		{
            foreach (string s in strings) {
                ComboBox.Items.Add(s);
            }
		}
        public UserControl1()
        {
            InitializeComponent();

        }
        // метод очистки значений списка
        public void DisposeComboBox()
        {
            ComboBox.Items.Clear();
            ComboBox.SelectedIndex = -1;
        }

		private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
            _selected?.Invoke(sender, e);
		}
	}
}
