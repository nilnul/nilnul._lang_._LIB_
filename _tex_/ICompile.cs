using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///  
/// </summary>
namespace nilnul.lang
{
	/*
	  compile is from one lang(usually txtual such as c#) to machine code( such as clr msil); while parser construct a tree from a linear objects
		without compileing, we can interpret the parsed result.
	 */
	
	/// <summary>
	/// from txt to lang struct, using multiphase processing.
	/// some (generally initial) phases are from linear struct to linear struct, with the ending structs are not sharing any chars. Eg: first phase would be chars to words.
	/// str of char --> struct of objects
	/// </summary>
	/// <remarks>
	/// or you can interpret, rather than compile the src code into machine code.
	/// In interpreting languages such as Javascript, the statements can be executed as each statement is parsed.
	/// parse is subsequent to syntax, which in turn is prior of a lang; compile is subsequent to lang.
	/// </remarks>
	interface ICompile
	{
		/*
		Preprocessor:
			convert escaped to char
		Scan:
			from linear objects to linear objects, and resulted objects are not intersected (sharing no chars)
		Lex:
			from a segment of txt to object
			used in Scan
		Parse:
			linear objects to tree ( such as expression or sentence)
		Compile:
			Compiler has other components like semantic analyzer(for semantic check), Code generator(generates assembly code equivalent semantically to original code) and Optimizer(optimized the code).
			Or you can not translate into native code, but interpret the code.
		A parser is considered as the second phase of a compiler. A lexer, which is the first phase in a compiler, produces a stream of tokens that is given as input to the parser. Parser shall take the tokens, and then produce a parse tree, which shall be used in further phases in compilation.

			Lexing, which converts some form of input to a token stream.
			Parsing, which converts the token stream into an abstract syntax tree (AST).
			Compiling, which converts the AST into a set of executable instructions (native code, byte code, etc).




		 */

		/*A compiler is often made up of several components, one of which is a parser. A common set of components in a compiler is:

Lexer - break the program up into words.
Parser - check that the syntax of the sentences are correct.
Semantic Analysis - check that the sentences make sense.
Optimizer - edit the sentences for brevity.
Code generator - output something with equivalent semantic meaning using another vocabulary.*/

		/*
		So start with a raw string like this:

let x = 0
while x < 10
    print x
    x := x + 1
A lexer is going to convert it into a token stream, probably something like this:

[LET; String("x"); EQ; Int(0); NEWLINE; WHILE; String("x");
 LT; VAL(10); ... ]
The parser will convert the stream into a more meaningful data structure, your abstract syntax tree:

// AST definition
type expr =
    | Block of expr list
    | Assign of string * expr
    | While of expr * expr
    | Call of string * expr list
    | Add of expr * expr
    | Var of string
    | Int of int

// AST instance created from token stream
Block
    [
        Assign("x", Int(10));
        While
        (
            LessThan(Var("x"), Int(10)),
            Block
                [
                    Call("print", [Var("x")]);
                    Assign("x", Add(Var("x"), Int(1)));
                ]
        );
    ]
Once you have an AST, you can do whatever it wants with it:

You convert the AST to native code (compiling).
or you could interpret the AST on the fly, which you might do with a dynamic programming language or a templating engine.
or you could iterate the AST to make a syntax highlighter.
or you could walk the AST and output equivalent code in another language.
or you could look for all instances of Var("x") and replace them with Var("y") similar to a code refactor tool). 
		 */
	}
}
