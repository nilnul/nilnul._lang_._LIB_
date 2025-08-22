using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang._tex_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		compile
    interface IParse
		:
		nilnul.obj.ITo1<
			_lex.dub.ISlider
		
		>
    {
    }
    interface IParse<TOutput>
		:
		IParse
		,
		nilnul.obj.ITo<
			_lex.dub.ISlider
			,
			TOutput
		>
    {
    }


}
