using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang.eg.logic._walk.alter.be
{
	public class Formula : nilnul.BeI<Alternate>
	{
		public bool be(Alternate obj)
		{
			return obj.nubs.Any() && obj.nubs.First() is nub.ArgI && obj.nubs.Last() is nub.ArgI;

			throw new NotImplementedException();
		}



		public class Asserted : nilnul.be.Asserted<Alternate, Formula>
		{

			public Asserted(Alternate alter) : base(alter)
			{

			}

			public _walk.NubI _nub(int i){
				return val.nubs[i];
			}



			public IEnumerable<_walk.NubI> nubs {
				get {
					return val.nubs;
				}
			}


			public IEnumerable<_walk.nub.OpI> ops {
				get {
					for (int i = 1; i < val.nubs.Count; i+=2)
					{
						yield return val.nubs[i] as _walk.nub.OpI;

					}
				}
			}

			public _walk.nub.ArgI firstArg {
				get {
					return nubs.First() as _walk.nub.ArgI;
				}
			}

			
			public _walk.nub.ArgI lastArg {
				get {
					return nubs.Last() as _walk.nub.ArgI;
				}
			}

			public bool _opReducible(int i) {

				if (i==0)
				{

					if (ops.Count()==1)
					{
						return true;
					}
					else
					{
						if (op.Priority.Instance.inside(ops.ElementAt(0), ops.ElementAt(1)) )
						{
							return true;
						}

						else
						{
							return false;
						}
					}
				}
				else if(i==ops.Count()-1)
				{
					if (op.Priority.Instance.inside(ops.ElementAt(i-1), ops.ElementAt(1)) )
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
						
						!(op.Priority.Instance.inside(ops.ElementAt(i-1), ops.ElementAt(i)) )

						&& op.Priority.Instance.inside(ops.ElementAt(i), ops.ElementAt(i+1)) 

						
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
}
