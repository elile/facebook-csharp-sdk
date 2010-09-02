// <copyright file="FacebookAppBaseTest.cs" company="Thuzi, LLC">Microsoft Public License (Ms-PL)</copyright>
using System;
using System.Collections.Generic;
using Facebook;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Facebook
{
    /// <summary>This class contains parameterized unit tests for FacebookAppBase</summary>
    [PexClass(typeof(FacebookAppBase))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class FacebookAppBaseTest
    {
        /// <summary>Test stub for AccessToken</summary>
        [PexMethod]
        public void AccessTokenGet([PexAssumeNotNull]FacebookAppBase target)
        {
            string result = target.AccessToken;
            // TODO: add assertions to method FacebookAppBaseTest.AccessTokenGet(FacebookAppBase)
        }

        /// <summary>Test stub for Api(IDictionary`2&lt;String,Object&gt;)</summary>
        [PexMethod]
        public object Api(
            [PexAssumeNotNull]FacebookAppBase target,
            IDictionary<string, object> parameters
        )
        {
            object result = target.Api(parameters);
            return result;
            // TODO: add assertions to method FacebookAppBaseTest.Api(FacebookAppBase, IDictionary`2<String,Object>)
        }

        /// <summary>Test stub for Api(String)</summary>
        [PexMethod]
        public object Api01([PexAssumeNotNull]FacebookAppBase target, string path)
        {
            object result = target.Api(path);
            return result;
            // TODO: add assertions to method FacebookAppBaseTest.Api01(FacebookAppBase, String)
        }

        /// <summary>Test stub for Api(String, HttpMethod)</summary>
        [PexMethod]
        public object Api02(
            [PexAssumeNotNull]FacebookAppBase target,
            string path,
            HttpMethod httpMethod
        )
        {
            object result = target.Api(path, httpMethod);
            return result;
            // TODO: add assertions to method FacebookAppBaseTest.Api02(FacebookAppBase, String, HttpMethod)
        }

        /// <summary>Test stub for Api(IDictionary`2&lt;String,Object&gt;, HttpMethod)</summary>
        [PexMethod]
        public object Api03(
            [PexAssumeNotNull]FacebookAppBase target,
            IDictionary<string, object> parameters,
            HttpMethod httpMethod
        )
        {
            object result = target.Api(parameters, httpMethod);
            return result;
            // TODO: add assertions to method FacebookAppBaseTest.Api03(FacebookAppBase, IDictionary`2<String,Object>, HttpMethod)
        }

        /// <summary>Test stub for Api(String, IDictionary`2&lt;String,Object&gt;)</summary>
        [PexMethod]
        public object Api04(
            [PexAssumeNotNull]FacebookAppBase target,
            string path,
            IDictionary<string, object> parameters
        )
        {
            object result = target.Api(path, parameters);
            return result;
            // TODO: add assertions to method FacebookAppBaseTest.Api04(FacebookAppBase, String, IDictionary`2<String,Object>)
        }

        /// <summary>Test stub for Api(String, IDictionary`2&lt;String,Object&gt;, HttpMethod)</summary>
        [PexMethod]
        public object Api05(
            [PexAssumeNotNull]FacebookAppBase target,
            string path,
            IDictionary<string, object> parameters,
            HttpMethod httpMethod
        )
        {
            object result = target.Api(path, parameters, httpMethod);
            return result;
            // TODO: add assertions to method FacebookAppBaseTest.Api05(FacebookAppBase, String, IDictionary`2<String,Object>, HttpMethod)
        }

        /// <summary>Test stub for ApiAsync(FacebookAsyncCallback, Object, IDictionary`2&lt;String,Object&gt;)</summary>
        [PexMethod]
        public void ApiAsync(
            [PexAssumeNotNull]FacebookAppBase target,
            FacebookAsyncCallback callback,
            object state,
            IDictionary<string, object> parameters
        )
        {
            target.ApiAsync(callback, state, parameters);
            // TODO: add assertions to method FacebookAppBaseTest.ApiAsync(FacebookAppBase, FacebookAsyncCallback, Object, IDictionary`2<String,Object>)
        }

        /// <summary>Test stub for ApiAsync(FacebookAsyncCallback, Object, String)</summary>
        [PexMethod]
        public void ApiAsync01(
            [PexAssumeNotNull]FacebookAppBase target,
            FacebookAsyncCallback callback,
            object state,
            string path
        )
        {
            target.ApiAsync(callback, state, path);
            // TODO: add assertions to method FacebookAppBaseTest.ApiAsync01(FacebookAppBase, FacebookAsyncCallback, Object, String)
        }

        /// <summary>Test stub for ApiAsync(FacebookAsyncCallback, Object, String, HttpMethod)</summary>
        [PexMethod]
        public void ApiAsync02(
            [PexAssumeNotNull]FacebookAppBase target,
            FacebookAsyncCallback callback,
            object state,
            string path,
            HttpMethod httpMethod
        )
        {
            target.ApiAsync(callback, state, path, httpMethod);
            // TODO: add assertions to method FacebookAppBaseTest.ApiAsync02(FacebookAppBase, FacebookAsyncCallback, Object, String, HttpMethod)
        }

        /// <summary>Test stub for ApiAsync(FacebookAsyncCallback, Object, String, IDictionary`2&lt;String,Object&gt;)</summary>
        [PexMethod]
        public void ApiAsync03(
            [PexAssumeNotNull]FacebookAppBase target,
            FacebookAsyncCallback callback,
            object state,
            string path,
            IDictionary<string, object> parameters
        )
        {
            target.ApiAsync(callback, state, path, parameters);
            // TODO: add assertions to method FacebookAppBaseTest.ApiAsync03(FacebookAppBase, FacebookAsyncCallback, Object, String, IDictionary`2<String,Object>)
        }

        /// <summary>Test stub for ApiAsync(FacebookAsyncCallback, Object, String, IDictionary`2&lt;String,Object&gt;, HttpMethod)</summary>
        [PexMethod]
        public void ApiAsync04(
            [PexAssumeNotNull]FacebookAppBase target,
            FacebookAsyncCallback callback,
            object state,
            string path,
            IDictionary<string, object> parameters,
            HttpMethod httpMethod
        )
        {
            target.ApiAsync(callback, state, path, parameters, httpMethod);
            // TODO: add assertions to method FacebookAppBaseTest.ApiAsync04(FacebookAppBase, FacebookAsyncCallback, Object, String, IDictionary`2<String,Object>, HttpMethod)
        }

        /// <summary>Test stub for ApiSecret</summary>
        [PexMethod]
        public void ApiSecretGetSet([PexAssumeNotNull]FacebookAppBase target, string value)
        {
            target.ApiSecret = value;
            string result = target.ApiSecret;
            PexAssert.AreEqual(value, result);
            // TODO: add assertions to method FacebookAppBaseTest.ApiSecretGetSet(FacebookAppBase, String)
        }

        /// <summary>Test stub for AppId</summary>
        [PexMethod]
        public void AppIdGetSet([PexAssumeNotNull]FacebookAppBase target, string value)
        {
            target.AppId = value;
            string result = target.AppId;
            PexAssert.AreEqual(value, result);
            // TODO: add assertions to method FacebookAppBaseTest.AppIdGetSet(FacebookAppBase, String)
        }

        /// <summary>Test stub for BaseDomain</summary>
        [PexMethod]
        public void BaseDomainGetSet([PexAssumeNotNull]FacebookAppBase target, string value)
        {
            target.BaseDomain = value;
            string result = target.BaseDomain;
            PexAssert.AreEqual(value, result);
            // TODO: add assertions to method FacebookAppBaseTest.BaseDomainGetSet(FacebookAppBase, String)
        }

        /// <summary>Test stub for CookieSupport</summary>
        [PexMethod]
        public void CookieSupportGetSet([PexAssumeNotNull]FacebookAppBase target, bool value)
        {
            target.CookieSupport = value;
            bool result = target.CookieSupport;
            PexAssert.AreEqual(value, result);
            // TODO: add assertions to method FacebookAppBaseTest.CookieSupportGetSet(FacebookAppBase, Boolean)
        }

        /// <summary>Test stub for DomainMaps</summary>
        [PexMethod]
        public void DomainMapsGet([PexAssumeNotNull]FacebookAppBase target)
        {
            Dictionary<string, Uri> result = target.DomainMaps;
            // TODO: add assertions to method FacebookAppBaseTest.DomainMapsGet(FacebookAppBase)
        }

        /// <summary>Test stub for GetLoginStatusUrl()</summary>
        [PexMethod]
        public Uri GetLoginStatusUrl([PexAssumeNotNull]FacebookAppBase target)
        {
            Uri result = target.GetLoginStatusUrl();
            return result;
            // TODO: add assertions to method FacebookAppBaseTest.GetLoginStatusUrl(FacebookAppBase)
        }

        /// <summary>Test stub for GetLoginStatusUrl(IDictionary`2&lt;String,Object&gt;)</summary>
        [PexMethod]
        public Uri GetLoginStatusUrl01(
            [PexAssumeNotNull]FacebookAppBase target,
            IDictionary<string, object> parameters
        )
        {
            Uri result = target.GetLoginStatusUrl(parameters);
            return result;
            // TODO: add assertions to method FacebookAppBaseTest.GetLoginStatusUrl01(FacebookAppBase, IDictionary`2<String,Object>)
        }

        /// <summary>Test stub for GetLoginUrl()</summary>
        [PexMethod]
        public Uri GetLoginUrl([PexAssumeNotNull]FacebookAppBase target)
        {
            Uri result = target.GetLoginUrl();
            return result;
            // TODO: add assertions to method FacebookAppBaseTest.GetLoginUrl(FacebookAppBase)
        }

        /// <summary>Test stub for GetLoginUrl(IDictionary`2&lt;String,Object&gt;)</summary>
        [PexMethod]
        public Uri GetLoginUrl01(
            [PexAssumeNotNull]FacebookAppBase target,
            IDictionary<string, object> parameters
        )
        {
            Uri result = target.GetLoginUrl(parameters);
            return result;
            // TODO: add assertions to method FacebookAppBaseTest.GetLoginUrl01(FacebookAppBase, IDictionary`2<String,Object>)
        }

        /// <summary>Test stub for GetLogoutUrl()</summary>
        [PexMethod]
        public Uri GetLogoutUrl([PexAssumeNotNull]FacebookAppBase target)
        {
            Uri result = target.GetLogoutUrl();
            return result;
            // TODO: add assertions to method FacebookAppBaseTest.GetLogoutUrl(FacebookAppBase)
        }

        /// <summary>Test stub for GetLogoutUrl(IDictionary`2&lt;String,Object&gt;)</summary>
        [PexMethod]
        public Uri GetLogoutUrl01(
            [PexAssumeNotNull]FacebookAppBase target,
            IDictionary<string, object> parameters
        )
        {
            Uri result = target.GetLogoutUrl(parameters);
            return result;
            // TODO: add assertions to method FacebookAppBaseTest.GetLogoutUrl01(FacebookAppBase, IDictionary`2<String,Object>)
        }

        /// <summary>Test stub for Session</summary>
        [PexMethod]
        public void SessionGetSet([PexAssumeNotNull]FacebookAppBase target, FacebookSession value)
        {
            target.Session = value;
            FacebookSession result = target.Session;
            PexAssert.AreEqual<FacebookSession>(value, result);
            // TODO: add assertions to method FacebookAppBaseTest.SessionGetSet(FacebookAppBase, FacebookSession)
        }

        /// <summary>Test stub for SessionLoaded</summary>
        [PexMethod]
        public void SessionLoadedGetSet([PexAssumeNotNull]FacebookAppBase target, bool value)
        {
            target.SessionLoaded = value;
            bool result = target.SessionLoaded;
            PexAssert.AreEqual(value, result);
            // TODO: add assertions to method FacebookAppBaseTest.SessionLoadedGetSet(FacebookAppBase, Boolean)
        }

        /// <summary>Test stub for UserId</summary>
        [PexMethod]
        public void UserIdGet([PexAssumeNotNull]FacebookAppBase target)
        {
            long result = target.UserId;
            // TODO: add assertions to method FacebookAppBaseTest.UserIdGet(FacebookAppBase)
        }
    }
}
