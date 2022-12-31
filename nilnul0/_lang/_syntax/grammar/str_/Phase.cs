using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._lang.syntax._build
{
	/// <summary>
	/// except syntacal phases, there are some semantic phases built upon syntax result. semantic phases are excluded here.
	/// each of these treats src at diffeent grain scale.
	/// phase:
	///		1) preproc
	///		2) circaChar
	///		3) term (token), such as word"abc1", punctuations:",", " "
	///		4) idioms: comprise words, or recursively, idioms
	///				expression is a subtype of idiom
	///				sentence as a whole is an idiom
	///		5) sentences. for example in C#, braces-enclosed sentence, which is group ,and semicolon-ended sentence, which is primitive.
	///			sentence can recursively contains clauses, which, if not nested, is a sentence by itself.
	///		6) blob(a block), a str of setences, used inside block, function body, type declaration body, namespace body, or a file
	///		7) program/prj: many blobs
	///		8) sln:a tree of prj
	/// </summary>
	/// <remarks>
	/// alias:
	///		pass
	/// </remarks>
	///<seealso cref="_syntax.grammar.str_.IAll"/>
	/*
	 for example, in C#:

	----------------------------------------------------------

	using nilnul; //sentence1

	public class Abc123{
		public static void Main(){
			Console.WriteLine("hi");	//clause in clause1, in which: "Console.WriteLine" and '("hi")' constitute an idiom. this idiom together with ";" constitute another idiom which is also a sentence.

		}//clause1 in sentence2
	}	//sentence2

	----------------------------------------------------------


	//we have two sentences.
	 */

	///
	public enum Phase_
	{
		/// <summary>
		/// <see cref="nameof(_lang._syntax.grammar_.IPreprocesser)"/>
		/// will tell you which line is wrong
		/// </summary>
		/// <remarks>
		/// alias:
		///		preprocess
		///		preproc
		/// </remarks>
		Preprocess
			,
		/// <summary>
		/// will tell you which char is wrong at what line
		/// </summary>
		Scan
			,
		/// <summary>
		/// <see cref="nameof(_lang._syntax.grammar_.ITokenizer)"/>
		/// will tell you which char is expected at col of line. output word.
		/// </summary>
		Tokenize
			,
		/// <summary>
		///  input:tokens; output: expression.
		///  
		/// parsing recursively for phrase/idiom/term/expression.
		/// <see cref="nameof(_syntax.grammar_.IIdiomizer)"/>
		/// </summary>
		/// <remarks>
		/// about data
		/// </remarks>
		Term
			,
		/// <summary>
		/// idiom is different from expr in that:
		///		idiom may be a transition of state. It might a move/instruction to change an expression, not the static expression itself.
		/// </summary>
		/// <remarks>
		/// beyond data; regarding moves/programs/instructions
		/// </remarks>
		Idiomize
			,
		/// <summary>
		/// pattern, or structure, or template. Some are nouns, some are verbs, some are preset structure/syntax for a specified symantic. Abstract systax tree is formed.
		/// </summary>
		Structure
			

			,

		///construct tree for sentences. output sentences. clause is constructed recursively; sentence is a top-level clause.
		/// can deal with tree, while lex can only deal with list .
		///		   regularExpr can be used to construct lists; more sophiscated parses are needed to create trees.
		///
		///  // this need to be renamed in order to avoid confusion with _lexer_.Parse
		///  /// parse togther with the phrase, the reversed process of parse, is called lexer.
		///  <remarks>
		/// alias:
		///		sentential
		///		clausal
		///	concrete syntax tree; or abstract syntax tree with values.
		/// </remarks>
		Parse
		/*
			 nomenclature:
			mnemonics:
				parse is "partial", hence context free.
				parse is a phase
				parse is antonym to phrase
			 ***************/
			/*
			 after parse ,the build phases are contectual, or context-notFree
			 ****************/
			,
		/*
		 parse is context free; compile is contextual, note the beginning char "C"
		 ************/



		// input:procedure(a str of sentences, but with context such as bound variables; a procedure would )S/blobs. output: temporary module (procedure with enviroment context)   /   assembly
		//
		//
		/// <summary>
		/// this translate into machine code. so the stack and execution context would be considered.
		/// </summary>
		/// <remarks>
		/// alias:
		///		visitor
		///			visit might be referring to the step after parse, but before compile
		///			like expression visitor, this might run/interpret the lang.
		///	annotate AbastractSyntaxTree
		///		translate
		///	real-time analysis to help coder for better coding.
		/// </remarks>
		Compile

			,

		///intput: modules, output program(assemblies including main.exe and referenced.dll for references)
		/// Linking is when references (e.g. method calls) in the calling code to symbols (e.g. methods) in the DLL are replaced with the actual addresses of the things in the DLL. This is necessary because the eventual addresses of the things in the DLL cannot be known before it's been loaded into memory.
		Link
			,


		/// <summary>
		/// for this phase, translate lang into semantic realm. so we need to consider different runtime env, such as 64bit/32bit, instructSet, num of cpuEs, etc
		/// 
		/// </summary>
		/// <remarks>
		/// output intermediate code
		/// </remarks>
		Interpret
			
			,
		/// <summary>
		/// after interpreting, we can find the most efficient semantical equivalency of some synctacal structure such as program.
		/// In C#, [Conditional()] is processed here, not in procesing when "#if something"
		/// 
		/// </summary>
		/// <remarks>
		/// Note that unlike [Conditional], this will be determined by the presence of the symbol in your assembly, not in your caller's assembly.
		///#if !ShowDebugString
		///			[Conditional("FALSE")]
		///		#endif
		///	before optimization, we might analyze
		/// </remarks>
		Optimize
			,
		/// <summary>
		/// transpile or justInTime-compiling, convert code into another computer-structure such as 64bit/cpu/os/computer
		/// </summary>
		/// On Windows, .exe files and .dll files are quite identical. Native .exe and .dll files contain native code (the same stuff the processor executes), so there's no need to translate. Managed .exe and .dll files contain .NET bytecode which is first JIT compiled (translated into native code).
		/// <remarks>
		/// code generation
		/// </remarks>
		Transpile
			,
		/// <summary>
		/// before and during run, loader will load dynamic library such as dll.
		/// vs <seealso cref="nameof(Link)"/>: load is dynamic, link is static
		/// </summary>
		/// <remarks>
		/// assembler
		/// </remarks>
		Load


			,
		/// <summary>
		/// with runtime enviroment, the semantic is revealed/exphibited/embodied. Running will be interactive UI/GUI. So each run may be different.
		/// This might be run in debug mode to debug, or in test mode to test with preset input/output
		/// 
		/// </summary>
		/// <remarks>
		/// this might be moved into nilnul.App
		/// computer specific optimization. Jit compiling. 
		/// </remarks>
		Run
			,


		/// <summary>
		/// log, trace, profiler, metric, usage, diagnoze, analytic
		/// </summary>
		/// <remarks>
		/// this might be taken out of the realm of lang, into the realm of dev/app
		/// </remarks>

		Monitor
	}
}
