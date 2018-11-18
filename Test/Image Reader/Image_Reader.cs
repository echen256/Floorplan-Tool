/*
 * Created by SharpDevelop.
 * User: Eric
 * Date: 10/31/2018
 * Time: 12:54 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Xml.Linq;
using System.Xml;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;



namespace Test.Image_Reader
{
	
	using Debug = System.Diagnostics.Debug;
	
	public class Image_Reader
	{
		public Image_Reader()
		{
		}
		
		string path = "C:\\Users\\Eric\\Desktop\\Proj\\img.svg";
		
		public void run () {  
			var stream = new FileStream(path, FileMode.Open);
			var file = XElement.Load(stream);
			var g = file.Elements().Where(a => (a.Attribute("id").Value == "layer1"));
	
			var rects = g.Elements();
			
			var svg = file.Element("svg");
			var w = svg.Attribute("width");
			var h = svg.Attribute("height");
			
			for (int i = 0; i < rects.Count();i++){
				
				var rect = rects.ElementAt(i);
				var style = rect.Attribute("style").ToString();
				var styleAttributes = style.Split(';');
				for (int j = 0; j < styleAttributes.Length;j++){
					var attr=  styleAttributes[j];
					if (attr.Contains("fill")){
						var value = attr.Split(':')[1];
						
					}
				}
				
			}
			stream.Close();
			
			
			
		}
	}
}
