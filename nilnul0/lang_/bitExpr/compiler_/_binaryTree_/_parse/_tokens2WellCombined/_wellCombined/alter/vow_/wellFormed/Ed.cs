using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang_.bitExpr.compiler_._binaryTree_._parse._tokens2WellCombined._wellCombined.alter.vow_.wellFormed
{
	public class Ed : nilnul.obj.vow.Ed<Alternate, alter.be_.wellFormed.Vow>
	{
		public Ed(Alternate val) : base(val)
		{
		}

		public _alternate.NubI _nub(int i)
		{
			return ed.nubs[i];
		}



		public IEnumerable<_alternate.NubI> nubs
		{
			get
			{
				return ed.nubs;
			}
		}


		public IEnumerable<_alternate.nub_.OpI> ops
		{
			get
			{
				for (int i = 1; i < ed.nubs.Count; i += 2)
				{
					yield return ed.nubs[i] as _alternate.nub_.OpI;

				}
			}
		}

		public _alternate.nub_.ArgI firstArg
		{
			get
			{
				return nubs.First() as _alternate.nub_.ArgI;
			}
		}


		public _alternate.nub_.ArgI lastArg
		{
			get
			{
				return nubs.Last() as _alternate.nub_.ArgI;
			}
		}

		public bool _opReducible(int i)
		{

			if (i == 0)
			{

				if (ops.Count() == 1)
				{
					return true;
				}
				else
				{
					if (_alternate.nub_.op.Priority.Instance.inside(ops.ElementAt(0), ops.ElementAt(1)))
					{
						return true;
					}

					else
					{
						return false;
					}
				}
			}
			else if (i == ops.Count() - 1)
			{
				if (_alternate.nub_.op.Priority.Instance.inside(ops.ElementAt(i - 1), ops.ElementAt(1)))
				{
					return false;
				}

				else
				{
					return true;
				}



			}
			else
			{

				if (

					!(_alternate.nub_.op.Priority.Instance.inside(ops.ElementAt(i - 1), ops.ElementAt(i)))

					&& 
					
					_alternate.nub_.op.Priority.Instance.inside(ops.ElementAt(i), ops.ElementAt(i + 1))


					)
				{

					return true;
				}

				else
				{
					return false;
				}


			}

		}

	}
}
