﻿/*
 * Created by SharpDevelop.
 * User: Citeb
 * Date: 14/09/2023
 * Time: 09:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace projectTextBox
{
	partial class Form3
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.RichTextBox richTextBox;
		private System.Windows.Forms.Button button1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.richTextBox = new System.Windows.Forms.RichTextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// richTextBox
			// 
			this.richTextBox.Location = new System.Drawing.Point(41, 30);
			this.richTextBox.Name = "richTextBox";
			this.richTextBox.Size = new System.Drawing.Size(352, 159);
			this.richTextBox.TabIndex = 0;
			this.richTextBox.Text = "";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(150, 195);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(109, 51);
			this.button1.TabIndex = 1;
			this.button1.Text = "Carregar Valores";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(434, 311);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.richTextBox);
			this.Name = "Form3";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form3";
			this.ResumeLayout(false);

		}
	}
}
