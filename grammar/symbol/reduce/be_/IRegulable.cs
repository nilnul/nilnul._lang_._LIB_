using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang.grammar.symbol.reduce.be_
{
	/// https://en.wikipedia.org/wiki/Normal_form_(abstract_rewriting)#Definition
	/// <summary>
	/// weakly normalizable;
	/// there is one sequence that is <see cref="deduce.relay_.IFinite"/>
	/// </summary>
	/// alias:
	///		weakly normarable
	///		weak normalization property
	///		or is (weakly) normalizing (WN)
	public interface IRegulable:finite_.IUnCyclic
    {
    }

}
