using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._lang.syntax
{
	/*
Compiling is the act of turning source code into object code.
Linking is the act of combining object code with libraries into a raw executable.
Building is the sequence composed of compiling and linking, with possibly other tasks such as installer creation.
Many compilers handle the linking step automatically after compiling source code.
From wikipedia:
In the field of computer software, the term software build refers either to the process of converting source code files into standalone software artifact(s) that can be run on a computer, or the result of doing so. One of the most important steps of a software build is the compilation process where source code files are converted into executable code.
While for simple programs the process consists of a single file being compiled, for complex software the source code may consist of many files and may be combined in different ways to produce many different versions.
From my experience I would say that "compiling" refers to the conversion of one or several human-readable source files to byte code (object files in C) while "building" denominates the whole process of compiling, linking and whatever else needs to be done of an entire package or project.
 */

	/*
	Build is a compiled version of a program. 
Compile means, convert (a program) into a machine-code or lower-level form in which the program can be executed. 
In Java: Build is a Life cycle contains sequence of named phases. 
for example: maven it has three build life cycles, the following one is default build life cycle.
◾validate - validate the project is correct and all necessary information is available
◾compile - compile the source code of the project
◾test - test the compiled source code using a suitable unit testing framework. These tests should not require the code be packaged or deployed
◾package - take the compiled code and package it in its distributable format, such as a JAR.
◾integration-test - process and deploy the package if necessary into an environment where integration tests can be run
◾verify - run any checks to verify the package is valid and meets quality criteria
◾install - install the package into the local repository, for use as a dependency in other projects locally
◾deploy - done in an integration or release environment, copies the final package to the remote repository for sharing with other developers and projects.
比如说打包签名是build不是compile

*/
	public interface IBuild
	{
	}
}
