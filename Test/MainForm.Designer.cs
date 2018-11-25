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
		private System.Windows.Forms.Button ClearZoneButton;
		private System.Windows.Forms.TextBox newZoneHeight;
		private System.Windows.Forms.TextBox newZoneWidth;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button saveZones;
		private System.Windows.Forms.Button button2;
		
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
			this.ClearZoneButton = new System.Windows.Forms.Button();
			this.newZoneHeight = new System.Windows.Forms.TextBox();
			this.newZoneWidth = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.saveZones = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 23);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(121, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Reset";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(184, 23);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(400, 400);
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
			this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
			this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseUp);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(19, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "X";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(19, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Y";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(30, 52);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(58, 20);
			this.textBox1.TabIndex = 5;
			this.textBox1.Text = "20";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(30, 78);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(58, 20);
			this.textBox2.TabIndex = 6;
			this.textBox2.Text = "20";
			// 
			// zoneDropdown
			// 
			this.zoneDropdown.FormattingEnabled = true;
			this.zoneDropdown.Location = new System.Drawing.Point(12, 108);
			this.zoneDropdown.Name = "zoneDropdown";
			this.zoneDropdown.Size = new System.Drawing.Size(121, 21);
			this.zoneDropdown.TabIndex = 8;
			// 
			// addZoneButton
			// 
			this.addZoneButton.Location = new System.Drawing.Point(12, 291);
			this.addZoneButton.Name = "addZoneButton";
			this.addZoneButton.Size = new System.Drawing.Size(76, 40);
			this.addZoneButton.TabIndex = 9;
			this.addZoneButton.Text = "Add Zone";
			this.addZoneButton.UseVisualStyleBackColor = true;
			this.addZoneButton.Click += new System.EventHandler(this.addZoneClick);
			// 
			// newZoneTextBox
			// 
			this.newZoneTextBox.Location = new System.Drawing.Point(12, 212);
			this.newZoneTextBox.Name = "newZoneTextBox";
			this.newZoneTextBox.Size = new System.Drawing.Size(121, 20);
			this.newZoneTextBox.TabIndex = 10;
			// 
			// Add_Zone
			// 
			this.Add_Zone.Location = new System.Drawing.Point(12, 186);
			this.Add_Zone.Name = "Add_Zone";
			this.Add_Zone.Size = new System.Drawing.Size(100, 23);
			this.Add_Zone.TabIndex = 11;
			this.Add_Zone.Text = "New Zone Name";
			// 
			// removeZoneButton
			// 
			this.removeZoneButton.Location = new System.Drawing.Point(12, 337);
			this.removeZoneButton.Name = "removeZoneButton";
			this.removeZoneButton.Size = new System.Drawing.Size(76, 40);
			this.removeZoneButton.TabIndex = 12;
			this.removeZoneButton.Text = "Remove Selected Zone";
			this.removeZoneButton.UseVisualStyleBackColor = true;
			this.removeZoneButton.Click += new System.EventHandler(this.removeZoneClick);
			// 
			// ClearZoneButton
			// 
			this.ClearZoneButton.Location = new System.Drawing.Point(12, 383);
			this.ClearZoneButton.Name = "ClearZoneButton";
			this.ClearZoneButton.Size = new System.Drawing.Size(76, 40);
			this.ClearZoneButton.TabIndex = 13;
			this.ClearZoneButton.Text = "Clear Zones";
			this.ClearZoneButton.UseVisualStyleBackColor = true;
			this.ClearZoneButton.Click += new System.EventHandler(this.clearZonesButton);
			// 
			// newZoneHeight
			// 
			this.newZoneHeight.Location = new System.Drawing.Point(30, 262);
			this.newZoneHeight.Name = "newZoneHeight";
			this.newZoneHeight.Size = new System.Drawing.Size(58, 20);
			this.newZoneHeight.TabIndex = 17;
			this.newZoneHeight.Text = "20";
			// 
			// newZoneWidth
			// 
			this.newZoneWidth.Location = new System.Drawing.Point(30, 238);
			this.newZoneWidth.Name = "newZoneWidth";
			this.newZoneWidth.Size = new System.Drawing.Size(58, 20);
			this.newZoneWidth.TabIndex = 16;
			this.newZoneWidth.Text = "20";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 265);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(19, 20);
			this.label3.TabIndex = 15;
			this.label3.Text = "H";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 241);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(19, 20);
			this.label4.TabIndex = 14;
			this.label4.Text = "W";
			// 
			// saveZones
			// 
			this.saveZones.Location = new System.Drawing.Point(103, 291);
			this.saveZones.Name = "saveZones";
			this.saveZones.Size = new System.Drawing.Size(75, 40);
			this.saveZones.TabIndex = 18;
			this.saveZones.Text = "Save Room";
			this.saveZones.UseVisualStyleBackColor = true;
			this.saveZones.Click += new System.EventHandler(this.writeRoom);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(103, 337);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 40);
			this.button2.TabIndex = 19;
			this.button2.Text = "Load Room";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(790, 461);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.saveZones);
			this.Controls.Add(this.newZoneHeight);
			this.Controls.Add(this.newZoneWidth);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.ClearZoneButton);
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
