using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;

namespace nilnul.lang
{
	/// one pass or multi pass
	/// <summary>
	/// Building is done when preparing an application for release, which includes compiling, packaging, testing, etc. Compiling is done at any time the compiler is involved in translating programming language code to machine code.
	/// </summary>
	/// <remarks>
	/// compile is done at the language level, whileas build is done at the project evel;
	/// build includes compile as one of the many stages;
	/// </remarks>
	/// 
	public interface CompileI 
	{
		
	}
}
