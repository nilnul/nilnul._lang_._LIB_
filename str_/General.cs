using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang.str_
{
	/// <summary>
	/// a lang might be a str of langs: we first interprest one lang to second, then to third.
	/// eg:
	///		preprocess by lines, then characterwise escape/decomment, resulting in a mini lang.
	///		then we can base on that, and proceed to process as if the previous result is the src of a 2nd lang.
	/// </summary>
	class General
	{

	}
}
