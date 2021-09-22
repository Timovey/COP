using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace ControlLibrary
{
	public partial class UserControl3 : UserControl
	{
        private string Field1 = "";
        private string Field2 = "";
        private bool isField = false;
        private string template = "";

        // добавление шабьлона
        public void AddTemplate(string templateFromOutside, char begin, char end)
        {
            string[] splitedStrings = templateFromOutside.Split(begin, end);
            if (splitedStrings.Length < 3)
            {
                return;
            }
            Field1 = splitedStrings[1];
            Field2 = splitedStrings[3];
            isField = true;
            template = templateFromOutside;
           
        }
        public UserControl3()
        {
            InitializeComponent();
        }
        // полученние и установка индекса
        public int GetIndex
		{
            get
            {
                return ListBox.SelectedIndex;
            }
            set
			{
                if(value < ListBox.Items.Count)
				{
                    ListBox.SelectedIndex = value;
				}
			}
		}
        // получение элемента
        public object GetItem ()
		{
            if(ListBox.SelectedIndex != -1)
			{
                return ListBox.SelectedItem;
			}
            return null;
		}
        public void AddToList<T>(List<T> obj)
        {
            if (!isField && !Field1.Equals("") && !Field2.Equals(""))
            {
                throw new Exception("Поля не заполнены");
            }
            string o1 = "";
            string o2 = "";
 
            if(obj.Count == 0)
            {
                return;
            }

            Type type = obj[0].GetType();
            PropertyInfo[] props = type.GetProperties();
            FieldInfo[] fields = type.GetFields();

            foreach (T o in obj)
            {


                foreach (var p in props)
                {
                    
                    if (p.Name.Equals(Field1))
                    {
                        o1 = p.GetValue(o).ToString();
                    }
                    if (p.Name.Equals(Field2))
                    {
                        o2 = p.GetValue(o).ToString();
                    }
                }

                foreach (var f in fields)
                {
                    if (f.Name.Equals(Field1))
                    {
                        o1 = f.GetValue(o).ToString();
                    }
                    if (f.Name.Equals(Field2))
                    {
                        o2 = f.GetValue(o).ToString();
                    }
                }
                ListBox.Items.Add(template.Replace(Field1, o1).Replace(Field2, o2));
                
            }
             
            }
    }
}
