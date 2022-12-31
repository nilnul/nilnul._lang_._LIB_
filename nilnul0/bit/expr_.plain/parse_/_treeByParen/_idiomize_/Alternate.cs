using nilnul.bit.expr_.plain.parse_._treeByParen._idiomize._lex.token_;
using nilnul.bit.expr_.plain.parse_._treeByParen._idiomize_._alternate;
using nilnul.bit.expr_.plain.parse_._treeByParen._idiomize_._alternate.nub_;
using nilnul.bit.expr_.plain.parse_._treeByParen._idiomize_._alternate.nub_.arg_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.plain.parse_._treeByParen._idiomize_

{
	/// <summary>
	/// terms connected by operators
	/// </summary>
	public class Alternate : AlternateI
	{

		private List<NubI> _nubs = new List<NubI>();

		public List<NubI> nubs
		{
			get { return _nubs; }
			//set { _nubs = value; }
		}


		bool _nextIsArg = true;


		public void add(_alternate.nub_.OpI op)
		{

			if (_nextIsArg)
			{
				throw new Exception();

			}
			else
			{

				_nextIsArg = !_nextIsArg;
				_nubs.Add(op);

			}

		}



		public void add(Alternate tailChain)
		{

			foreach (var item in tailChain._nubs)
			{
				add(item);

			}

		}

		public void add(NubI item)
		{
			switch (item)
			{
				case nilnul.bit.expr_.plain.parse_._treeByParen._idiomize_._alternate.nub_.OpI op:
					add(item as _alternate.nub_.OpI);
					break;
				case ArgI arg:

					add(arg);
					break;

				default:
					throw new UnexpectedTypeException();
					break;
			}
		}

		public void add(_idiomize._lex.token_.DuoOpI tokenOp)
		{
			add(
				_idiomize_._alternate.nub_.op.OpX.Token2Formula(tokenOp)
			);
		}

		public void add(ArgI arg)
		{

			if (_nextIsArg)
			{
				_nextIsArg = !_nextIsArg;
				_nubs.Add(arg);
			}
			else
			{
				throw new Exception(" expecting an arg");
			}

		}

		internal void add(AtomicI atomicI)
		{
			add(ArgX.AtomToken2DuoArg(atomicI));
			return;

			throw new NotImplementedException();
		}

		public override string ToString()
		{
			return string.Join("", _nubs);
		}
	}
}
