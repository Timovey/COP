using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace WinFormsLibrary
{
    public partial class UserControl3 : UserControl
    {
        private string Field1 = "";
        private string Field2 = "";
        private bool isField = false;
        private string template = "";

        public void AddTemplate(string templateFromOutside, char begin, char end)
        {
            string[] splitedStrings = templateFromOutside.Split(begin, end);
            if(splitedStrings.Length <3)
            {
                return;
            }
            Field1 = splitedStrings[1];
            Field2 = splitedStrings[2];
            isField = true;
            for(int i = 0; i < splitedStrings.Length;i++)
            {
                
                if(i == 1)
                {
                    template += $"{1}";
                }
                if(i == 3)
                {
                    template += $"{2}";
                }
                template += splitedStrings[i];
            }
        }
        public UserControl3()
        {
            InitializeComponent();
        }

        public void AddToList<T>(ref T obj, int number, string Name)
        {
            if(!isField && !Field1.Equals("") && !Field2.Equals(""))
            {
                throw new Exception("Поля не заполнены");
            }
            string o1;
            string o2;
            Type type = obj.GetType();
            PropertyInfo[] props = type.GetProperties();
            FieldInfo[] fields = type.GetFields();
            foreach(var p in props)
            {
                if(p.Name.Equals(Field1))
                {
                    o1 = p.GetValue(null).ToString();
                }
                if (p.Name.Equals(Field2))
                {
                    o2 = p.GetValue(null).ToString();
                }
            }

            foreach (var f in fields)
            {
                if (f.Name.Equals(Field1))
                {
                    o1 = f.GetValue(null).ToString();
                }
                if (f.Name.Equals(Field2))
                {
                    o2 = f.GetValue(null).ToString();
                }
            }


        }
    }
}
