using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang._syntax._grammars
{
	internal enum Li_
	{
		/// <summary>
		/// inside the function body;
		/// </summary>
		/// <remarks>
		/// can have contextual state embodied by local and environment vars;
		/// can have a sequential of sentences to transform the state;
		/// </remarks>
		Procedure
			,
		/// <summary>
		/// take the pars, and the environment that is accessable,  as the input;
		/// output is the returned value, and the changes made to the enviroment;
		/// </summary>
		/// <remarks>
		/// if no changes are made the environment, this is called pure function;
		/// </remarks>
		Function
			,
		/// <summary>
		/// a function and the enclosed fields;
		/// </summary>
		/// <remarks>
		/// if no changes are made to outside, that is, changes are only made to inside fields, the object is called self-contained, passive , or unobtrusive.
		/// if there is no state, the object is called stateless object;
		/// </remarks>
		Object
			,
		/// <summary>
		/// a dll; objects and resources, as well as metadata. a loaded assembly.
		/// </summary>
		/// <remarks>
		/// assembly loaded into appDomain, appDomain is in process, process is in memory and managed by Os
		/// </remarks>
		/// alias:
		///		assembly
		///		library
		///			lib
		///		dll
		///		script
		Module
	}
}
