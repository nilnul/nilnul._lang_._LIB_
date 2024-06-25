using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._lang._syntax._grammar.rule_
{
	/// <summary>
	///  A :  "" | Seeded
	/// Seeded: Seed A
	/// </summary>
	/// <remarks>
	/// This one is elegant in Lex. for eample, "" is "", "a" is ""+"a"
	/// </remarks>
	public class Recursion:RuleI
	{
	}

	/// <summary>
	/// A: Seed | Seed A
	/// </summary>
	/// <remarks>
	/// this one is good for LookAhead parse. for example 0 is not "", but "0"
	/// </remarks>
	public class RecursionNonTrivia : RuleI {

	}
}
