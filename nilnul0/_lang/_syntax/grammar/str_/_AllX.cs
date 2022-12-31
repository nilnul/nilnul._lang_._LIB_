using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._lang._syntax.grammar.str_
{

	public class _AllX
	{

		/// <summary>
		/// </summary>
		/// <remarks>
		/// </remarks>
		/// <seealso cref="_lang.syntax._build.Phase_"/>
		IEnumerable<Type> grammars
		{
			get
			{
				yield return typeof(grammar_.IPreprocesser);  
				yield return typeof(grammar_.IScanner);

				yield return typeof(grammar_.ITokenizer); //non recursive

				yield return typeof(grammar_.IIdiomizer);	// recursive

	
				yield return typeof(grammar_.IParser);

				
				yield return typeof(grammar_.ICompiler);

				yield return typeof(grammar_.ILinker);

				







			}
		}
	}
}
