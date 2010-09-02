// <copyright file="ExceptionHelperTest.cs" company="Thuzi, LLC">Microsoft Public License (Ms-PL)</copyright>
using System;
using System.Net;
using Facebook;
using Facebook.Utilities;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Facebook.Utilities
{
    /// <summary>This class contains parameterized unit tests for ExceptionHelper</summary>
    [PexClass(typeof(ExceptionHelper))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ExceptionHelperTest
    {
        /// <summary>Test stub for GetGraphException(WebException)</summary>
        [PexMethod]
        internal FacebookApiException GetGraphException(WebException ex)
        {
            FacebookApiException result = ExceptionHelper.GetGraphException(ex);
            return result;
            // TODO: add assertions to method ExceptionHelperTest.GetGraphException(WebException)
        }

        /// <summary>Test stub for GetRestException(Object)</summary>
        [PexMethod]
        internal FacebookApiException GetRestException(object result)
        {
            FacebookApiException result01 = ExceptionHelper.GetRestException(result);
            return result01;
            // TODO: add assertions to method ExceptionHelperTest.GetRestException(Object)
        }
    }
}
