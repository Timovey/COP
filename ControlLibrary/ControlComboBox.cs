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
    public partial class ControlComboBox : UserControl
    {
		private event EventHandler _selected;
        /// <summary>
        /// свойство привязки сибытия
        /// </summary>
		public event EventHandler Selected
		{
			add { _selected += value; }
			remove { _selected -= value; }
		}

        /// <summary>
        /// Свойство получения выбранного элемента списка или установка значения 
        /// </summary>
        public string GetSelectedItem
        {
            get
            {
                if (ComboBox.SelectedIndex == -1) { return null; }
                else { return ComboBox.SelectedItem.ToString(); }
            }
            set
            {
                if (value != null)
                {
                    if (ComboBox.Items.Contains(value))
                    {
                        ComboBox.SelectedItem = value;
                    }
                }

            }
        }

        /// <summary>
        /// метод заполнения списка строковыми значениями
        /// </summary>
        public void Fill(params string[] strings)
		{
            foreach (string s in strings) {
                ComboBox.Items.Add(s);
            }
		}
        public ControlComboBox()
        {
            InitializeComponent();

        }
        /// <summary>
        /// метод очистки значений списка
        /// </summary>
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
