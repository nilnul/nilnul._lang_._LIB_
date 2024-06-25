using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._lang._syntax.grammar_.regex.op_
{
	public interface IBinary
		:nilnul.obj.op_._binary_.BlankI
	{
	}

	public interface BinaryI<T> : nilnul.obj.op_.BinaryI<T>
		,IBinary
		where T: IRegex

	{

	}

	public interface BinaryI : BinaryI<RegexI>
		

	{ }
}
