using nilnul.lang.eg.logic._walk.nub;
using nilnul.lang.eg.logic._walk.nub.arg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang.eg.logic
{
	/// <summary>
	/// parse the str of tokens into DuoArgs, tweened by DuoOps。
	/// The precedence and associativity of ops are not considered.
	/// </summary>
	/// 
	[Obsolete(nameof(nilnul.lang_.bitExpr.compiler_._binaryTree_))]
	public class Walk
	{
		private _lex.token.Stream _tokensInput;

		public _lex.token.Stream tokensInput
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

		private _lex.TokenI _currentToken;

		public _lex.TokenI currentToken
		{
			get { return _currentToken; }
			set { _currentToken = value; }
		}

		public class ParseResult
		{
			private _walk.Alternate _path;

			public _walk.Alternate path
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
			public ParseResult(_walk.Alternate path, ParseException exception)
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

			public _walk.alter.be.Formula.Asserted getFormula() {
				if (noError)
				{
					return new _walk.alter.be.Formula.Asserted(_path);
				}
				else
				{
					throw new Exception("formula cannot be formed duoe to error ");
				}
			}

			public bool noError {
				get {
					return _exception == null || _exception.Message == "";
				}
			}
			public bool hasError {
				get {
					return !noError;
				}
			}

		}

		public ParseResult parse(_lex.token.str.List tokens)
		{
			_tokensInput = new _lex.token.Stream(tokens);

			//read the first arg

			readNext2current();
			_walk.Alternate output =  new _walk.Alternate();


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
		private _walk.nub.arg.ParenedArg parseParen()
		{

			var output = parseDuoChain();

			if (_currentToken is _lex.token.RightParen)
			{
				readNext2current();
				return new _walk.nub.arg.ParenedArg( new _walk.alter.be.Formula.Asserted( output));
			}
			else
			{
				err("expecting a right paren");
				throw new Exception();
			}


		}

		//_duoChain.SimptonI parseSimpton() {



		//}

		_walk.nub.ArgI parseDuoArg()
		{

			ArgI r;

			if (_currentToken is _lex.token.AtomicI)
			{
				r = AtomA.Create(_currentToken as _lex.token.AtomicI);

				readNext2current();

				return r;
			}

			else if (_currentToken is _lex.token.Not)
			{
				readNext2current();

				return parseMonoOp_no_arg();
			}

			else if (_currentToken is _lex.token.LeftParen)
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
		private _walk.Alternate parseDuoChain()
		{
			var duoChain = new _walk.Alternate();
			duoChain.add(parseDuoArg());
			if (_currentToken is _lex.token.DuoOpI)
			{
				duoChain.add(_currentToken as _lex.token.DuoOpI);
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
		private _walk.alter.be.Formula.Asserted parseFormula()
		{
			var duoChain = new _walk.Alternate();
			duoChain.add(parseDuoArg());
			if (_currentToken is _lex.token.DuoOpI)
			{
				duoChain.add(_currentToken as _lex.token.DuoOpI);
				readNext2current();
				duoChain.add(
					parseDuoChain()
				);
				return new _walk.alter.be.Formula.Asserted( duoChain);
			}
			else
			{
				return new _walk.alter.be.Formula.Asserted( duoChain);
			}
		}

		/// <summary>
		/// parse as long as poosible for the noArg expr
		/// </summary>
		/// <returns></returns>

		private NotExpr parseMonoOp_no_arg()
		{
			//readNext2current();

			if (_currentToken is _lex.token.AtomicI)
			{
				var r= new NotExpr(_currentToken as _lex.token.AtomicI);
				readNext2current();
				return r;
			}

			if (_currentToken is _lex.token.Not)
			{
				readNext2current();

				return new NotExpr(
						parseMonoOp_no_arg()

				);

			}
			else if (_currentToken is _lex.token.LeftParen)
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
