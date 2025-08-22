using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr_.const_
{
	///stackoverflow.com/questions/23529592/how-are-c-sharp-const-members-allocated-in-memory
	/// <summary>
	/// C# constants are implemented as fields with the literal constraint in the Common Language Infrastructure. 
	/// </summary>
	/// <remarks>
	/// They do not exist in a referencable location, but need to be available in the metadata and via reflection. They could be implemented like static fields, but do not have to.
	/// Constants are resolved at compile time, and the actual value of the constant is stored in the compiled DLL in place of references to the constant. In addition, the constant is saved as a member of the class in the DLL. This allows public constants to be referenced by external DLLs. However, the external references are also converted into the constant value when they are compiled.A ramification of the compile properties of constants means that if DLL1 refers to a constant in an external DLL2, and the constant definition in DLL2 changes, then DLL1 will not have the updated value unless it is recompiled, too.
	/// C# debugger does not allow breakpoints to be set at const assignments
	/// </remarks>
	internal class ILang
	{
	}
}
