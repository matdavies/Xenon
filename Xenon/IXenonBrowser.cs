﻿using System;
using System.Collections.Generic;

namespace Xenon
{
	public interface IXenonBrowser
	{
		string Url { get; }
		string PageSource { get; }
		IEnumerable<IXenonElement> FindElementsByCssSelector( string cssSelector );
		IEnumerable<IXenonElement> FindElementsByXPath( string xpath );
        void GoToUrl( string url );
		XenonAssertion RunAssertion( AssertionFunc assertion );
		void Quit();
	}
}