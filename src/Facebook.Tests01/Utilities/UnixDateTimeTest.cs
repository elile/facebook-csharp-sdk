// <copyright file="UnixDateTimeTest.cs" company="Thuzi, LLC">Microsoft Public License (Ms-PL)</copyright>
using System;
using Facebook.Utilities;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Facebook.Utilities
{
    /// <summary>This class contains parameterized unit tests for UnixDateTime</summary>
    [PexClass(typeof(UnixDateTime))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class UnixDateTimeTest
    {
        /// <summary>Test stub for FromUnixTime(String)</summary>
        [PexMethod]
        internal DateTime FromUnixTime(string unixTime)
        {
            DateTime result = UnixDateTime.FromUnixTime(unixTime);
            return result;
            // TODO: add assertions to method UnixDateTimeTest.FromUnixTime(String)
        }

        /// <summary>Test stub for ToUnixDateTime(DateTime)</summary>
        [PexMethod]
        internal string ToUnixDateTime(DateTime dateTime)
        {
            string result = UnixDateTime.ToUnixDateTime(dateTime);
            return result;
            // TODO: add assertions to method UnixDateTimeTest.ToUnixDateTime(DateTime)
        }

        /// <summary>Test stub for ToUnixTime(DateTime)</summary>
        [PexMethod]
        internal string ToUnixTime(DateTime dateTime)
        {
            string result = UnixDateTime.ToUnixTime(dateTime);
            return result;
            // TODO: add assertions to method UnixDateTimeTest.ToUnixTime(DateTime)
        }
    }
}
