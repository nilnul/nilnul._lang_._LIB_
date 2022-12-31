using nilnul.bit.expr_.plain.parse_._treeByParen;
using nilnul.bit.expr_.plain.parse_._treeByParen._idiomize_._alternate.nub_.arg_;
using nilnul.bit.expr_.plain.parse_._treeByParen._idiomize_;
using nilnul.bit.expr_.plain.parse_._treeByParen._idiomize_._alternate.nub_.arg_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.plain.parse_
{
	/// <summary>
	/// considering the priority(precedence and associativity) of ops and build a tree
	/// </summary>
	public partial class TreeByParen
	{

		/// <summary>
		/// parse to establish pattern
		/// </summary>
		/// <param name="formula"></param>
		/// <returns></returns>
		public nilnul.bit.expr_.PlainI parse(_treeByParen._idiomize_.alter.vow_.wellFormed.Ed formula)
		{

			if (formula.ops.Any())
			{
				for (int i = 0; i < formula.ops.Count(); i++)
				{
					if (formula._opReducible(i))
					{
						var alter = new _treeByParen._idiomize_.Alternate();
						alter.add(formula._nub(2 * i));

						alter.add(formula._nub(2 * i + 1));

						alter.add(formula._nub(2 * i + 2));


						_treeByParen._idiomize_._alternate.nub_.arg_.ParenedArg parened = new _treeByParen._idiomize_._alternate.nub_.arg_.ParenedArg(
							new _treeByParen._idiomize_.alter.vow_.wellFormed.Ed(
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
								new _treeByParen._idiomize_.alter.vow_.wellFormed.Ed(
								alterR
							)

						);


					}
				}

			}
			else
			{
				return parseMoNo(formula.ed.nubs.First() as _treeByParen._idiomize_._alternate.nub_.ArgI);
			}

			throw new NotImplementedException();


		}

		public nilnul.bit.expr_.PlainI parse(
			NotArgI arg
		)
		{

			if (arg is AtomI)
			{
				return AtomX.Create(
					arg as AtomI
				);
			}

			else if (arg is NotExpr)
			{


				return nilnul.bit.expr_.plain_.call_.Unary.CreateNeg(
					parse((arg as _treeByParen._idiomize_._alternate.nub_.arg_.NotExpr).arg)
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

		public nilnul.bit.expr_.PlainI parseMoNo(
			_treeByParen._idiomize_._alternate.nub_.ArgI arg
		)
		{

			if (arg is AtomI)
			{
				return AtomX.Create(
					arg as _treeByParen._idiomize_._alternate.nub_.arg_.AtomI
				);
			}

			else if (arg is NotExpr)
			{


				return nilnul.bit.expr_.plain_.call_.Unary.CreateNeg(
					parse((arg as _treeByParen._idiomize_._alternate.nub_.arg_.NotExpr).arg)
				);
			}

			else if (arg is _treeByParen._idiomize_._alternate.nub_.arg_.ParenedArg)
			{
				var formula = ((arg as ParenedArg).expr);
				if (formula.ops.Any())
				{


					if (formula.ops.Count() == 1)
					{
						var op = formula.ops.First();




						return new nilnul.bit.expr_.plain_.call_.Binary(
							_treeByParen._idiomize_._alternate.nub_.op.OpX.GetBitOp(op)
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
	}
}

