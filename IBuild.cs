namespace nilnul.lang
{
	/// <summary>
	/// as shown in Visual Studio properties tab for file, the build action can be either compile, or content, or resource, or other. It's constructing by conglomerating a collection of things;
	/// </summary>
	/// alias:
	///		compile
	///			,from syntax to semantic;
	///			, from source|human code to machine code
	///			,
	///		一般情况下解释型语言逻辑基本上都是代码 词法分析 句法分析 中间代码 编译 执行
	interface IBuild { }
}
