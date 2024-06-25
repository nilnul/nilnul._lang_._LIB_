using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang.procedure
{
	/// it's all about data, and how to share it to facilitate a communication;
	/// <summary>
	/// there are some variables (data, in storage place).
	/// Some are kept as shared variables, also known as scope,
	/// some are delegated to a subscope for a subroutine that is to be created, replacing this subprocedure.
	///
	/// the new subroutine can visit shared variables. it can also visit the subscrope newly created for it.
	/// The shared variable including a specialized returning parameter, which is a storage place shared by both the subroutine and the parent procedure.
	///
	/// 
	/// if the parent shares nothing, but the returning parameter (which the parent initializes nothing, thus gives nothing informational to the child;) which is what the child returns to the parent in one way style (the parent cannot change it, but can read it; on the other hand, the child cannot change context, or argument, but can read it), then the subroutine is called pure function, or just function if purity is implied.
	///
	/// If the subroutine is simple enough, the calling ceremony of the subroutine, including :
	///		,capturization by child of some parent variables that may allow capturing part of parent scope, and this is empty for a pure function
	///		,parametrization (parent decides what to share to the child)
	///		,and what to do with the returned result, say, assigning to other data.
	///	, the cost may exceed the benefit. So in this case we can just copy|paste the subroutine, and this is generally easier to read.
	///		so if the subroutine is less than 3line, we dont make it a function.
	///		and if we indeed subroutine one, call a function that is nearer.
	///		
	/// </summary>
	internal class Contextualize
	{
	}
}
