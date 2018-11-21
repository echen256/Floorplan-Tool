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
			InitializeComponent();
			drawGrid();
		}
		
		Graphics pictureBoxGraphics;
		int x = 20;
		int y = 20;
		
		Pen blackPen = new Pen(Color.Black);
		SolidBrush greyFill = new SolidBrush(Color.LightGray);
		SolidBrush red = new SolidBrush(Color.Red);
		
		Dictionary<Point, Color> dict = new Dictionary<Point, Color>();
		
		void drawGrid()
		{

			pictureBoxGraphics = pictureBox2.CreateGraphics();

			var w = pictureBox2.Width / x;
			var h = pictureBox2.Height / y;
		
				
			for (int i = 0; i < x; i++) {
				for (int j = 0; j < y; j++) {
					var rect = new Rectangle(i * w, j * h, w, h);
					pictureBoxGraphics.DrawRectangle(blackPen, rect);
					pictureBoxGraphics.FillRectangle(greyFill, new RectangleF(i * w + 1, j * h + 1, w - 2, h - 2));
					dict[new Point(i, j)] = Color.White;
				}
			}
			pictureBox2.Update();
			

		}
		
		void Button1Click(object sender, EventArgs e)
		{
			var i = 0;
			var j = 0;
			if (int.TryParse(textBox1.Text, out i) && int.TryParse(textBox2.Text, out j)) {
				x = i;
				y = j;
				drawGrid();
			}
		}
		
		private Point start = Point.Empty;
		private Point end = Point.Empty;
		private void Form2_MouseDown(object sender, MouseEventArgs e)
		{
		
	
			if ((e.Button & MouseButtons.Left) != 0) {
				start.X = e.X;
				start.Y = e.Y;
			}
		}

		private void Form2_MouseMove(object sender, MouseEventArgs e)
		{
			var control = (Control)sender;
			
			Point p1;
			Point p2;
			if (((e.Button & MouseButtons.Left) != 0) && (start != Point.Empty)) {
				using (Graphics g = control.CreateGraphics()) {
					p1 = pictureBox2.PointToScreen(start);
				
					
					if (end != Point.Empty) {
						p2 = pictureBox2.PointToScreen(end);
					
						ControlPaint.DrawReversibleFrame(GetRectangleForPoints(p1, p2), Color.Black, FrameStyle.Dashed);
					}
					end.X = e.X;
					end.Y = e.Y;
					p2 = pictureBox2.PointToScreen(end);
					ControlPaint.DrawReversibleFrame(GetRectangleForPoints(p1, p2), Color.Black, FrameStyle.Dashed);
				}
			}
		}
		
		Point PointToScreen(Point p, Control c)
		{
			p = base.PointToScreen(p);
			var p0 = c.Location;
			return new Point(p.X + p0.X, p.Y + p0.Y);
		}
		
		Rectangle GetRectangleForPoints(Point p1, Point p2)
		{
			return new Rectangle(p1, new Size(p2.X - p1.X, p2.Y - p1.Y));
		}

		private void Form2_MouseUp(object sender, MouseEventArgs e)
		{
			var control = (Control)sender;
			Point p1;
			Point p2;
			if ((end != Point.Empty) && (start != Point.Empty)) {
				using (Graphics g = control.CreateGraphics()) {
					p1 = pictureBox2.PointToScreen(start);
					p2 = pictureBox2.PointToScreen(end);
					
					
					
					var r = GetRectangleForPoints(p1, p2);
					ControlPaint.DrawReversibleFrame(r, Color.Black, FrameStyle.Dashed);
			
					r = GetRectangleForPoints(pictureBox2.PointToClient(p1), pictureBox2.PointToClient(p2));
					Debug.WriteLine(r);
					var w = pictureBox2.Width / x;
					var h = pictureBox2.Height / y;
					p1 = r.Location;
					p2 = new Point(r.Location.X + r.Width, r.Location.Y + r.Height);
					
					for (int i = p1.X / w; i < p2.X / w; i++) {
						for (int j = p1.Y / h; j < p2.Y / h; j++) {
							var x1 = i * w + 1;
							var y1 = j * h + 1;
							
							dict[new Point(x1, y1)] = red.Color;
							g.FillRectangle(red, new RectangleF(x1, y1, w - 2, h - 2));
						}
					}
					
					
					
				}
				control.Update();
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
		
		private void checkedListBox1_ItemCheck(object sender, EventArgs e)
		{
			var e2 = (ItemCheckedEventArgs)e;
			for (int ix = 0; ix < checkedListBox1.Items.Count; ++ix)
				if (ix != e2.Index)
					checkedListBox1.SetItemChecked(ix, false);
		}
		
		
	}
}
