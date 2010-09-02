// <copyright file="JsonReaderTest.cs" company="Thuzi, LLC">Microsoft Public License (Ms-PL)</copyright>
using System;
using System.IO;
using Facebook.Utilities;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Facebook.Utilities
{
    /// <summary>This class contains parameterized unit tests for JsonReader</summary>
    [PexClass(typeof(JsonReader))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class JsonReaderTest
    {
        /// <summary>Test stub for .ctor(String)</summary>
        [PexMethod]
        internal JsonReader Constructor(string jsonText)
        {
            JsonReader target = new JsonReader(jsonText);
            return target;
            // TODO: add assertions to method JsonReaderTest.Constructor(String)
        }

        /// <summary>Test stub for .ctor(TextReader)</summary>
        [PexMethod]
        internal JsonReader Constructor01(TextReader reader)
        {
            JsonReader target = new JsonReader(reader);
            return target;
            // TODO: add assertions to method JsonReaderTest.Constructor01(TextReader)
        }

        /// <summary>Test stub for ReadValue()</summary>
        [PexMethod]
        internal object ReadValue([PexAssumeUnderTest]JsonReader target)
        {
            object result = target.ReadValue();
            return result;
            // TODO: add assertions to method JsonReaderTest.ReadValue(JsonReader)
        }
    }
}
