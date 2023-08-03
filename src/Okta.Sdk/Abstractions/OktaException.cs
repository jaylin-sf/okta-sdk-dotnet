﻿// <copyright file="OktaException.cs" company="Okta, Inc">
// Copyright (c) 2018 - present Okta, Inc. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.
// </copyright>

using System;

namespace Okta.Sdk.Abstractions
{
    /// <summary>
    /// Base class for all Okta client and API exceptions.
    /// </summary>
    public class OktaException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OktaException"/> class.
        /// </summary>
        public OktaException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OktaException"/> class.
        /// </summary>
        /// <param name="message">
        /// The message that describes the error.
        /// </param>
        /// <param name="statusCode">
        /// The status Code.
        /// </param>
        public OktaException(string message, int statusCode)
            : base(message)
        {
            StatusCode = statusCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OktaException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public OktaException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OktaException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        public OktaException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Gets the HTTP status code.
        /// </summary>
        public int StatusCode { get; private set; }
    }
}
