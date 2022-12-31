using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.plain.parse_._treeByParen._idiomize
{
	/// <summary>
	/// chars to tokens
	/// </summary>
	public class Lex
	{

		public char? current;


		public nilnul.character.stream.StrAsStream readerStream;
	//	public List<_lex.Symbol> tokens = new List<_lex.Symbol>();
		public _lex.token.str_.List  tokens = new _lex.token.str_.List();



		public string tokensToTxt()
		{
			return _lex.token.str.ToTxtX._ToTxt(tokens);
		}


		public string parsedResult()
		{

			if (errorMsg == "")
			{
				return tokensToTxt();
			}
			else
			{
				return tokensToTxt() + "\r\n" + errorMsg;
			}

		}

		public void run(string s) {
			readerStream = new character.stream.StrAsStream(s);

			tokens = new  _lex.token.str_.List();
			errorMsg = "";

			parseTail_notRead();


		}

	

		public void readNext_intoCurrent()
		{
			current = readerStream.next();
		}



		public void seek2makeCurrentNoWhite()
		{
			while ( nilnul.character.be.White.Eval(current) )
			{
				readNext_intoCurrent();
			}
		}

	

		public void parseHeaded_reduceCurrentAsSymbol(_lex.TokenI symbol)
		{

			tokens.Add(symbol);
			parseTail_notRead();

		}

		public void parseHeaded_ruleLe()
		{
			readNext_intoCurrent();
			if (current == '=')
			{
				parseHeaded_reduceCurrentAsSymbol(new _lex.token_.Le());
			}
			else
			{
				error("= is expected to form <=");
			}

		}


		public void parseHeaded_ruleVar()
		{

			var symbol = new _lex.token_.Var1();
			symbol._append(current);	// { name = current1.ToString() };

			readNext_intoCurrent();

			while (isId( current ))
			{
				symbol.append(current.Value);
				readNext_intoCurrent();
			}

			tokens.Add(symbol);

			parseHeaded_currentFilled();
			

		}


		

		public void parseHeaded_currentSignificand()
		{

			if (current == '(')
			{
				parseHeaded_reduceCurrentAsSymbol(new _lex.token_.LeftParen());


			}


			else if (current == ')')
			{
				parseHeaded_reduceCurrentAsSymbol(new _lex.token_.RightParen());

			}

			else if (current == '0')
			{

				parseHeaded_reduceCurrentAsSymbol(new _lex.token_.Zero());

				

			}
			else if (current == '1')
			{
				parseHeaded_reduceCurrentAsSymbol(new _lex.token_.One());


			}
			else if (current == '!')
			{
				parseHeaded_reduceCurrentAsSymbol(new _lex.token_.Not()
					);

			}
			else if (current == '|')
			{

				parseHeaded_reduceCurrentAsSymbol(new _lex.token_.Or());
			}
			else if (current == '&')
			{
				parseHeaded_reduceCurrentAsSymbol(new _lex.token_.And());
			}

			else if (current == '~')
			{
				parseHeaded_reduceCurrentAsSymbol(new _lex.token_.Eq());
			}

			else if (current == '<')
			{
				parseHeaded_ruleLe();
			}

			else if (current >= 'a' && current <= 'z')
			{

				parseHeaded_ruleVar();

			}
			else
			{
				error("expected the begining of a token.");
				return;
			}

		}
		public void parseHeaded_currentNoWhite()
		{

			if (current == null)
			{
				return;
			}
			else
			{
				parseHeaded_currentSignificand();

			}
		}

		public void parseTail_notRead() {
			readNext_intoCurrent();
			parseHeaded_currentFilled();
		}

		public void parseHeaded_currentFilled()
		{
			seek2makeCurrentNoWhite();

			parseHeaded_currentNoWhite();

		}

		
		public bool isId(char? current)
		{
			return current!=null && ( current >= 'a' && current <= 'z');
		}

		
		public bool isId()
		{
			return isId(current);
		}

		public string errorMsg = "";

		public void error(string msg)
		{
			errorMsg = msg;
			return;
			throw new Exception(msg);

		}
	}
}
