using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._lang._syntax.grammar_.regex.op_
{
	public interface IUnary
		:nilnul.obj.op_._binary_.BlankI
	{
	}

	public interface UnaryI<T> : nilnul.obj.op_.UnaryI<T>
		,IUnary
		where T: IRegex

	{

	}

	public interface UnaryI : UnaryI<RegexI>
		

	{ }
}
