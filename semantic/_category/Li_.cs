using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang.grammar._category
{
	///		语法 grammar
	///			, 言法 is not a common word.
	///			, but in 中文，we use 文； in 英语，日本语，we use 语。
	///			，包括
	///				copora|context
	///				
	///	 <summary>
	/// 		语法 grammar
	/// </summary>
	/// the category of lex, syntax, structure is regarding the semantics of the grammar, not the production rules of the grammar. And due to the complexity of semantics, each category will utilize a grammar that is correspondingly complex.
	/// eg:
	///		for lex,which is intended to represent data, we can simply use Regex;
	///		for syntax, which is intended to represent data transition, we need ContextFree grammar
	///		for structure, which is intended to represent a semantic scope|domain, such as the structure of an xml doc, or the structure of c# type, we need contextSensitive grammar. Such grammar needs beyond production rules, requiring contextSensitive rules or some predicates that might be higher order logic.
	/// 
	internal enum Li_
	{
		/// <summary>
		/// eg:
		///		an app comprises configuration, assemblies, resources, as well as environment, etc.
		/// </summary>
		/// <remarks>
		///Such grammar needs beyond production rules, requiring contextSensitive rules or some predicates that might be higher order logic.
		/// </remarks>
		/// we need linker to statically combine them together, or loader to dynamically call each other.
		/// alias:
		///		suite
		///			,the grammar of the suite is called: architecture, or organism, or synergy, or collaboration, or coordination, or symbiosis, 
		///		software
		///		organism
		///		system
		///		methodical
		///		machinery
		///		mechanism
		///		framework
		///		architecture
		///		architect
		///		ware
		///		body
		///		institution
		///		interaction.

		Suite
,

		///
		///
		/// 
		///				章法|文法|structure|composition(to be composed|compiled)grammar（比如xml|html document, css style sheet, c# type ）
		///	<summary>
		///	intended to represent a semantic scope|domain, such as the structure of an xml doc, or the structure of c# type, we need contextSensitive grammar. Such grammar needs beyond production rules, requiring contextSensitive rules or some predicates that might be higher order logic.
		///	</summary>
		///	<remarks>
		///	often in context sensitive grammar. and it's often enclosed as:
		///		block with "{}" as enclosure
		///			,as type which is a signature with "{}"
		///			,block is an anonymous "{}"
		///		clob which is a monolithic storage.
		///		
		///	eg:
		///		xml doc
		///		js script
		///		css style
		///		c# type
		///		proof
		///		prose, like the answer to a question.
		///			quote, or note
		///		calculation
		///		article
		///		
		///	,which creates a scope.
		///	an applicable|practicle article for reality requirement;
		/// </remarks>
		///	alias:
		///		structure
		///			, "s" is also the initial of scope
		///			, the grammar of scipt is called structure, or organism.
		///		standard
		///		specification
		///		stipulation
		///		style
		///		scope
		///		genre
		///		document
		///		clob
		///		closure
		///		enclosure
		///		manuscript
		///		script
		///		snippet
		///		quote
		///		scrap
		///		
		Script
			,
		///				、句法（syntax)
		///				
		/// <summary>
		/// 				、句法（syntax)
		/// </summary>
		/// <remarks>
		/// often in context free grammar;
		/// denote transition of data to data
		/// </remarks>
		Syntax
		///				
		///				、词法（Lexicology,morphology on morphemes, lexicon, glossary)。
		///<remarks>
		/// often denotes data
		/// </remarks>
		,
		Lexicology

	}
}
