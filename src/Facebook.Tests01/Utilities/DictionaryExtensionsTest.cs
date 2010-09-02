// <copyright file="DictionaryExtensionsTest.cs" company="Thuzi, LLC">Microsoft Public License (Ms-PL)</copyright>
using System;
using System.Collections.Generic;
using Facebook.Utilities;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Facebook.Utilities
{
    /// <summary>This class contains parameterized unit tests for DictionaryExtensions</summary>
    [PexClass(typeof(DictionaryExtensions))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class DictionaryExtensionsTest
    {
        /// <summary>Test stub for Merge(IDictionary`2&lt;String,Object&gt;, IDictionary`2&lt;String,Object&gt;)</summary>
        [PexMethod]
        internal IDictionary<string, object> Merge(IDictionary<string, object> first, IDictionary<string, object> second)
        {
            IDictionary<string, object> result = DictionaryExtensions.Merge(first, second);
            return result;
            // TODO: add assertions to method DictionaryExtensionsTest.Merge(IDictionary`2<String,Object>, IDictionary`2<String,Object>)
        }
    }
}
