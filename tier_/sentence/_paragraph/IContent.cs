using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang.tier_.sentence._paragraph
{
	/// <summary>
	/// sentences.
	/// better to conform to Xml Text rule, escaping any special chunk such as "&"
	/// ,
	/// or conforming Cdata rule, escaping "]]>", like:
	/// <![CDATA[ &><"', or ]] ]>  is usable here. but you cannot use the chunk like the ending of Cdata]]>
	/// </summary>
	///
	/// the xml escape using & is not a good choice, as '&' is frequently used in sentences.
	internal class IContent
	{
	}
}
