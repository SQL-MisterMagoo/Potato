using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Potato.Shared
{
	[AttributeUsage(validOn: AttributeTargets.Class,AllowMultiple =false,Inherited =false)]
  public class PageTitleAttribute : Attribute
  {
	public PageTitleAttribute(string pageTitle)
	{
	  PageTitle = pageTitle;
	}

	public string PageTitle { get; }
  }
}
