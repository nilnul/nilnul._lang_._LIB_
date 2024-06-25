namespace nilnul.lang.run_
{
	/// <summary>
	/// run the compiled machine code;
	/// if the runtime is dotnet or java, then the compiled code is not machine code, and it needs compiling again, just in time or in advance, before being run on machine;.
	/// </summary>
	/// <remarks>
	/// compiled differently on different Os;
	/// dynamically compiled can be cached;
	/// </remarks>
    interface ICompile { }
}
