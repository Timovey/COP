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
	public partial class ControlListBoxRecords : UserControl
	{
        private string Field1 = "";
        private string Field2 = "";
        private bool isField = false;
        private string template = "";
        private char begin = ' ';
        private char end = ' ';
        /// <summary>
        /// метод добавление шаблона
        /// </summary>
        public void AddTemplate(string templateFromOutside, char begin, char end)
        {
            this.begin = begin;
            this.end = end;
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
        public ControlListBoxRecords()
        {
            InitializeComponent();
        }
        /// <summary>
        /// свойство полученния и установки индекса выбранного элемента
        /// </summary>
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
        /// <summary>
        /// свойство получения элемента
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public T GetItem<T>  () where T : new()
		{
            if(ListBox.SelectedIndex != -1)
			{
                string item =  ListBox.SelectedItem.ToString();
                T t = new T();


                string[] splitedStrings = item.Split(begin, end);
                if (splitedStrings.Length < 3)
                {
                    return new T();
                }
                Object field1 = splitedStrings[1];
                Object field2 = splitedStrings[3];
                Type type = t.GetType();
                PropertyInfo[] props = type.GetProperties();
                FieldInfo[] fields = type.GetFields();

                foreach (var p in props)
                {

                    if (p.Name.Equals(Field1))
                    {
                       Type propsType = type.GetProperty(Field1).PropertyType;
                        var replaceField1 = Convert.ChangeType(field1, propsType);
                        type.GetProperty(Field1).SetValue(t, replaceField1);
                    }
                    if (p.Name.Equals(Field2))
                    {
                        Type propsType = type.GetProperty(Field2).PropertyType;
                        var replaceField2 = Convert.ChangeType(field2, propsType);
                        type.GetProperty(Field2).SetValue(t, replaceField2);
                    }
                }

                foreach (var f in fields)
                {
                    if (f.Name.Equals(Field1))
                    {
                        Type propsType = type.GetField(Field1).FieldType;
                        var replaceField1 = Convert.ChangeType(field1, propsType);
                        type.GetField(Field1).SetValue(t, replaceField1);
                    }
                    if (f.Name.Equals(Field2))
                    {
                        Type propsType = type.GetField(Field2).FieldType;
                        var replaceField2 = Convert.ChangeType(field2, propsType);
                        type.GetField(Field2).SetValue(t, replaceField2);
                    }
                }
                return t;
            }
            return new T();
		}
        /// <summary>
        /// метод добавления элементов в список
        /// </summary>
        /// <typeparam name="T"></typeparam>
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
