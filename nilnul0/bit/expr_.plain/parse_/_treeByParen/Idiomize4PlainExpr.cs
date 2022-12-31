using nilnul.bit.expr_.plain.parse_._treeByParen._idiomize._lex.token_;
using nilnul.bit.expr_.plain.parse_._treeByParen._idiomize_;
using nilnul.bit.expr_.plain.parse_._treeByParen._idiomize_._alternate.nub_.arg_;
using nilnul.lang.eg.logic._walk.nub;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.bit.expr_.plain.parse_._treeByParen
{

	/// <summary>
	/// for tokens to a well combined, binary op connected expr.
	/// </summary>
	public class Idiomize4PlainExpr
	{


		private _idiomize._lex.token.stream_.FroStr _tokensInput;

		public _idiomize._lex.token.stream_.FroStr tokensInput
		{
			get { return _tokensInput; }
			set { _tokensInput = value; }
		}


		//private _walk.staple.Str _output;

		//public _walk.staple.Str output
		//{
		//	get { return _output; }
		//	set { _output = value; }
		//}

		private _idiomize._lex.TokenI _currentToken;

		public _idiomize._lex.TokenI currentToken
		{
			get { return _currentToken; }
			set { _currentToken = value; }
		}

		public class ParseResult
		{
			private Alternate _path;

			public Alternate path
			{
				get { return _path; }
				set { _path = value; }
			}

			private ParseException _exception;

			public ParseException exception
			{
				get { return _exception; }
				set { _exception = value; }
			}
			public ParseResult(Alternate path, ParseException exception)
			{
				_path = path;
				_exception = exception;
			}

			public override string ToString()
			{
				if (_exception == null)
				{
					return _path.ToString();
				}
				else
				{
					return _path.ToString() + "\r\n" + _exception.Message;
				}



			}

			public  _idiomize_.alter.vow_.wellFormed.Ed getFormula()
			{
				if (noError)
				{
					return new  _idiomize_.alter.vow_.wellFormed.Ed(_path);
				}
				else
				{
					throw new Exception("formula cannot be formed due to error ");
				}
			}

			public bool noError
			{
				get
				{
					return _exception == null || _exception.Message == "";
				}
			}
			public bool hasError
			{
				get
				{
					return !noError;
				}
			}

		}

		public ParseResult parse(_idiomize._lex.token.str_.List tokens)
		{
			_tokensInput = new _idiomize._lex.token.stream_.FroStr(tokens);

			//read the first arg

			readNext2current();
			Alternate output = new Alternate();


			try
			{
				output = parseDuoChain();

			}
			catch (ParseException e)
			{

				return new ParseResult(output, e);

			}


			//readNext2current();


			if (_currentToken != null)
			{

				return new ParseResult(output, new ParseException(
					"expecting a duoOp to lengthen formula or the end of tokens"

					));



			}

			return new ParseResult(output, null);

		}



		//public void run()
		//{
		//	//read the first arg

		//	readNext2current();

		//	var output=parseDuoChain();

		//	readNext2current();


		//	if (_currentToken != null)
		//	{

		//		err("expecting the end of tokens");
		//		return;
		//	}

		////	parseHeaded();
		//}


		public void readNext2current()
		{
			_currentToken = _tokensInput.next();

		}



		/// <summary>
		/// current is left paren. 
		/// </summary>
		/// <returns></returns>
		private ParenedArg parseParen()
		{

			var output = parseDuoChain();

			if (_currentToken is RightParen)
			{
				readNext2current();
				return new ParenedArg(new _idiomize_.alter.vow_.wellFormed.Ed(output));
			}
			else
			{
				err("expecting a right paren");
				throw new Exception();
			}


		}

		//_duoChain.SimptonI parseSimpton() {



		//}

		_idiomize_._alternate.nub_.ArgI parseDuoArg()
		{

			_idiomize_._alternate.nub_.ArgI r;

			if (_currentToken is _idiomize._lex.token_.AtomicI)
			{
				r = _idiomize_._alternate.nub_.arg_.AtomA.Create(_currentToken as _idiomize._lex.token_.AtomicI);

				readNext2current();

				return r;
			}

			else if (_currentToken is _idiomize._lex.token_.Not)
			{
				readNext2current();

				return parseMonoOp_no_arg();
			}

			else if (_currentToken is _idiomize._lex.token_.LeftParen)
			{
				readNext2current();

				return parseParen();
			}

			else
			{
				//err("expecting a term");

				throw new ParseException("expecting a term");
			}





		}


		/// <summary>
		/// parse as long as possible a duoChain.
		/// </summary>
		/// <returns></returns>
		private _idiomize_.Alternate parseDuoChain()
		{
			var duoChain = new _idiomize_.Alternate();
			duoChain.add(parseDuoArg());
			if (_currentToken is _idiomize._lex.token_.DuoOpI)
			{
				duoChain.add(_currentToken as _idiomize._lex.token_.DuoOpI);
				readNext2current();
				duoChain.add(
					parseDuoChain()
				);
				return duoChain;
			}
			else
			{
				return duoChain;
			}
		}

		/// <summary>
		/// parse as long as possible a duoChain.
		/// </summary>
		/// <returns></returns>
		private _idiomize_.alter.vow_.wellFormed.Ed parseFormula()
		{
			var duoChain = new _idiomize_.Alternate();
			duoChain.add(parseDuoArg());
			if (_currentToken is _idiomize._lex.token_.DuoOpI)
			{
				duoChain.add(_currentToken as _idiomize._lex.token_.DuoOpI);
				readNext2current();
				duoChain.add(
					parseDuoChain()
				);
				return new _idiomize_.alter.vow_.wellFormed.Ed(duoChain);
			}
			else
			{
				return new _idiomize_.alter.vow_.wellFormed.Ed(duoChain);
			}
		}

		/// <summary>
		/// parse as long as poosible for the noArg expr
		/// </summary>
		/// <returns></returns>

		private NotExpr parseMonoOp_no_arg()
		{
			//readNext2current();

			if (_currentToken is _idiomize._lex.token_.AtomicI)
			{
				var r = new NotExpr(_currentToken as _idiomize._lex.token_.AtomicI);
				readNext2current();
				return r;
			}

			if (_currentToken is _idiomize._lex.token_.Not)
			{
				readNext2current();

				return new NotExpr(
						parseMonoOp_no_arg()

				);

			}
			else if (_currentToken is _idiomize._lex.token_.LeftParen)
			{
				readNext2current();

				return new NotExpr(
					parseParen()
				);
			}
			else
			{
				throw new ParseException("expecting an atom, notExpr, or paren expr as not arg");
			}




			//throw new NotImplementedException();
		}



		private string _errMsg;

		public string errMsg
		{
			get { return _errMsg; }
			set { _errMsg = value; }
		}


		public void err(string msg)
		{


			_errMsg = msg;
			throw new ParseException(msg);
		}


		[Serializable]
		public class ParseException : Exception
		{
			public ParseException() { }
			public ParseException(string message) : base(message) { }
			public ParseException(string message, Exception inner) : base(message, inner) { }
			protected ParseException(
			  System.Runtime.Serialization.SerializationInfo info,
			  System.Runtime.Serialization.StreamingContext context) : base(info, context)
			{ }
		}



	}
}


