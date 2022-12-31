using nilnul.lang_.bitExpr.compiler_._binaryTree_._parse;
using nilnul.lang_.bitExpr.compiler_._binaryTree_._parse._tokens2WellCombined._wellCombined;
using nilnul.lang_.bitExpr.compiler_._binaryTree_._parse._tokens2WellCombined._wellCombined._alternate.nub_.arg_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang_.bitExpr.compiler_._binaryTree_
{
	/// <summary>
	/// considering the priority(precedence and associativity) of ops and build a tree
	/// </summary>
	public class Parse
	{


		public nilnul.bit.ExprI1 parse(_parse._tokens2WellCombined._wellCombined.alter.vow_.wellFormed.Ed formula)
		{

			if (formula.ops.Any())
			{
				for (int i = 0; i < formula.ops.Count(); i++)
				{
					if (formula._opReducible(i))
					{
						var alter = new nilnul.lang_.bitExpr.compiler_._binaryTree_._parse._tokens2WellCombined._wellCombined.Alternate();
						alter.add(formula._nub(2 * i));

						alter.add(formula._nub(2 * i + 1));

						alter.add(formula._nub(2 * i + 2));


						_parse._tokens2WellCombined._wellCombined._alternate.nub_.arg_.ParenedArg parened = new _parse._tokens2WellCombined._wellCombined._alternate.nub_.arg_.ParenedArg(
							new _parse._tokens2WellCombined._wellCombined.alter.vow_.wellFormed.Ed(
								alter
							)
						);

						var alterR = new Alternate();

						for (int j = 0; j < 2 * i; j++)
						{

							alterR.add(formula.nubs.ElementAt(j));

						}
						alterR.add(parened);

						for (int j = 2 * i + 3; j < formula.nubs.Count(); j++)
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
								new _parse._tokens2WellCombined._wellCombined.alter.vow_.wellFormed.Ed(
								alterR
							)

						);


					}
				}

			}
			else
			{
				return parseMoNo(formula.ed.nubs.First() as nilnul.lang_.bitExpr.compiler_._binaryTree_._parse._tokens2WellCombined._wellCombined._alternate.nub_.ArgI);
			}

			throw new NotImplementedException();


		}

		public nilnul.bit.ExprI1 parse(
			NotArgI arg
		)
		{

			if (arg is AtomI)
			{
				return AtomX.Create(
					arg as AtomI
				).ed;
			}

			else if (arg is NotExpr)
			{


				return nilnul.bit.expr_.call_.Mono.CreateNeg(
					parse((arg as nilnul.lang_.bitExpr.compiler_._binaryTree_._parse._tokens2WellCombined._wellCombined._alternate.nub_.arg_.NotExpr).arg)
				);
			}

			else if (arg is ParenedArg)
			{

				return parse((arg as ParenedArg).expr);
			}

			else
			{
				//err("expecting a term");

				throw new ParseException("the arg of \"not\" can only be atom, \"not\" expr, or parened arg.");
			}


		}

		public nilnul.bit.ExprI1 parseMoNo(
			nilnul.lang_.bitExpr.compiler_._binaryTree_._parse._tokens2WellCombined._wellCombined._alternate.nub_.ArgI arg
		)
		{

			if (arg is AtomI)
			{
				return AtomX.Create(
					arg as nilnul.lang_.bitExpr.compiler_._binaryTree_._parse._tokens2WellCombined._wellCombined._alternate.nub_.arg_.AtomI
				).ed;
			}

			else if (arg is NotExpr)
			{


				return nilnul.bit.expr_.call_.Mono.CreateNeg(
					parse((arg as nilnul.lang_.bitExpr.compiler_._binaryTree_._parse._tokens2WellCombined._wellCombined._alternate.nub_.arg_.NotExpr).arg)
				);
			}

			else if (arg is nilnul.lang_.bitExpr.compiler_._binaryTree_._parse._tokens2WellCombined._wellCombined._alternate.nub_.arg_.ParenedArg)
			{
				var formula = ((arg as ParenedArg).expr);
				if (formula.ops.Any())
				{


					if (formula.ops.Count() == 1)
					{
						var op = formula.ops.First();




						return new nilnul.bit.expr_.call_.Duo1(
							nilnul.lang_.bitExpr.compiler_._binaryTree_._parse._tokens2WellCombined._wellCombined._alternate.nub_.op.OpX.GetBitOp(op)
							,

							parseMoNo(formula.firstArg)
							, parseMoNo(formula.lastArg)
						);

					}

					return parse(formula);



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

