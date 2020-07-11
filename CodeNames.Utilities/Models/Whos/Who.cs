// <copyright file="Who.cs" company="Do It Wright">
// Copyright (c) Do It Wright. All rights reserved.
// </copyright>

using System;

namespace CodeNames.Utilities.Models.Whos
{
    /// <summary>
    /// Details of Who made the request.
    /// </summary>
    /// <seealso cref="IWho" />
    public class Who : IWho
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Who"/> class.
        /// </summary>
        /// <param name="controllerName">Controller Name.</param>
        /// <param name="actionName">Action Name.</param>
        /// <param name="path">Request Path.</param>
        /// <param name="queryString">Request Query String.</param>
        /// <param name="clientIpAddress">Client IP Address.</param>
        /// <param name="username">Username.</param>
        public Who(
            string controllerName,
            string actionName,
            string path,
            string queryString,
            string clientIpAddress,
            string? username)
        {
            this.CorrelationId = Guid.NewGuid();
            this.ControllerName = controllerName ?? throw new ArgumentNullException(nameof(controllerName));
            this.ActionName = actionName ?? throw new ArgumentNullException(nameof(actionName));
            this.Path = path ?? throw new ArgumentNullException(nameof(path));
            this.QueryString = queryString ?? throw new ArgumentNullException(nameof(queryString));
            this.ClientIpAddress = clientIpAddress ?? throw new ArgumentNullException(nameof(clientIpAddress));
            this.Username = username ?? throw new ArgumentNullException(nameof(username));
        }

        #endregion

        #region Public Properties

        /// <inheritdoc />
        public Guid CorrelationId { get; }

        /// <inheritdoc />
        public string ControllerName { get; }

        /// <inheritdoc />
        public string ActionName { get; }

        /// <inheritdoc />
        public string Path { get; }

        /// <inheritdoc />
        public string QueryString { get; }

        /// <inheritdoc />
        public string ClientIpAddress { get; }

        /// <inheritdoc />
        public string? Username { get; }

        #endregion
    }
}