namespace nilnul.lang._semantic
{
	///编程语言的本质上显然不是数据存哪儿的问题。而且你说的这些也不是存堆还是存栈的原因。真正的原因是：存哪儿都可以，只是一个是效率问题。
	///比如你写一个c，go java实现。你完全可以把变量都存堆上，或者都存栈上但实现起来可能很难很别扭很慢。
	///from:
	///	newsmth.net/nForum/#!article/Programming/213338
	///	,by: chunhui
	///
	/// 运行时支持有没有GC
	/// 
	/// <summary>
	/// 
	/// </summary>
	/// 
	interface IRuntime { }
}
