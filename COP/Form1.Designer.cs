
namespace COP
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonFill = new System.Windows.Forms.Button();
            this.buttonDispose = new System.Windows.Forms.Button();
            this.buttonTake = new System.Windows.Forms.Button();
            this.textBoxSet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxExample = new System.Windows.Forms.TextBox();
            this.textBoxTemplate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonExample = new System.Windows.Forms.Button();
            this.buttonTemplate = new System.Windows.Forms.Button();
            this.buttonMatch = new System.Windows.Forms.Button();
            this.buttonFillListBox = new System.Windows.Forms.Button();
            this.buttonTemList = new System.Windows.Forms.Button();
            this.textBoxTemp = new System.Windows.Forms.TextBox();
            this.buttonWord1 = new System.Windows.Forms.Button();
            this.userControl31 = new ControlLibrary.UserControl3();
            this.userControl21 = new ControlLibrary.UserControl2();
            this.userControl11 = new ControlLibrary.UserControl1();
            this.component11 = new NoVisualControl.Component1(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.buttonWord2 = new System.Windows.Forms.Button();
            this.component21 = new NoVisualControl.Component2(this.components);
            this.SuspendLayout();
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(27, 52);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(175, 33);
            this.buttonColor.TabIndex = 1;
            this.buttonColor.Text = "Цвет";
            this.buttonColor.UseVisualStyleBackColor = true;
            // 
            // buttonFill
            // 
            this.buttonFill.Location = new System.Drawing.Point(27, 91);
            this.buttonFill.Name = "buttonFill";
            this.buttonFill.Size = new System.Drawing.Size(174, 38);
            this.buttonFill.TabIndex = 2;
            this.buttonFill.Text = "Заполнить";
            this.buttonFill.UseVisualStyleBackColor = true;
            this.buttonFill.Click += new System.EventHandler(this.buttonFill_Click);
            // 
            // buttonDispose
            // 
            this.buttonDispose.Location = new System.Drawing.Point(29, 135);
            this.buttonDispose.Name = "buttonDispose";
            this.buttonDispose.Size = new System.Drawing.Size(173, 38);
            this.buttonDispose.TabIndex = 3;
            this.buttonDispose.Text = "Очистить";
            this.buttonDispose.UseVisualStyleBackColor = true;
            this.buttonDispose.Click += new System.EventHandler(this.buttonDispose_Click);
            // 
            // buttonTake
            // 
            this.buttonTake.Location = new System.Drawing.Point(26, 226);
            this.buttonTake.Name = "buttonTake";
            this.buttonTake.Size = new System.Drawing.Size(175, 30);
            this.buttonTake.TabIndex = 4;
            this.buttonTake.Text = "Получить/Установить";
            this.buttonTake.UseVisualStyleBackColor = true;
            this.buttonTake.Click += new System.EventHandler(this.buttonTake_Click);
            // 
            // textBoxSet
            // 
            this.textBoxSet.Location = new System.Drawing.Point(29, 190);
            this.textBoxSet.Name = "textBoxSet";
            this.textBoxSet.Size = new System.Drawing.Size(173, 20);
            this.textBoxSet.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Шаблон";
            // 
            // textBoxExample
            // 
            this.textBoxExample.Location = new System.Drawing.Point(411, 115);
            this.textBoxExample.Name = "textBoxExample";
            this.textBoxExample.Size = new System.Drawing.Size(160, 20);
            this.textBoxExample.TabIndex = 8;
            // 
            // textBoxTemplate
            // 
            this.textBoxTemplate.Location = new System.Drawing.Point(412, 160);
            this.textBoxTemplate.Name = "textBoxTemplate";
            this.textBoxTemplate.Size = new System.Drawing.Size(158, 20);
            this.textBoxTemplate.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "приvер";
            // 
            // buttonExample
            // 
            this.buttonExample.Location = new System.Drawing.Point(594, 112);
            this.buttonExample.Name = "buttonExample";
            this.buttonExample.Size = new System.Drawing.Size(137, 22);
            this.buttonExample.TabIndex = 11;
            this.buttonExample.Text = "Передать ";
            this.buttonExample.UseVisualStyleBackColor = true;
            this.buttonExample.Click += new System.EventHandler(this.buttonExample_Click);
            // 
            // buttonTemplate
            // 
            this.buttonTemplate.Location = new System.Drawing.Point(594, 154);
            this.buttonTemplate.Name = "buttonTemplate";
            this.buttonTemplate.Size = new System.Drawing.Size(141, 25);
            this.buttonTemplate.TabIndex = 12;
            this.buttonTemplate.Text = "Передать";
            this.buttonTemplate.UseVisualStyleBackColor = true;
            this.buttonTemplate.Click += new System.EventHandler(this.buttonTemplate_Click);
            // 
            // buttonMatch
            // 
            this.buttonMatch.Location = new System.Drawing.Point(353, 201);
            this.buttonMatch.Name = "buttonMatch";
            this.buttonMatch.Size = new System.Drawing.Size(151, 28);
            this.buttonMatch.TabIndex = 14;
            this.buttonMatch.Text = "Проверка";
            this.buttonMatch.UseVisualStyleBackColor = true;
            this.buttonMatch.Click += new System.EventHandler(this.buttonMatch_Click);
            // 
            // buttonFillListBox
            // 
            this.buttonFillListBox.Location = new System.Drawing.Point(834, 273);
            this.buttonFillListBox.Name = "buttonFillListBox";
            this.buttonFillListBox.Size = new System.Drawing.Size(186, 49);
            this.buttonFillListBox.TabIndex = 16;
            this.buttonFillListBox.Text = "Заполнить";
            this.buttonFillListBox.UseVisualStyleBackColor = true;
            this.buttonFillListBox.Click += new System.EventHandler(this.buttonFillListBox_Click);
            // 
            // buttonTemList
            // 
            this.buttonTemList.Location = new System.Drawing.Point(1070, 275);
            this.buttonTemList.Name = "buttonTemList";
            this.buttonTemList.Size = new System.Drawing.Size(208, 46);
            this.buttonTemList.TabIndex = 17;
            this.buttonTemList.Text = "Добвавить шаблон";
            this.buttonTemList.UseVisualStyleBackColor = true;
            this.buttonTemList.Click += new System.EventHandler(this.buttonTemList_Click);
            // 
            // textBoxTemp
            // 
            this.textBoxTemp.Location = new System.Drawing.Point(1076, 351);
            this.textBoxTemp.Name = "textBoxTemp";
            this.textBoxTemp.Size = new System.Drawing.Size(202, 20);
            this.textBoxTemp.TabIndex = 18;
            // 
            // buttonWord1
            // 
            this.buttonWord1.Location = new System.Drawing.Point(62, 526);
            this.buttonWord1.Name = "buttonWord1";
            this.buttonWord1.Size = new System.Drawing.Size(184, 57);
            this.buttonWord1.TabIndex = 19;
            this.buttonWord1.Text = "Создать Word 1";
            this.buttonWord1.UseVisualStyleBackColor = true;
            this.buttonWord1.Click += new System.EventHandler(this.buttonWord_Click);
            // 
            // userControl31
            // 
            this.userControl31.GetIndex = -1;
            this.userControl31.Location = new System.Drawing.Point(803, 19);
            this.userControl31.Name = "userControl31";
            this.userControl31.Size = new System.Drawing.Size(476, 269);
            this.userControl31.TabIndex = 15;
            // 
            // userControl21
            // 
            this.userControl21.Location = new System.Drawing.Point(298, 12);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(292, 87);
            this.userControl21.TabIndex = 6;
            this.userControl21.Template = "^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$";
            this.userControl21.Value = null;
            // 
            // userControl11
            // 
            this.userControl11.GetSelectedItem = null;
            this.userControl11.Location = new System.Drawing.Point(27, 12);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(219, 34);
            this.userControl11.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Заголовок:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(156, 470);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(142, 20);
            this.textBoxTitle.TabIndex = 21;
            // 
            // buttonWord2
            // 
            this.buttonWord2.Location = new System.Drawing.Point(289, 523);
            this.buttonWord2.Name = "buttonWord2";
            this.buttonWord2.Size = new System.Drawing.Size(198, 59);
            this.buttonWord2.TabIndex = 22;
            this.buttonWord2.Text = "Создать Word 2";
            this.buttonWord2.UseVisualStyleBackColor = true;
            this.buttonWord2.Click += new System.EventHandler(this.buttonWord2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 640);
            this.Controls.Add(this.buttonWord2);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonWord1);
            this.Controls.Add(this.textBoxTemp);
            this.Controls.Add(this.buttonTemList);
            this.Controls.Add(this.buttonFillListBox);
            this.Controls.Add(this.userControl31);
            this.Controls.Add(this.buttonMatch);
            this.Controls.Add(this.buttonTemplate);
            this.Controls.Add(this.buttonExample);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTemplate);
            this.Controls.Add(this.textBoxExample);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.textBoxSet);
            this.Controls.Add(this.buttonTake);
            this.Controls.Add(this.buttonDispose);
            this.Controls.Add(this.buttonFill);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.userControl11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private ControlLibrary.UserControl1 userControl11;
		private System.Windows.Forms.Button buttonColor;
		private System.Windows.Forms.Button buttonFill;
		private System.Windows.Forms.Button buttonDispose;
		private System.Windows.Forms.Button buttonTake;
		private System.Windows.Forms.TextBox textBoxSet;
		private ControlLibrary.UserControl2 userControl21;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxExample;
		private System.Windows.Forms.TextBox textBoxTemplate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonExample;
		private System.Windows.Forms.Button buttonTemplate;
		private System.Windows.Forms.Button buttonMatch;
		private ControlLibrary.UserControl3 userControl31;
		private System.Windows.Forms.Button buttonFillListBox;
		private System.Windows.Forms.Button buttonTemList;
		private System.Windows.Forms.TextBox textBoxTemp;
        private System.Windows.Forms.Button buttonWord1;
        private NoVisualControl.Component1 component11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Button buttonWord2;
        private NoVisualControl.Component2 component21;
    }
}

