/*
 * Created by SharpDevelop.
 * User: Raytraycer
 * Date: 13-11-2012
 * Time: 21:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Batch_Creator
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.listView1 = new System.Windows.Forms.ListView();
			this.listView2 = new System.Windows.Forms.ListView();
			this.listView3 = new System.Windows.Forms.ListView();
			this.listView4 = new System.Windows.Forms.ListView();
			this.listView5 = new System.Windows.Forms.ListView();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.Location = new System.Drawing.Point(12, 22);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(85, 621);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// listView2
			// 
			this.listView2.Location = new System.Drawing.Point(103, 22);
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(85, 621);
			this.listView2.TabIndex = 0;
			this.listView2.UseCompatibleStateImageBehavior = false;
			// 
			// listView3
			// 
			this.listView3.Location = new System.Drawing.Point(194, 22);
			this.listView3.Name = "listView3";
			this.listView3.Size = new System.Drawing.Size(85, 621);
			this.listView3.TabIndex = 0;
			this.listView3.UseCompatibleStateImageBehavior = false;
			// 
			// listView4
			// 
			this.listView4.Location = new System.Drawing.Point(285, 22);
			this.listView4.Name = "listView4";
			this.listView4.Size = new System.Drawing.Size(85, 621);
			this.listView4.TabIndex = 0;
			this.listView4.UseCompatibleStateImageBehavior = false;
			// 
			// listView5
			// 
			this.listView5.Location = new System.Drawing.Point(376, 22);
			this.listView5.Name = "listView5";
			this.listView5.Size = new System.Drawing.Size(85, 621);
			this.listView5.TabIndex = 0;
			this.listView5.UseCompatibleStateImageBehavior = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(468, 22);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(548, 655);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.listView5);
			this.Controls.Add(this.listView4);
			this.Controls.Add(this.listView3);
			this.Controls.Add(this.listView2);
			this.Controls.Add(this.listView1);
			this.Name = "MainForm";
			this.Text = "Batch_Creator";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ListView listView5;
		private System.Windows.Forms.ListView listView4;
		private System.Windows.Forms.ListView listView3;
		private System.Windows.Forms.ListView listView2;
		private System.Windows.Forms.ListView listView1;
	}
}
