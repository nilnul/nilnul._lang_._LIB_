namespace nilnul.lang.tier_
{
	/// <summary>
	/// a sentence, which can be:
	///		primitive sentence such as ";" ended in C#
	///			empty
	///		block such as "{}" in C#
	///	;
	///	excluding:
	///		comment, which is a lex structure, and regarded as space to the effect.
	/// </summary>
	///	<remarks>
	///	sentence is the basic|minimal unit for communicaiton; eg: in chat, we use sentences;
	///	for more formal communcation, we need <see cref="sentence.paragraph.IDiscourse"/> such as essay|prose|treatise as the unit for communication.
	///sentence is made of clauses; clause, as a pattern, is made of expressions and templates(or multinary relations);
	/// </remarks>	
	///
	/// 
	/// comprises many clauses.
	/// each clause comprises 
	/// alias:
	///		statment
	///		sentence
	///		clause
	///		claus
	///		clauz
	///	vs:
	///		locution:
	///			the unit less than sentence is lexeme.locution, which is data,conveyed or stroed in database, and is not lang,nor a unit for communication.
	///
	///		locution, which is state of data, whileas this is the transition of data, represented as data.Co
	///
	/// vs: line
	///		a sentence can span multiple lines; and a line can contain multiple sentences;
	///		sentences are separated with an anchor(0wide assertion): (?&lt=;) or (?&lt})

	interface ISentence { }
}
