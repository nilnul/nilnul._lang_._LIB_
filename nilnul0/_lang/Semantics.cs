using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._lang_
{

	/*语义分析（semantic analysis） 
	 * 
	 code generation.

　　语义分析是编译过程的一个逻辑阶段. 语义分析的任务是对结构上正确的源程序进行上下文有关性质的审查, 进行类型审查.例如一个C程序片断:
　　int arr[2],b;
　　b = arr * 10; 
　　源程序的结构是正确的. 
　　语义分析将审查类型并报告错误:不能在表达式中使用一个数组变量,赋值语句的右端和左端的类型不匹配.
  样例4：
输入：
1 struct Complex
2 {
3 float real, image;
4 };
5 int main()
6 {
7 struct Complex x;
8 y.image = 3.5;
9 }
输出：
这个程序虽然包含了语义错误（即使用了未定义的变量y），但不存在任何词法或语法错
误，因此你的程序不能报错而是要输出相应的语法树结点信息。*/

	/// <summary>
	/// with intention, human invented syntax to express the intentions.
	/// later running  a lang (under an environ). interpretation of a lang
	/// </summary>
	public interface SemanticI
	{
	}
}
