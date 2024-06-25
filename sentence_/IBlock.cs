using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang.sentence_
{
	/// <summary>
	/// <see cref="lang.ISentences"/> enclosed by "{}"
	/// </summary>
	/// <remarks>
	/// the funtion body is a block;
	/// sentences, not enclosed by "{}" is not a block;
	/// block can be nested.
	/// </remarks>
	/// vs:
	///		sentences
	///			, block is explicitly enclosed by "{}", and a context(varaible scope) is associative to block, not sentences.
	internal class IBlock
	{
	}
}
