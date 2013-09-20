#region License
// Copyright (c) 2013 Michael Upton
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

using System;
using System.Net;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.XPath;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using System.Numerics;

namespace StormOnDemandAPI
{
	public enum EncodeType
	{
		JSON,
		XML,
		YAML }
	;

	public class APIHandler
	{
		/// <summary>
		/// The version.
		/// </summary>
		public static string Version = "v1";

		/// <summary>
		/// The environment.
		/// </summary>
		public static string Environment = "https://api.stormondemand.com/";

		/// <summary>
		/// Post the specified decode, method, parameters and encoding.
		/// </summary>
		/// <param name='decode'>
		/// Decode.
		/// </param>
		/// <param name='method'>
		/// Method.
		/// </param>
		/// <param name='parameters'>
		/// Parameters.
		/// </param>
		/// <param name='encoding'>
		/// Encoding.
		/// </param>
		/// <typeparam name='T'>
		/// The 1st type parameter.
		/// </typeparam>
		private static T Post<T> (Func<string, T> decode, string method, string parameters, EncodeType encoding = EncodeType.JSON)
		{
			// Use this to ignore IDE cert warnings
			ServicePointManager.ServerCertificateValidationCallback = ( se, cert, chain, sslerror ) => { return true; };

			WebRequest _webRequest;
			WebResponse _webResponse;

			T _response = default( T );
			string _url;
			// Builds post url to api
			_url = string.Format ("{0}{1}{2}",APIHandler.Environment, APIHandler.Version, method);

			if (encoding == EncodeType.XML && !_url.EndsWith (".xml"))
				_url += ".xml";
			//Setup web request
			_webRequest = WebRequest.Create (_url);

			_webRequest.ContentType = "application/" + encoding.ToString ().ToLower ();
			_webRequest.Method = "POST";
			// Set API auth information
			_webRequest.Credentials = Auth.Credentials;
			byte[] buffer = Encoding.GetEncoding ("UTF-8").GetBytes (parameters != null ? parameters : string.Empty);

			try {
			//Wrap in using statments to implement IDisposable
			using (Stream stream = _webRequest.GetRequestStream())
				stream.Write (buffer, 0, buffer.Length);
				using (_webResponse = _webRequest.GetResponse()) {
					using (Stream stream = _webResponse.GetResponseStream()) {
						using (StreamReader reader = new StreamReader( stream )) {
							string responseStr = reader.ReadToEnd ();

							if (decode != null)
								_response = decode (responseStr);

							return _response;
						}
					}
				}
			} catch (WebException ex) {
				//Catch Web errors
				if (ex.Status == WebExceptionStatus.ProtocolError && ex.Response != null) {
					var resp = (HttpWebResponse)ex.Response;
					if (resp.StatusCode == HttpStatusCode.NotFound) {
						// 404 Error
						return decode ("404 error");
					} else if (resp.StatusCode == HttpStatusCode.BadRequest) {
						// 400 Error
						return _response = decode ("400 Error");
					}
				}
					// Return unhandled error
				return _response = decode (string.Format ("{0} Error", ex.Status));
			}
		}

		/// <summary>
		/// Post the specified method, parameters and encoding.
		/// </summary>
		/// <param name='method'>
		/// Method.
		/// </param>
		/// <param name='parameters'>
		/// Parameters.
		/// </param>
		/// <param name='encoding'>
		/// Encoding.
		/// </param>
		public static string Post (string method, object parameters , EncodeType encoding = EncodeType.JSON)
		{
			string pars = parameters != null ? JsonConvert.SerializeObject (parameters) : string.Empty;

			// Handle API post based on encoding type
			switch (encoding) {
			case EncodeType.JSON: 
				{					
					Func<string, string> decode = responseStr => {
						return (responseStr); };

					return Post<string> (decode, method, pars, EncodeType.JSON);
				}

			case EncodeType.XML:
				{
					Func<string, string> decode = responseStr =>
					{
						//Clean the XML sheet of any invalid elements as per the ISO standard
						return Regex.Replace (responseStr, @"<(/?)([0-9]*)[$>]", String.Format ("<{0}zone_{1}>", "$1", "$2"));
					};

					return Post<string> (decode, method, pars, EncodeType.XML);
				}
			case EncodeType.YAML: 
				{
					return "YAML not implemented yet";
				}

			default:
				return "Unrecognized encoding type";
			}
		}
		/// <summary>
		/// Reads the element value.
		/// </summary>
		/// <returns>
		/// The element value.
		/// </returns>
		/// <param name='nav'>
		/// Nav.
		/// </param>
		/// <param name='elementName'>
		/// Element name.
		/// </param>
		public static string ReadElementValue (XPathNavigator nav, string elementName)
		{
			XPathNodeIterator element = nav.Select (elementName);

			return element != null && element.MoveNext () ? element.Current.Value : String.Empty;
		} 
	}
}