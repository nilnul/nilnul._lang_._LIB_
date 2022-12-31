using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._lang.syntax_
{
	/// <summary>
	/// roughly speaking(ignoring some corner cases), Xml is defined by a set of production rules and this set of rules is context free. This is called well-formed Xml.
	/// In other words, well-formed Xml is context free. ("well-formed" here seems deviate from the official standards)
	/// 
	/// But that startTag and endTag must match cannot be expressed by context-free grammar. So xml standard utilizing English predicate to express such constraint. 
	/// </summary>
	interface IXml
	{

	}
}
