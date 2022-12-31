using nilnul.lang_.bitExpr.compiler_._binaryTree_._lex.token_;
using nilnul.lang_.bitExpr.compiler_._binaryTree_._parse._tokens2WellCombined._wellCombined._alternate;
using nilnul.lang_.bitExpr.compiler_._binaryTree_._parse._tokens2WellCombined._wellCombined._alternate.nub_;
using nilnul.lang_.bitExpr.compiler_._binaryTree_._parse._tokens2WellCombined._wellCombined._alternate.nub_.arg_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang_.bitExpr.compiler_._binaryTree_._parse._tokens2WellCombined._wellCombined

{
	/// <summary>
	/// terms connected by operators
	/// </summary>
	public class Alternate:AlternateI
	{

		private List<NubI> _nubs=new List<NubI>();

		public List<NubI> nubs
		{
			get { return _nubs; }
			//set { _nubs = value; }
		}


		bool _nextIsArg=true;


		public void add(nilnul.lang_.bitExpr.compiler_._binaryTree_._parse._tokens2WellCombined._wellCombined._alternate.nub_.OpI op) {

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

			if (item is nilnul.lang_.bitExpr.compiler_._binaryTree_._parse._tokens2WellCombined._wellCombined._alternate.nub_.OpI)
			{
				add(item as nilnul.lang_.bitExpr.compiler_._binaryTree_._parse._tokens2WellCombined._wellCombined._alternate.nub_.OpI);
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

		public void add(compiler_._binaryTree_._lex.token_.DuoOpI tokenOp) {
			add(
				nilnul.lang_.bitExpr.compiler_._binaryTree_._parse._tokens2WellCombined._wellCombined._alternate.nub_.op.OpX.Token2Formula(tokenOp)
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
