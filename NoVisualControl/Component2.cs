using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using NoVisualControl.HelperModels;

namespace NoVisualControl
{
    public partial class Component2 : Component
    {
        public Component2()
        {
            InitializeComponent();
        }

        public Component2(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void Report(string fileName, string title, List<WordTitleColumn> titleColumns, List<WordMergedTitleColumn> mergedTitleColumns, List<Object> data)
        {
            

        }
    }
}
