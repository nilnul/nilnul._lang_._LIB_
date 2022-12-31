using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.txt.lanG_
{
	/// <summary>
	/// from linear txt(str of chars) to linear objects(for example words). The scan is non-backtracking, meaning that objects will not intercept and will share no chars.
	/// Note the input of scan here is txt. if the input is a str of objs, the scanning is out of the scope of "nilnul.txt" and shall be defined in the scope of "nilnul.lang"
	/// vs Parse
	///		parser results in a tree while scanner results in a line.
	/// </summary>
	interface Scan
	{
	}
}
