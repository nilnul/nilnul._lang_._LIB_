using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang.sentence_
{
	///
	/// <summary>
	/// <see cref="lang.ISentences"/> enclosed by "{}".
	/// the end is not ';', but '}'
	/// ;
	/// </summary>
	/// <remarks>
	/// the function body is a block;
	/// sentences, not enclosed by "{}" is not a block;
	/// block can be nested.
	/// </remarks>
	/// vs:
	///		block
	///			,braced
	///		sentences
	///			, block is explicitly enclosed by "{}", and a context(variable scope) is associative to block, not sentences.
	///		statement
	///		declaration
	///		scope
	///		group
	///		embed
	///		compound
	///			/complex/combined/combination/composed/clamped
	///
	/// 
	/// learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/statements
	/// 
	internal class IBlock
	{
	}
}
