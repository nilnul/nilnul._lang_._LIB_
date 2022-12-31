using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang_
{
	/// <summary>
	/// https://www.ibm.com/support/knowledgecenter/en/SSGMCP_5.3.0/com.ibm.cics.ts.internet.doc/topics/dfhtl_uricomp.html
	/* A URL (Uniform Resource Locator) is a specific type of URI (Universal Resource Identifier). A URL normally locates an existing resource on the Internet. A URL is used when a web client makes a request to a server for a resource.

	This topic is a summary of URLs and URIs.If you need to know more, the concepts of the URI and the URL are defined by the Internet Society and IETF (Internet Engineering Task Force) Request for Comments document RFC 2396, Uniform Resource Identifiers(URI): Generic Syntax(http://www.ietf.org/rfc/rfc2396.txt).


  Briefly, a URI is defined as any character string that identifies a resource.A URL is defined as those URIs that identify a resource by its location or by the means used to access it, rather than by a name or other attribute of the resource.

  A newer form of resource identifier, the IRI (Internationalized Resource Identifier), permits the use of characters and formats that are suitable for national languages other than English.An IRI can be used in place of a URI or URL when the applications involved with the request and response support IRIs.For more information about IRIs, see Internationalized Resource Identifiers(IRIs).*/
	/// </summary>
	public interface UriI
	{
	}
}
