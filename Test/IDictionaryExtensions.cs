/*
 * Created by SharpDevelop.
 * User: erict
 * Date: 11/21/2018
 * Time: 9:16 PM
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
	/// Description of Class1.
	/// </summary>
	public static class IDictionaryExtensions
	{
		public static TKey FindKeyByValue<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TValue value)
		{
			if (dictionary == null)
				throw new ArgumentNullException("dictionary");

			foreach (KeyValuePair<TKey, TValue> pair in dictionary)
				if (value.Equals(pair.Value))
					return pair.Key;

			throw new Exception("the value is not found in the dictionary");
		}
	}
}
