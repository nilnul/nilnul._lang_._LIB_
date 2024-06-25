using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang._syntax.grammar_._preproc
{
	///人脑在思考问题的时候，是存在大量的关于“意图”的信息的，而转变成代码之后，这部分“意图”的信息就丢失了，所以，编码是一个“有损”的转换过程，当其他程序员接受这部分代码时，实际上做的事情是根据代码“反向推断”出原作者的“意图”，这个从代码“复原”原作者“意图”的过程非常取决于第二个程序员的能力，如果后者能力比较差，那么大部分的“意图”都会丢失，而且是永久性地丢失。
	///令人遗憾的是，这种“意图”只能以文档和注释的方式存在，代码能用来“实现”“意图”，但无法“表达”“意图”。
	/// <summary>
	/// like a meta language, which is more close to the mechanism of human thinking|mind.
	/// </summary>
	/// alias:
	///		comment
	///		remark
	///		note
	internal class Comment
	{
	}
}
