
namespace ControlLibrary
{
	partial class UserControl1
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
			this.ComboBox = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// ComboBox
			// 
			this.ComboBox.FormattingEnabled = true;
			this.ComboBox.Location = new System.Drawing.Point(3, 3);
			this.ComboBox.Name = "ComboBox";
			this.ComboBox.Size = new System.Drawing.Size(187, 21);
			this.ComboBox.TabIndex = 0;
			this.ComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
			// 
			// UserControl1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ComboBox);
			this.Name = "UserControl1";
			this.Size = new System.Drawing.Size(204, 36);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox ComboBox;
	}
}
