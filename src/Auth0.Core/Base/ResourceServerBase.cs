﻿using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Auth0.Core
{
    /// <summary>
    /// Base class for resource server payloads
    /// </summary>
    public class ResourceServerBase
    {
        /// <summary>
        /// The name of the resource server
        /// </summary>
        /// <remarks>
        /// Must contain at least one character. Does not allow '&lt;' or '&gt;'"
        /// </remarks>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The available scopes for the resource server
        /// </summary>
        [JsonProperty("scopes")]
        public List<ResourceServerScope> Scopes { get; set; }

        /// <summary>
        /// The algorithm used to sign tokens
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("signing_alg")]
        public SigningAlgorithm SigningAlgorithm { get; set; }

        /// <summary>
        /// The secret used to sign tokens when using symmetric algorithms
        /// </summary>
        [JsonProperty("signing_secret")]
        public string SigningSecret { get; set; }

        /// <summary>
        /// The amount of time (in seconds) that the token will be valid after being issued
        /// </summary>
        [JsonProperty("token_lifetime")]
        public int TokenLifetime { get; set; }

        /// <summary>
        /// Allows issuance of refresh tokens for this entity
        /// </summary>
        [JsonProperty("allow_offline_access")]
        public bool AllowOfflineAccess { get; set; }

        /// <summary>
        /// Flag this entity as capable of skipping consent
        /// </summary>
        [JsonProperty("skip_consent_for_verifiable_first_party_clients")]
        public bool SkipConsentForVerifiableFirstPartyClients { get; set; }
    }
}