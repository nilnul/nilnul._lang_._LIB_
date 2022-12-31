using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.plain.parse_._treeByParen._idiomize_._alternate.nub_.op
{
	public class Priority : ord.InsideA<_alternate.nub_.OpI>
	{


		static public readonly Priority Instance = new Priority();

		public override bool inside(nub_.OpI x, nub_.OpI y)
		{
			if (x is nub_.op_.And)
			{
				return inside( x as nub_.op_.And, y);
			}
			else if(x is nub_.op_.Or)
			{
				return inside(x as nub_.op_.Or,y);
			}
			else if(x is nub_.op_.IfThen)
			{
				return inside(x as nub_.op_.IfThen,y);
			}

			else if(x is nub_.op_.Iif)
			{
				return inside(x as nub_.op_.Iif,y);
			}
			else
			{
				throw new UnexpectedTypeException();
			}


		}

		public  bool inside( nub_.op_.And left, nub_.op_.And right) {
			return true;
		}

		public  bool inside( nub_.op_.And left, nub_.OpI right) {
			return true;
		}
		public  bool inside( nub_.op_.Or left, nub_.op_.And right) {
			return false;
		}

		public  bool inside( nub_.op_.Or left, nub_.OpI right) {
			if (right is nub_.op_.And)
			{
				return inside(left, right as nub_.op_.And);
			}
			else 
			{
				return true;
			}
		}

		public  bool inside( nub_.op_.IfThen left, nub_.OpI right) {
			if (right is nub_.op_.And || right is nub_.op_.Or
				|| right is nub_.op_.IfThen	//right associative
				)
			{
				return false;
			}
			else 
			{
				return true;
			}
		}

		public  bool inside( nub_.op_.Iif left, nub_.OpI right) {
			if (right is nub_.op_.And || right is nub_.op_.Or
				|| right is nub_.op_.IfThen	

				|| right is nub_.op_.Iif	//right associative
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
