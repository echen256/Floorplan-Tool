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
using System.Linq;
using System.Xml;
using System.Xml.Serialization;

namespace Test
{
	
	
	
	public partial class MainForm : Form
	{
		public static Pen blackPen = new Pen(Color.Black);
		public static Color backgroundColor = Color.LightGray;
		public static SolidBrush defaultColor = new SolidBrush(backgroundColor);
		
		
		public MainForm()
		{
			InitializeComponent();
			loadXML();
			
			drawGrid();
		}
		
		
		
		Graphics pictureBoxGraphics;
		int x = 20;
		int y = 20;
		
		List<Zone> propList = new List<Zone>();
		Dictionary<Point, Zone> dict = new Dictionary<Point, Zone>();

		void drawGrid()
		{

			pictureBoxGraphics = pictureBox2.CreateGraphics();

			var w = pictureBox2.Width / x;
			var h = pictureBox2.Height / y;
		
				
			for (int i = 0; i < x; i++) {
				for (int j = 0; j < y; j++) {
					var rect = new Rectangle(i * w, j * h, w, h);
					pictureBoxGraphics.DrawRectangle(blackPen, rect);
					pictureBoxGraphics.FillRectangle(defaultColor, new RectangleF(i * w + 1, j * h + 1, w - 2, h - 2));
					//dict[new Point(i, j)] = Color.White;
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
		
		void drawPoint(int i, int j, SolidBrush brush, Graphics g)
		{
			var w = pictureBox2.Width / x;
			var h = pictureBox2.Height / y;
			var x1 = i * w + 1;
			var y1 = j * h + 1;
			var p = new Point(i, j);
	
			
			g.FillRectangle(brush, new RectangleF(x1, y1, w - 2, h - 2));
		}

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
		
		private void Form2_MouseUp(object sender, MouseEventArgs e)
		{
			var control = (Control)sender;
			Point p1;
			Point p2;
			if (zoneDropdown.SelectedIndex < 0)
				return;
			var zoneName = (string)zoneDropdown.SelectedItem;
			var zone = (propList.Find(x => x.name.Equals(zoneName)));
			var color = zone.color;
			var brush = new SolidBrush(color);
		
			if ((end != Point.Empty) && (start != Point.Empty)) {
				
				using (Graphics g = control.CreateGraphics()) {
					
					p1 = pictureBox2.PointToScreen(start);
					p2 = pictureBox2.PointToScreen(end);
					var r = GetRectangleForPoints(p1, p2);
					ControlPaint.DrawReversibleFrame(r, Color.Black, FrameStyle.Dashed);
			
					r = GetRectangleForPoints(pictureBox2.PointToClient(p1), pictureBox2.PointToClient(p2));
			
					var w = pictureBox2.Width / x;
					var h = pictureBox2.Height / y;
					p1 = r.Location;
					
					p2 = new Point((r.Location.X + r.Width) / w, (r.Location.Y + r.Height) / h);
					p1 = new Point(p1.X / w, p1.Y / h);
			
					for (int i = p1.X; i <= p2.X; i += zone.w) {
						for (int j = p1.Y; j <= p2.Y; j += zone.h) {
						
							
					
							var z2 = new Zone(zone);
							for (int k = 0; k < z2.w; k++) {
								for (int l = 0; l < z2.h; l++) {
									var p = new Point(i + k, j + l);
									z2.pointsInZone.Add(p);
									

									if (dict.ContainsKey(p) && dict[p] != null) {
										var z0 = dict[p];
										foreach (Point p0 in z0.pointsInZone) {
											dict[p0] = null;
											drawPoint(p0.X, p0.Y, defaultColor, g);
										}
									}
									
									
									
									dict[p] = z2;
									drawPoint(p.X,p.Y, brush, g);
								}
							}
							
						}
					}
					
					
				
				}
				control.Update();
			}
			start = Point.Empty;
			end = Point.Empty;
			
		}
		
		void clearZonesButton(object sender, EventArgs e)
		{
			drawGrid();
		}
		
		void addZoneClick(object sender, EventArgs e)
		{
			/*var text = newZoneTextBox.Text;
			if (!zoneDropdown.Items.Contains(text) && text != "") {

				ColorDialog dialog = new ColorDialog();
				dialog.ShowDialog();
				var color = dialog.Color;
				var w = int.Parse(newZoneWidth.Text);
				var h = int.Parse(newZoneHeight.Text);
				var name = newZoneTextBox.Text;
				
				zoneDropdown.Items.Add(new Zone(color,name,w,h));
				
				
			}	*/	
		}
		
		void saveZoneClick (object sender, EventArgs e){
			var path = "C:\\Users\\erict\\Desktop\\Bootcamp\\Floorplan-Tool\\Test\\list.xml";
			XmlDocument doc = new XmlDocument();
			doc.Load(path);
			var root = doc.FirstChild;
			
		}
		
		void removeZoneClick(object sender, EventArgs e)
		{
			/*var itemIndex = zoneDropdown.SelectedIndex;
			if (itemIndex > 1) {
				var item = zoneDropdown.Items[itemIndex];
				var name = item.
				zoneColorDict.Remove(color);
				colorZoneDict.Remove(item);
				var keys = dict.Keys.ToList();
				foreach (Point p in keys) {
					if (dict[p].name.Equals(color)) {
						dict.Remove(p);
						drawPoint(p.X, p.Y, defaultColor, pictureBoxGraphics);
					}
				}
				zoneDropdown.Items.RemoveAt(itemIndex);
				pictureBox2.Update();
			}*/
			
			
		}
		
		
		void drawBrush(Point p, int w, int h)
		{
			Debug.WriteLine("f: " + p);
			var brush = new SolidBrush(Color.Red);
			for (int i = p.X; i < p.X + w; i++) {
				for (int j = p.Y; j < p.Y + h; j++) {
					drawPoint(i, j, brush, pictureBoxGraphics);
				}
			}
			
		}
		
		void loadXML()
		{
			var path = "C:\\Users\\erict\\Desktop\\Bootcamp\\Floorplan-Tool\\Test\\list.xml";
			XmlDocument doc = new XmlDocument();
			doc.Load(path);
			var root = doc.FirstChild;
			var children = root.ChildNodes;
			for (int i = 0; i < children.Count; i++) {
				var hex = children[i].Attributes["color"].Value;
				var w = children[i].Attributes["w"].Value;
				var h = children[i].Attributes["h"].Value;
				propList.Add(new Zone((Color)new ColorConverter().ConvertFromString(hex), children[i].Name, int.Parse(w), int.Parse(h)));
				zoneDropdown.Items.Add(children[i].Name);
			}
		}
		
		void writeRoom (object sender, EventArgs e){
			if (newZoneTextBox.Text == "") return;
			
			var zones = dict.Values.ToList();
			var xmlWriter = XmlWriter.Create("C:\\Users\\erict\\Desktop\\Bootcamp\\Floorplan-Tool\\Test\\" + newZoneTextBox.Text + ".xml");	
			XmlSerializer serializer = new XmlSerializer(typeof(List<Zone>));
			serializer.Serialize(xmlWriter,zones);
            xmlWriter.Close();
			                       
		}
		
		void loadRoom (object sender, EventArgs e){
			
		}
	}
}
