using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang.eg.logic._walk.op
{
	public class OpX
	{
		static public nilnul.bit.duo.OpI1 GetBitOp(
			nub.OpI op	
		) {

			if (op is nub.op.And)
			{
				return  nilnul.bit.duo.op.Mi.Instance;
			}
			else if (op is nub.op.Or)
			{
				return  nilnul.bit.duo.op.Ma.Singleton;
			}

			else if (op is nub.op.IfThen)
			{
				return  nilnul.bit.duo.op.Le.Singleton;
			}

			else if (op is nub.op.Iif)
			{
				return  nilnul.bit.duo.op.Eq.Singleton;
			}

			else 
			{
				throw new UnexpectedTypeException();
			}

		}
	}
}
