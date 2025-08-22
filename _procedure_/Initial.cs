using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang._procedure_
{
	/// <summary>
	/// constants, variables declared at the beginning, with initial assignment (default would be assigned if no explicit value is provided);
	/// embedded block( also known as: subprocedure, or subroutine) can have its own initializations;
	/// analog to the arguments of <see cref="lang._functional_.Parameters"/>;
	/// this will allocate memory space;
	/// </summary>
	/// <remarks>
	/// to make the procedure more formalized, move all initialization to the beginning, such that:
	///		1) the variation of the subsequent logic is clear to read;
	///		2) easy to convert this into a <see cref="lang.IFunctional"/>
	/// </remarks>
	internal class Initial
	{
	}
}
