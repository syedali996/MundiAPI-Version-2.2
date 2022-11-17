// <copyright file="GetGatewayErrorResponse.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace PagarmeCoreApi.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using PagarmeCoreApi.Standard;
    using PagarmeCoreApi.Standard.Utilities;

    /// <summary>
    /// GetGatewayErrorResponse.
    /// </summary>
    public class GetGatewayErrorResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetGatewayErrorResponse"/> class.
        /// </summary>
        public GetGatewayErrorResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetGatewayErrorResponse"/> class.
        /// </summary>
        /// <param name="message">message.</param>
        public GetGatewayErrorResponse(
            string message)
        {
            this.Message = message;
        }

        /// <summary>
        /// The message error
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"GetGatewayErrorResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            return obj is GetGatewayErrorResponse other &&
                ((this.Message == null && other.Message == null) || (this.Message?.Equals(other.Message) == true));
        }
        

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Message = {(this.Message == null ? "null" : this.Message == string.Empty ? "" : this.Message)}");
        }
    }
}