
namespace ControlLibrary
{
	partial class UserControl3
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
			this.ListBox = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// ListBox
			// 
			this.ListBox.FormattingEnabled = true;
			this.ListBox.Location = new System.Drawing.Point(25, 40);
			this.ListBox.Name = "ListBox";
			this.ListBox.Size = new System.Drawing.Size(158, 186);
			this.ListBox.TabIndex = 0;
			// 
			// UserControl3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ListBox);
			this.Name = "UserControl3";
			this.Size = new System.Drawing.Size(403, 265);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox ListBox;
	}
}
