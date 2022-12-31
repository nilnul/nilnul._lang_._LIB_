using nilnul.lang.eg.logic._walk.nub.arg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace nilnul.lang.eg.logic
{
	/// <summary>
	/// process walked.
	/// </summary>
	/// 
	[Obsolete(nameof(nilnul.lang_.bitExpr.compiler_._binaryTree_))]
	public class Quodratise
	{

		public nilnul.bit.ExprI_membered parse(_walk.alter.be.Formula.Asserted formula ) {

			if (formula.ops.Any())
			{
				for (int i = 0; i < formula.ops.Count(); i++)
				{
					if (formula._opReducible(i))
					{
						var alter = new _walk.Alternate();
						alter.add(formula._nub(2*i));

						alter.add(formula._nub(2*i+1));

						alter.add(formula._nub(2*i+2));


						_walk.nub.arg.ParenedArg parened=new ParenedArg(
							new _walk.alter.be.Formula.Asserted(
								alter
							)
						);

						var alterR = new _walk.Alternate();

						for (int j = 0; j <2*i; j++)
						{

							alterR.add(formula.nubs.ElementAt(j));

						}
						alterR.add( parened);

						for (int j = 2*i+3; j <formula.nubs.Count(); j++)
						{

							alterR.add(formula.nubs.ElementAt(j));

						}

						//var op = formula.ops.First();




						//return new nilnul.bit.expr.duo.Call(
						//	_walk.op.OpX.GetBitOp(op)
						//	,

						//	parseMoNo(formula.firstArg)
						//	, parseMoNo(formula.lastArg)
						//);




						return parse(
								new _walk.alter.be.Formula.Asserted(
								alterR
							)
							
						);


					}
				}

			}
			else
			{
				return parseMoNo(formula.val.nubs.First() as _walk.nub.ArgI);	
			}

			throw new NotImplementedException();


		}

		public nilnul.bit.ExprI_membered parse(
			_walk.nub.arg.NotArgI arg
		) {

			if (arg is _walk.nub.arg.AtomI)
			{
				return  _build.AtomX.Create(
					arg as _walk.nub.arg.AtomI
				);
			}

			else if (arg is _walk.nub.arg.NotExpr)
			{


				return  nilnul.bit.expr.Call.CreateNeg(
					parse((arg as _walk.nub.arg.NotExpr).arg)
				);
			}

			else if (arg is _walk.nub.arg.ParenedArg)
			{
				
				return parse((arg as _walk.nub.arg.ParenedArg).expr);
			}

			else
			{
				//err("expecting a term");

				throw new ParseException("the arg of \"not\" can only be atom, \"not\" expr, or parened arg.");
			}


		}

		public nilnul.bit.ExprI_membered parseMoNo(
			_walk.nub.ArgI arg
		) {

			if (arg is _walk.nub.arg.AtomI)
			{
				return _build.AtomX.Create(
					arg as _walk.nub.arg.AtomI
				);
			}

			else if (arg is _walk.nub.arg.NotExpr)
			{
				

				return   nilnul.bit.expr.Call.CreateNeg(
					parse( (arg as _walk.nub.arg.NotExpr).arg)
				);
			}

			else if (arg is _walk.nub.arg.ParenedArg)
			{
				var formula=((arg as _walk.nub.arg.ParenedArg).expr);
				if (formula.ops.Any())
				{


					if (formula.ops.Count()==1)
					{
						var op = formula.ops.First();




						return new nilnul.bit.expr.duo.Call(
							_walk.op.OpX.GetBitOp(op)
							,

							parseMoNo(formula.firstArg)
							, parseMoNo(formula.lastArg)
						);

					}

					return parse( formula);



				}
				else
				{
					return parseMoNo(formula.firstArg);

				}


			}

			else
			{
				//err("expecting a term");

				throw new ParseException("unexpected error.");
			}




		}

		[Serializable]
		private class ParseException : Exception
		{
			public ParseException()
			{
			}

			public ParseException(string message) : base(message)
			{
			}

			public ParseException(string message, Exception innerException) : base(message, innerException)
			{
			}

			protected ParseException(SerializationInfo info, StreamingContext context) : base(info, context)
			{
			}
		}
	}
}
