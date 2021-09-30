
namespace ControlLibrary
{
	partial class ControlTextBoxMail
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

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.TextBox = new System.Windows.Forms.TextBox();
			this.labelExample = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// TextBox
			// 
			this.TextBox.Location = new System.Drawing.Point(41, 41);
			this.TextBox.Name = "TextBox";
			this.TextBox.Size = new System.Drawing.Size(218, 20);
			this.TextBox.TabIndex = 0;
			// 
			// labelExample
			// 
			this.labelExample.AutoSize = true;
			this.labelExample.Location = new System.Drawing.Point(55, 7);
			this.labelExample.Name = "labelExample";
			this.labelExample.Size = new System.Drawing.Size(10, 13);
			this.labelExample.TabIndex = 1;
			this.labelExample.Text = "-";
			this.labelExample.MouseHover += new System.EventHandler(this.labelExample_MouseHover);
			// 
			// UserControl2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.labelExample);
			this.Controls.Add(this.TextBox);
			this.Name = "UserControl2";
			this.Size = new System.Drawing.Size(293, 122);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TextBox;
		private System.Windows.Forms.Label labelExample;
	}
}
