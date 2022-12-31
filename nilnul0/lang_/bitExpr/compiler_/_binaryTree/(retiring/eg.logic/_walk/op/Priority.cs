using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang.eg.logic._walk.op
{
	public class Priority : ord.InsideA<_walk.nub.OpI>
	{


		static public readonly Priority Instance = new Priority();

		public override bool inside(nub.OpI x, nub.OpI y)
		{
			if (x is nub.op.And)
			{
				return inside( x as nub.op.And, y);
			}
			else if(x is nub.op.Or)
			{
				return inside(x as nub.op.Or,y);
			}
			else if(x is nub.op.IfThen)
			{
				return inside(x as nub.op.IfThen,y);
			}

			else if(x is nub.op.Iif)
			{
				return inside(x as nub.op.Iif,y);
			}
			else
			{
				throw new UnexpectedTypeException();
			}


		}

		public  bool inside( nub.op.And left, nub.op.And right) {
			return true;
		}

		public  bool inside( nub.op.And left, nub.OpI right) {
			return true;
		}
		public  bool inside( nub.op.Or left, nub.op.And right) {
			return false;
		}

		public  bool inside( nub.op.Or left, nub.OpI right) {
			if (right is nub.op.And)
			{
				return inside(left, right as nub.op.And);
			}
			else 
			{
				return true;
			}
		}

		public  bool inside( nub.op.IfThen left, nub.OpI right) {
			if (right is nub.op.And || right is nub.op.Or
				|| right is nub.op.IfThen	//right associative
				)
			{
				return false;
			}
			else 
			{
				return true;
			}
		}

		public  bool inside( nub.op.Iif left, nub.OpI right) {
			if (right is nub.op.And || right is nub.op.Or
				|| right is nub.op.IfThen	

				|| right is nub.op.Iif	//right associative
				)
			{
				return false;
			}
			else 
			{
				return true;
			}
		}






	}
}
