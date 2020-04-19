using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Potato.Shared
{
	public class MenuData
	{
		public string RelativeUrl { get; set; }
		public string MenuTitle { get; set; }

		public override string ToString()
		{
			return $"Url: {RelativeUrl} Title: {MenuTitle}";
		}
	}
}
