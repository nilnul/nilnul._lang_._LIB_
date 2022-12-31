using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang.semantic
{
	/// <summary>
	/// a lang cannot express that:
	///		a snippet can run without exception.
	///	eg:
	///		if we want to express in Javascript that
	///			"void null" isEqTo "undefined"
	///		we may do:
	///			void null == undefined
	///		but the result can be false
	///		So we may again do:
	///			Debug.Assert(void null == undefined)
	///		but the assertion might fail.
	///		So, we cannot express that
	///			"void null" isEqTo "undefined"
	///			
	/// </summary>
	class ExpressCorrectnessWithouException
	{
	}
}
