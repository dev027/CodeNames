// <copyright file="ConstructorTests.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;
using CodeNames.Utilities.Models.Whos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeNames.Utilities.Tests.Models.Whos.WhoTests
{
    /// <summary>
    /// Test the constructor for <see cref="Who"/>.
    /// </summary>
    [TestClass]
    public class ConstructorTests
    {
        /// <summary>
        /// Tests the constructor with valid values.
        /// </summary>
        [TestMethod]
        public void TestConstructorWithValidValues()
        {
            // ARRANGE
            const string paramControllerName = "ControllerName";
            const string paramActionName = "ActionName";
            const string paramPath = "/Home/Index";
            const string paramQueryString = "?id=15";
            const string paramClientIpAddress = "192.1.162.0";
            const string paramUsername = "steve.wright";

            // ACT
            IWho who = new Who(
                controllerName: paramControllerName,
                actionName: paramActionName,
                path: paramPath,
                queryString: paramQueryString,
                clientIpAddress: paramClientIpAddress,
                username: paramUsername);

            // ASSERT
            Assert.AreNotEqual(Guid.Empty, who.CorrelationId);
            Assert.AreEqual(paramControllerName, who.ControllerName);
            Assert.AreEqual(paramActionName, who.ActionName);
            Assert.AreEqual(paramPath, who.Path);
            Assert.AreEqual(paramQueryString, who.QueryString);
            Assert.AreEqual(paramClientIpAddress, who.ClientIpAddress);
            Assert.AreEqual(paramUsername, who.Username);
        }

        /// <summary>
        /// Tests the constructor with null controller name throws exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestConstructorWithNullControllerNameThrowsException()
        {
            // ARRANGE
            const string paramActionName = "ActionName";
            const string paramPath = "/Home/Index";
            const string paramQueryString = "?id=15";
            const string paramClientIpAddress = "192.1.162.0";
            const string paramUsername = "steve.wright";

            // ACT
            _ = new Who(
                controllerName: null!,
                actionName: paramActionName,
                path: paramPath,
                queryString: paramQueryString,
                clientIpAddress: paramClientIpAddress,
                username: paramUsername);
        }

        /// <summary>
        /// Tests the constructor with null action name throws exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestConstructorWithNullActionNameThrowsException()
        {
            // ARRANGE
            const string paramControllerName = "ControllerName";
            const string paramPath = "/Home/Index";
            const string paramQueryString = "?id=15";
            const string paramClientIpAddress = "192.1.162.0";
            const string paramUsername = "steve.wright";

            // ACT
            _ = new Who(
                controllerName: paramControllerName,
                actionName: null!,
                path: paramPath,
                queryString: paramQueryString,
                clientIpAddress: paramClientIpAddress,
                username: paramUsername);
        }

        /// <summary>
        /// Tests the constructor with null path throws exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestConstructorWithNullPathThrowsException()
        {
            // ARRANGE
            const string paramControllerName = "ControllerName";
            const string paramActionName = "ActionName";
            const string paramQueryString = "?id=15";
            const string paramClientIpAddress = "192.1.162.0";
            const string paramUsername = "steve.wright";

            // ACT
            _ = new Who(
                controllerName: paramControllerName,
                actionName: paramActionName,
                path: null!,
                queryString: paramQueryString,
                clientIpAddress: paramClientIpAddress,
                username: paramUsername);
        }

        /// <summary>
        /// Tests the constructor with null query string throws exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestConstructorWithNullQueryStringThrowsException()
        {
            // ARRANGE
            const string paramControllerName = "ControllerName";
            const string paramActionName = "ActionName";
            const string paramPath = "/Home/Index";
            const string paramClientIpAddress = "192.1.162.0";
            const string paramUsername = "steve.wright";

            // ACT
            _ = new Who(
                controllerName: paramControllerName,
                actionName: paramActionName,
                path: paramPath,
                queryString: null!,
                clientIpAddress: paramClientIpAddress,
                username: paramUsername);
        }

        /// <summary>
        /// Tests the constructor with null client IP address throws exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestConstructorWithNullClientIpAddressThrowsException()
        {
            // ARRANGE
            const string paramControllerName = "ControllerName";
            const string paramActionName = "ActionName";
            const string paramPath = "/Home/Index";
            const string paramQueryString = "?id=15";
            const string paramUsername = "steve.wright";

            // ACT
            _ = new Who(
                controllerName: paramControllerName,
                actionName: paramActionName,
                path: paramPath,
                queryString: paramQueryString,
                clientIpAddress: null!,
                username: paramUsername);
        }

        /// <summary>
        /// Tests the constructor with null username throws exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestConstructorWithNullUsernameThrowsException()
        {
            // ARRANGE
            const string paramControllerName = "ControllerName";
            const string paramActionName = "ActionName";
            const string paramPath = "/Home/Index";
            const string paramQueryString = "?id=15";
            const string paramClientIpAddress = "192.1.162.0";

            // ACT
            _ = new Who(
                controllerName: paramControllerName,
                actionName: paramActionName,
                path: paramPath,
                queryString: paramQueryString,
                clientIpAddress: paramClientIpAddress,
                username: null!);
        }
    }
}