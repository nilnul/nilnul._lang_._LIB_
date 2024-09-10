using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang_.ling.sentence_._keywords.tgt
{
	/// <summary>
	/// 
	/// </summary>
	static public class _TexfyX
	{
		/// <summary>
		/// 
		/// </summary>
		/// alias:
		///		label
		public const string KEY = "keywords";

		/// <summary>
		/// no ending semicolon, which is used for a sentence, not an <see cref="nilnul.obj.IAttr"/>
		/// </summary>
		/// <param name="keywords">
		/// each is a keyword
		/// </param>
		/// <returns></returns>
		/// 
		static public string _Texfy_0keywords(IEnumerable<string> keywords) {
			return nilnul.obj.duo.Phrase.Unison.phrase(
				KEY
				,
				nilnul.objs._PhraseX._Phrase(keywords)  /// do not use <see cref="nilnul.obj.str.ITexfy"/>, which is fenced.
			);
		}
	}
}
