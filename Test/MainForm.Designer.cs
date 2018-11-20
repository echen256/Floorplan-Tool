/*
 * Created by SharpDevelop.
 * User: Eric
 * Date: 10/31/2018
 * Time: 12:53 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Test
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button addZoneButton;
		private System.Windows.Forms.TextBox newZoneTextBox;
		private System.Windows.Forms.Label Add_Zone;
		private System.Windows.Forms.ComboBox zoneDropdown;
		private System.Windows.Forms.Button removeZoneButton;
		private System.Windows.Forms.ColorDialog colorDialog1;
		
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
		public void InitializeComponent()

		{
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.zoneDropdown = new System.Windows.Forms.ComboBox();
			this.addZoneButton = new System.Windows.Forms.Button();
			this.newZoneTextBox = new System.Windows.Forms.TextBox();
			this.Add_Zone = new System.Windows.Forms.Label();
			this.removeZoneButton = new System.Windows.Forms.Button();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(13, 10);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Run Test";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(143, 12);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(404, 404);
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
			this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseUp);
			pictureBox2.MouseMove += Form2_MouseMove;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(19, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "X";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(19, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Y";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(30, 39);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(58, 20);
			this.textBox1.TabIndex = 5;
			this.textBox1.Text = "20";
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(30, 66);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(58, 20);
			this.textBox2.TabIndex = 6;
			this.textBox2.Text = "20";
			// 
			// zoneDropdown
			// 
			this.zoneDropdown.FormattingEnabled = true;
			this.zoneDropdown.Items.AddRange(new object[] {
			"Basic Room"});
			this.zoneDropdown.Location = new System.Drawing.Point(12, 92);
			this.zoneDropdown.Name = "zoneDropdown";
			this.zoneDropdown.Size = new System.Drawing.Size(121, 21);
			this.zoneDropdown.TabIndex = 8;
			// 
			// addZoneButton
			// 
			this.addZoneButton.Location = new System.Drawing.Point(12, 330);
			this.addZoneButton.Name = "addZoneButton";
			this.addZoneButton.Size = new System.Drawing.Size(121, 40);
			this.addZoneButton.TabIndex = 9;
			this.addZoneButton.Text = "Add Zone";
			this.addZoneButton.UseVisualStyleBackColor = true;
			// 
			// newZoneTextBox
			// 
			this.newZoneTextBox.Location = new System.Drawing.Point(12, 304);
			this.newZoneTextBox.Name = "newZoneTextBox";
			this.newZoneTextBox.Size = new System.Drawing.Size(100, 20);
			this.newZoneTextBox.TabIndex = 10;
			// 
			// Add_Zone
			// 
			this.Add_Zone.Location = new System.Drawing.Point(12, 278);
			this.Add_Zone.Name = "Add_Zone";
			this.Add_Zone.Size = new System.Drawing.Size(100, 23);
			this.Add_Zone.TabIndex = 11;
			this.Add_Zone.Text = "New Zone Name";
			// 
			// removeZoneButton
			// 
			this.removeZoneButton.Location = new System.Drawing.Point(13, 376);
			this.removeZoneButton.Name = "removeZoneButton";
			this.removeZoneButton.Size = new System.Drawing.Size(121, 40);
			this.removeZoneButton.TabIndex = 12;
			this.removeZoneButton.Text = "Remove Selected Zone";
			this.removeZoneButton.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 461);
			this.Controls.Add(this.removeZoneButton);
			this.Controls.Add(this.Add_Zone);
			this.Controls.Add(this.newZoneTextBox);
			this.Controls.Add(this.addZoneButton);
			this.Controls.Add(this.zoneDropdown);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "Test";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
