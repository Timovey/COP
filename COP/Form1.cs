using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
			userControl11.Selected += (object sender, EventArgs e) => { DoSomething(); };
        }
        private void DoSomething()
		{
            buttonColor.BackColor = Color.Red;
		}

		private void buttonFill_Click(object sender, EventArgs e)
		{
			userControl11.Fill("cscdsc", "dscdccc", "dcdcdcqwd", "dcdccd");
		}

		private void buttonDispose_Click(object sender, EventArgs e)
		{
			userControl11.DisposeComboBox();
		}

		private void buttonTake_Click(object sender, EventArgs e)
		{
			if(String.IsNullOrEmpty(textBoxSet.Text))
			{
				string d = userControl11.GetSelectedItem;
				textBoxSet.Text = d;
			}
			else
			{
				userControl11.GetSelectedItem = textBoxSet.Text;
			}
		}

		private void buttonExample_Click(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(textBoxExample.Text))
			{
				userControl21.SetExample(textBoxExample.Text);
			}
		}

		private void buttonTemplate_Click(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(textBoxTemplate.Text))
			{
				userControl21.Template = textBoxTemplate.Text;
			}
		}

		private void buttonMatch_Click(object sender, EventArgs e)
		{
			string res = userControl21.Value;
			if(res != null)
			{
				MessageBox.Show("Все ок", "Все ок", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Все плохо", "Все плохо", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void buttonFillListBox_Click(object sender, EventArgs e)
		{
			List<ClassFill> list = new List<ClassFill>();
			list.Add(new ClassFill { Id = 5, Name = "Tim" });
			list.Add(new ClassFill { Id = 6, Name = "Timcddc" });
			list.Add(new ClassFill { Id = 7, Name = "qwqwdxq" });
			userControl31.AddToList(list);
		}

		private void buttonTemList_Click(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(textBoxTemp.Text))
			{
				userControl31.AddTemplate(textBoxTemp.Text, '{', '}');
			}
		}

        private void buttonWord_Click(object sender, EventArgs e)
        {
			if(String.IsNullOrEmpty(textBoxTitle.Text))
            {
				MessageBox.Show("Заполните заголовок", "Ошибка", MessageBoxButtons.OK,
						  MessageBoxIcon.Error);

			}
			using (var dialog = new SaveFileDialog { Filter = "docx|*.docx" })
			{
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					try
					{
						List<string> list = new List<string>();
						list.Add("csdcdscsd");
						list.Add("111");
						list.Add("23424234csddcsdcs");
						component11.Report(fileName: dialog.FileName, title: textBoxTitle.Text, list);
						MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK,
						MessageBoxIcon.Information);
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
					   MessageBoxIcon.Error);
					}
				}
			}
			
		}

        private void buttonWord2_Click(object sender, EventArgs e)
        {
			if (String.IsNullOrEmpty(textBoxTitle.Text))
			{
				MessageBox.Show("Заполните заголовок", "Ошибка", MessageBoxButtons.OK,
						  MessageBoxIcon.Error);

			}
			using (var dialog = new SaveFileDialog { Filter = "docx|*.docx" })
			{
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					try
					{
						List<string> list = new List<string>();
						list.Add("csdcdscsd");
						list.Add("111");
						list.Add("23424234csddcsdcs");
						list.Add("xfcsdcscds");
						component11.Report(fileName: dialog.FileName, title: textBoxTitle.Text, list);
						MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK,
						MessageBoxIcon.Information);
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
					   MessageBoxIcon.Error);
					}
				}
			}
		}
    }
}
