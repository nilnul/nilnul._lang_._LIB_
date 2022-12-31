using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.plain.parse_._treeByParen._idiomize_.alter.be_
{

	/// <summary>
	/// A formula is an alternating sequence of vertices and edges, starting and ending at a vertex, in which each edge is adjacent in the sequence to its two endpoints.
	/// </summary>
	public class Formula : nilnul.obj.BeI1<Alternate>
	{
		public bool be(Alternate obj)
		{
			return obj.nubs.Any() && obj.nubs.First() is _alternate.nub_.ArgI && obj.nubs.Last() is _alternate.nub_.ArgI;

			throw new NotImplementedException();
		}



		
	}
}
