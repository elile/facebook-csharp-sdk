// <copyright file="FacebookConfigurationSectionTest.cs" company="Thuzi, LLC">Microsoft Public License (Ms-PL)</copyright>
using System;
using Facebook;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Facebook
{
    /// <summary>This class contains parameterized unit tests for FacebookConfigurationSection</summary>
    [PexClass(typeof(FacebookConfigurationSection))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class FacebookConfigurationSectionTest
    {
        /// <summary>Test stub for ApiKey</summary>
        [PexMethod]
        public void ApiKeyGetSet(
            [PexAssumeUnderTest]FacebookConfigurationSection target,
            string value
        )
        {
            target.ApiKey = value;
            string result = target.ApiKey;
            PexAssert.AreEqual(value, result);
            // TODO: add assertions to method FacebookConfigurationSectionTest.ApiKeyGetSet(FacebookConfigurationSection, String)
        }

        /// <summary>Test stub for ApiSecret</summary>
        [PexMethod]
        public void ApiSecretGetSet(
            [PexAssumeUnderTest]FacebookConfigurationSection target,
            string value
        )
        {
            target.ApiSecret = value;
            string result = target.ApiSecret;
            PexAssert.AreEqual(value, result);
            // TODO: add assertions to method FacebookConfigurationSectionTest.ApiSecretGetSet(FacebookConfigurationSection, String)
        }

        /// <summary>Test stub for AppId</summary>
        [PexMethod]
        public void AppIdGetSet(
            [PexAssumeUnderTest]FacebookConfigurationSection target,
            string value
        )
        {
            target.AppId = value;
            string result = target.AppId;
            PexAssert.AreEqual(value, result);
            // TODO: add assertions to method FacebookConfigurationSectionTest.AppIdGetSet(FacebookConfigurationSection, String)
        }

        /// <summary>Test stub for BaseDomain</summary>
        [PexMethod]
        public void BaseDomainGetSet(
            [PexAssumeUnderTest]FacebookConfigurationSection target,
            string value
        )
        {
            target.BaseDomain = value;
            string result = target.BaseDomain;
            PexAssert.AreEqual(value, result);
            // TODO: add assertions to method FacebookConfigurationSectionTest.BaseDomainGetSet(FacebookConfigurationSection, String)
        }

        /// <summary>Test stub for CookieSupport</summary>
        [PexMethod]
        public void CookieSupportGetSet(
            [PexAssumeUnderTest]FacebookConfigurationSection target,
            bool value
        )
        {
            target.CookieSupport = value;
            bool result = target.CookieSupport;
            PexAssert.AreEqual(value, result);
            // TODO: add assertions to method FacebookConfigurationSectionTest.CookieSupportGetSet(FacebookConfigurationSection, Boolean)
        }

        /// <summary>Test stub for MaxRetries</summary>
        [PexMethod]
        public void MaxRetriesGetSet(
            [PexAssumeUnderTest]FacebookConfigurationSection target,
            int value
        )
        {
            target.MaxRetries = value;
            int result = target.MaxRetries;
            PexAssert.AreEqual(value, result);
            // TODO: add assertions to method FacebookConfigurationSectionTest.MaxRetriesGetSet(FacebookConfigurationSection, Int32)
        }

        /// <summary>Test stub for RetryDelay</summary>
        [PexMethod]
        public void RetryDelayGetSet(
            [PexAssumeUnderTest]FacebookConfigurationSection target,
            int value
        )
        {
            target.RetryDelay = value;
            int result = target.RetryDelay;
            PexAssert.AreEqual(value, result);
            // TODO: add assertions to method FacebookConfigurationSectionTest.RetryDelayGetSet(FacebookConfigurationSection, Int32)
        }
    }
}
