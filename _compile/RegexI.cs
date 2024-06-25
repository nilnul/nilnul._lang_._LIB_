using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._lang._syntax.grammar_
{
	/*一个正则表达式由特定字符串构成，或者由其它正则表达式通过以下三种运算得到：
1) 并运算（Union）：两个正则表达式r和s的并记作r | s，意为r或s都可以被接受。
2) 连接运算（Concatenation）：两个正则表达式r和s的连接记作rs，意为r之后紧跟s才可
以被接受。
3) Kleene闭包（Kleene Closure）：一个正则表达式r的Kleene闭包记作r*，它表示： | r |
rr | rrr | …。
*/

	/**/

	/**/
	/// <summary>
	/// regex is recursively defined:
	///		1) any nilnul.txt.set_.singleton_.Character , where the element is equal to a character.ToString(), can be regex
	///		
	///		2) the join/joinPoly/joinPolyClosure/union/unionPoly/kleen of regex is regex, as the coding in "op_." shows.
	///			2.1) unionPoly ^0 of regex is {}.
	///			2.2) joinPoly ^0 of regex is {""}. Note in {m,n}, m can be 0
	///			2.3) unionPoly ^Inf, is unionPoly ^1. So unionPoly, unlike joinPoly^Inf: kleene, is ommited here.
	///			
	///	So regex expression:"" shall be understood as {""}, as "ab" means {a}join{b}, so "" means join nothing, resulting {""}), not {}
	///
	/// but regex expression operators precedence dictates that  "|" GreaterThan "join". So regex shall better be understood as SumOfProduct cannonical form. So "ab" shall be understood as "|(ab)", and "ab|cd" shall be "|(ab,cd)", and then "" shall be understood as "|()", which is {}.
	///
	/// Note: we can explicitly write out joinPoly^0, but cannot write out unionPoly^0. So among the above alternatives, we shall select the latter: regarding "" as {}.
	///
	/// whileas {""} can be denoted as ".{0}", {} can be denote as "$a^".
	///					in Js new RegExp("").test("") is true; but the result shall be false.
	///
	/// 
	/// </summary>
	/// <seealso cref="nameof(nilnul.set.family.be_._TopoX)"/>
	public interface IRegex:IGrammar
	{
	}

	/*正则表达式处理的是有序符号的匹配问题，换句话说，正则表达式处理的对象是一个接一个地出现的符号，在这个形式系统中，AND的定义就是“连接”， 而你所需要的AND，是另外一种形式系统中的东西，在这个形式系统讨论的对象是无时间次序的逻辑断言。*/

	/*
	用 (a.*b|b.*a) 能得出 a AND b的结果， 但这是有回溯的，匹配不到 a.*b还要再回头找一遍 b.*a
  
真正的【逻辑与】匹配是无回溯的，regex从头到尾扫一遍就知道是不是满足 a AND b，这就是他的诉求。
  
大多数 regex 实现是能做到的
	----------------------------------------

	比如楼主说要同时出现：
1） word
2） ordinal
  
然后, wordinal 应该符合楼主的要求，但你这个匹配不上啊。

	 */
	/*regex没有 差集 运算，所以就没有补集运算，所以就没有 not，所以有 | 但没有你说的and.
  
regex更像一个 拓扑集 而非 域。*/

	public interface RegexI :IRegex
		,
		GrammarI

	{

	}
	/*
	 POSIX standardizes regex, defining a set of metaCharS
	 
	 */
}
