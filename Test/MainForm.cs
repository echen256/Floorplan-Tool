/*
 * Created by SharpDevelop.
 * User: Eric
 * Date: 10/31/2018
 * Time: 12:53 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace Test
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		
		
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		
		}
		
		Graphics g;
		
		void onMouseDown(object sender, EventArgs e)
		{
			if (pictureBox2.ClientRectangle.Contains(pictureBox2.PointToClient(Control.MousePosition))) {
				if ((Control.MouseButtons & MouseButtons.Left) != 0) {
					Debug.WriteLine("clicked");
				}
			}
		}
		
		void onMouseOverGrid (object sender, EventArgs e){
			Debug.WriteLine(Cursor.Position);
		}
		
		void drawGrid () {
			int x = 0;
			int y = 0;
			g = pictureBox2.CreateGraphics();
			var color = Color.LightGray;
			var fill = new SolidBrush(color);
			if (int.TryParse(textBox1.Text, out x) && int.TryParse(textBox2.Text, out y)) {
				
				var w = pictureBox2.Width / x;
				var h = pictureBox2.Height / y;
				var pen = new Pen(Color.Black);
				
				for (int i = 0; i < x; i++) {
					for (int j = 0; j < y; j++) {
						var rect = new Rectangle(i * w, j * h,w,h);
						g.DrawRectangle(pen,rect);
						g.FillRectangle(fill, new RectangleF(i * w + 1, j * h + 1, w-2,h-2));
					}
				}
				pictureBox2.Update();
			} else {
				Debug.WriteLine("invalid");
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			drawGrid();
		}
		
		private Point start = Point.Empty;
		private Point end = Point.Empty;
		private void Form2_MouseDown(object sender, MouseEventArgs e) {
			var p0 = ((Control)sender).Location;
			
			if ((e.Button & MouseButtons.Left) != 0) {
				start.X = e.X;
				start.Y = e.Y ;
			}
		}

		private void Form2_MouseMove(object sender, MouseEventArgs e) {
	
			Point p1;
			Point p2;
			if (((e.Button & MouseButtons.Left) != 0) && (start != Point.Empty)) {
				using (Graphics g = this.CreateGraphics()) {
					p1 = PointToScreen(start, (Control)sender);
					if (end != Point.Empty) {
						p2 = PointToScreen(end, (Control)sender);
						ControlPaint.DrawReversibleFrame(GetRectangleForPoints(p1, p2), Color.Black, FrameStyle.Dashed);
					}
					end.X = e.X;
					end.Y = e.Y;
					p2 = PointToScreen(end, (Control)sender);
					Debug.WriteLine(p2);
					ControlPaint.DrawReversibleFrame(GetRectangleForPoints(p1, p2), Color.Black, FrameStyle.Dashed);
				}
			}
		}
		
		Point PointToScreen (Point p, Control c){
			p = base.PointToScreen(p);
			var p0 = c.Location;
			return new Point(p.X + p0.X, p.Y + p0.Y);
		}
		
		Rectangle GetRectangleForPoints (Point p1, Point p2){
			return new Rectangle(p1, new Size(p2.X-p1.X,p2.Y-p1.Y));
		}

		private void Form2_MouseUp(object sender, MouseEventArgs e) {
			Point p1;
			Point p2;
			if ((end != Point.Empty) && (start != Point.Empty)) {
				using (Graphics g = this.CreateGraphics()) {
					p1 = PointToScreen(start, (Control)sender);
					p2 = PointToScreen(end, (Control)sender);
					ControlPaint.DrawReversibleFrame(GetRectangleForPoints(p1, p2), Color.Black, FrameStyle.Dashed);
				}
			}
			start = Point.Empty;
			end = Point.Empty;
		}
		
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void Label2Click(object sender, EventArgs e)
		{
	
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		
		
	}
}
