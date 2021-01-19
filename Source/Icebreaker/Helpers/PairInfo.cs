//----------------------------------------------------------------------------------------------
// <copyright file="PairInfo.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>
//----------------------------------------------------------------------------------------------

namespace Icebreaker.Helpers
{
    using System.Collections.Generic;
    using Microsoft.Azure.Documents;
    using Microsoft.Bot.Schema;
    using Newtonsoft.Json;

    /// <summary>
    /// Represents a user
    /// </summary>
    public class PairInfo : Document
    {
        /// <summary>
        /// Gets or sets one user of a match
        /// </summary>
        [JsonProperty("user1")]
        public ChannelAccount User1 { get; set; }

        /// <summary>
        /// Gets or sets the second user of the match with respect to User1
        /// </summary>
        [JsonProperty("user2")]
        public ChannelAccount User2 { get; set; }

        /// <summary>
        /// Gets or sets a match iteration cycle that this match occured in
        /// </summary>
        [JsonProperty("iteration")]
        public int Iteration { get; set; }
    }
}