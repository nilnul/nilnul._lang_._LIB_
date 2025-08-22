using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.method._name_._valid
{
    enum Li_
    {

		/// <summary>
		/// eg:
		///		_Op_assume
		///		,where the input would be assumed invalid. The procedure wouldnot check its validity. But type integrity is still kept; that is, type returned would be still valid as the type's ctor would still check any input; but other checks are omitted, to better performance;
		/// </summary>
		/// <remarks>
		/// it's the caller, maintained by the programmer person, who takes the responsibility to ensure the input is right, by checking it or taking it granted according to some theory/proof derived from axiom|belief.
		/// </remarks>
		/// 
		/// <!---->
		/// <!---->
		Assume
			,
		/// <summary>
		/// eg:
		///		_Op_assert
		///	, where the val would be <see cref="nilnul.obj.IVow"/>ed to ensure it's valid
		/// </summary>
		/// <remarks>
		/// it's the method body's responsibility to ensure the input is valid; an exception would be thrown to abort the algorithm, if the input is invalid
		/// </remarks>
		Assert
			,
		/// <summary>
		/// take the input as valid.
		/// eg:
		///  class _Unial{
		///		[ctor]
		///		_Unial(double a, double b){
		///			/// fields assignment
		///		}
		///		static public _Unial _Create_acceptUnial(double a, double b){
		///			return new _Unial(a,b);
		///		}
		///	}
		///		,for double type, the precision is fluid; that is we don't know the precision in advance as it's too complex or impractical or expensive to know. The the type of unial vect can allow any doulbe components that the programmer sees fit; but we still make it a type to make explicit the intention, and as a reminder that the object is in fact a unial, and nonunial shall not be accepted.
		///		
		/// </summary>
		/// <remarks>
		/// a way to keep type integrity, while allowing some nonproven/nonchecked values.
		/// </remarks>
		/// alias:
		///		accept
		///		allow
		Accept

			,
		/// allot
		/// assign
		/// allude
		/// 
    }
}
