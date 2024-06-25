using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._lang_
{
	/*Another point of interest is the order of the token declaration. The earlier a token is defined, the higher is the precedence if a certain input can be matched by two or more tokens. This means that using the tokens command to define keywords will match those keywords instead a more general ID rule. The following code snippet provides an example:*/
	/*
　　文法是用于描述语言的语法结构的形式规则。文法G定义为四元组(，，，)。其中为非终结符号(或语法实体，或变量)集；为终结符号集；为产生式(也称规则)的集合；产生式(规则)是形如或 a ::=b 的(a , b)有序对,其中(∪)且至少含有一个非终结符，而(∪)。，和是非空有穷集。称作识别符号或开始符号，它是一个非终结符，至少要在一条规则中作为左部出现。 
　　一个文法的例子: G=(={A，R},={0,1} ，={A?0R，A?01,R?A1},=A) 
文法分类（A hierarchy of Grammars） 
　　著名语言学家Noam Chomsky定义了四类文法和四种形式语言类，文法的四种类型分别是0型、1型、2型和3型。几类文法的差别在于对产生式施加不同的限制，分别是： 
　　0型文法(短语结构文法)(phrase structure grammars)： 
　　设G=(，，，)，如果它的每个产生式是这样一种结构： (∪)　　且至少含有一个非终结符，而(∪)，则G是一个0型文法。 
　　1型文法（上下文有关文法）(context-sensitive grammars)： 
　　设G=(，，，)为一文法，若中的每一个产生式均满足|，仅仅　　除外，则文法G是1型或上下文有关的。 
　　2型文法（上下文无关文法）(context-free grammars)： 
　　设G=(，，，)，若P中的每一个产生式满足：是一非终结符，(∪)　　则此文法称为2型的或上下文无关的。 
　　3型文法（正规文法）(regular grammars)： 
　　设G=(，，，)，若中的每一个产生式的形式都是A→aB或A→a，其中A和B都是非终结，a是终结符，则G是3型文法或正规文法。 
　　0型文法产生的语言称为0型语言。 
　　1型文法产生的语言称为1型语言，也称作上下文有关语言。 
　　2型文法产生的语言称为2型语言，也称作上下文无关语言。 
　　3型文法产生的语言称为3型语言，也称作正规语言。
		 */

	/// <summary>
	///  文法（Grammars）is the up2date join of syntax and lex, whileas syntax(句法) is grammar-lex. Note syntax is dependent on lex. in other words: grammar including syntax and lex; syntax not include lex; syntax is dependent on lex.
	/// </summary>
	public interface GrammarI
	{
	}
}
