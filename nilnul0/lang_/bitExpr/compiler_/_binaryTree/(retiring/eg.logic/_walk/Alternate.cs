using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.lang.eg.logic._lex.token;
using nilnul.lang.eg.logic._walk.nub.arg;
using nilnul.lang.eg.logic._walk;
using nilnul.lang.eg.logic._walk.nub;
using nilnul.lang.eg.logic._walk.nub.op;

namespace nilnul.lang.eg.logic._walk
{
	/// <summary>
	/// terms connected by operators
	/// </summary>
	public class Alternate:NotArgI
	{

		private List<NubI> _nubs=new List<NubI>();

		public List<NubI> nubs
		{
			get { return _nubs; }
			//set { _nubs = value; }
		}


		bool _nextIsArg=true;


		public void add(nilnul.lang.eg.logic._walk.nub.OpI op) {

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

		

		public void add(Alternate tailChain) {

			foreach (var item in tailChain._nubs)
			{
				add(item);
				
			}

		}

		public void add(NubI item)
		{

			if (item is nilnul.lang.eg.logic._walk.nub.OpI)
			{
				add(item as nilnul.lang.eg.logic._walk.nub.OpI);
			}
			else if(item is ArgI)
			{
				add(item as ArgI);
			}
			else
			{
				throw new UnexpectedTypeException();
			}
			//throw new NotImplementedException();
		}

		public void add(_lex.token.DuoOpI tokenOp) {
			add(
				OpX.Token2Formula(tokenOp)
			);
		}

		public void add(ArgI arg) {

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
			add( ArgX.AtomToken2DuoArg(atomicI)  );
			return;

			throw new NotImplementedException();
		}

		public override string ToString()
		{
			return string.Join("", _nubs) ;
		}
	}
}
