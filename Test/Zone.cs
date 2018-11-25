/*
 * Created by SharpDevelop.
 * User: erict
 * Date: 11/23/2018
 * Time: 10:54 AM
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

namespace Test
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class Zone {
		
		public HashSet<Point> pointsInZone;
		
		public Zone () {
			pointsInZone = new HashSet<Point>();
			
		}
		
		public Zone (Color c, string n, int w, int h) : this(){
			this.color = c;
			this.name = n;
			this.w = w;
			this.h = h;
			
		}
		
		public Zone (Zone other) : this(other.color,other.name, other.w, other.h){
			
		}
		
		public Color color;
		public string name;
		public int w;
		public int h;
		
		#region Equals and GetHashCode implementation
		public override bool Equals(object obj)
		{
			Zone other = obj as Zone;
				if (other == null)
					return false;
						return this.color == other.color && this.name == other.name && this.w == other.w && this.h == other.h;
		}

		public override int GetHashCode()
		{
			int hashCode = 0;
			unchecked {
				hashCode += 1000000007 * color.GetHashCode();
				if (name != null)
					hashCode += 1000000009 * name.GetHashCode();
				hashCode += 1000000021 * w.GetHashCode();
				hashCode += 1000000033 * h.GetHashCode();
			}
			return hashCode;
		}

		public static bool operator ==(Zone lhs, Zone rhs) {
			if (ReferenceEquals(lhs, rhs))
				return true;
			if (ReferenceEquals(lhs, null) || ReferenceEquals(rhs, null))
				return false;
			return lhs.Equals(rhs);
		}

		public static bool operator !=(Zone lhs, Zone rhs) {
			return !(lhs == rhs);
		}

		#endregion
	}
	
}
