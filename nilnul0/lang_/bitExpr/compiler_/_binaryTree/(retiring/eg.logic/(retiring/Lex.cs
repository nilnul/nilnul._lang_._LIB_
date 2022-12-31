using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang.eg.logic
{
	[Obsolete()]
	public class Lex
	{

		public char current;
		public string input;
		public CharEnumerator reader;
		public List<_lex.Symbol> tokens = new List<_lex.Symbol>();

		public string tokensToTxt()
		{
			return _lex.token.str.ToTxtX._ToTxt(tokens);
		}
		public string result() {

			if (errorMsg=="")
			{
				return tokensToTxt();
			}
			else
			{
				return tokensToTxt()+ "\r\n"+errorMsg;
			}

		}

		public void run() {

			reader = input.GetEnumerator();
			tokens = new List<_lex.Symbol>();
			errorMsg = "";
			
			if (readNext()) toTokens();
			else
			{
				return;
			}
		}
		public Lex()
		{

		}
		public bool readNext()
		{

			if (reader.MoveNext())
			{

				current = reader.Current;
				return true;

			}
			return false;


		}
		public void toTokens()
		{


			while (current == ' ' || current == '\t' || current == '\r' || current == '\n')
			{
				if (!readNext()) return;
			}

			if (current == '(')
			{
				tokens.Add(new _lex.LeftParen());

				if (!readNext()) return;

				toTokens();

			}
			else if (current == ')')
			{
				tokens.Add(new _lex.RightParen());
				if (!readNext()) return;

				toTokens();

			}
			else if (current == '0')
			{
				beginNext(new _lex.Zero());

			}
			else if (current == '1')
			{
				beginNext(new _lex.One());
			}
			else if (current == '!')
			{
				beginNext(new _lex.Not());
			}
			else if (current == '|')
			{
				beginNext(new _lex.Or());
			}
			else if (current == '&')
			{
				beginNext(new _lex.And());
			}

			else if (current == '~')
			{
				beginNext(new _lex.Eq());
			}

			else if (current == '<')
			{
				if (readNext())
				{
					if (current == '=')
					{
						beginNext(new _lex.Le());

					}
					else
					{
						error("= is expected to form <=");
					}
				}
				else
				{
					error("= is expected to form <=");
					return;

				}

			}

			else if (current >= 'a' && current <= 'z')
			{

				var symbol = new _lex.Var() { name = current.ToString() };
				if (readNext())
				{
					while (isId())
					{
						symbol.append(current);
						if (readNext()) { continue; }
						else
						{
							tokens.Add(symbol);
							return;
						}

					}


				}
				else
				{
					tokens.Add(symbol);
					return;
				}


				tokens.Add(symbol);

				toTokens();

			}

			else
			{
				error("expected the bgining of a token.");
				return;
			}

			return;

			throw new NotImplementedException();
		}

		public void beginNext(_lex.Symbol symbol)
		{
			tokens.Add(symbol);
			if (!readNext()) return;
			toTokens();

		}

		public bool isId(char current)
		{
			return current >= 'a' && current <= 'z';
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
