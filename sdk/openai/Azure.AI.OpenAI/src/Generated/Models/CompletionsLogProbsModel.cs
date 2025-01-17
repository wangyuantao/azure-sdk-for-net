// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.OpenAI.Models
{
    /// <summary> LogProbs model within completion choice. </summary>
    public partial class CompletionsLogProbsModel
    {
        /// <summary> Initializes a new instance of CompletionsLogProbsModel. </summary>
        internal CompletionsLogProbsModel()
        {
            Tokens = new ChangeTrackingList<string>();
            TokenLogprobs = new ChangeTrackingList<float>();
            TopLogprobs = new ChangeTrackingList<IDictionary<string, float>>();
            TextOffset = new ChangeTrackingList<int>();
        }

        /// <summary> Initializes a new instance of CompletionsLogProbsModel. </summary>
        /// <param name="tokens"></param>
        /// <param name="tokenLogprobs"></param>
        /// <param name="topLogprobs"></param>
        /// <param name="textOffset"></param>
        internal CompletionsLogProbsModel(IReadOnlyList<string> tokens, IReadOnlyList<float> tokenLogprobs, IReadOnlyList<IDictionary<string, float>> topLogprobs, IReadOnlyList<int> textOffset)
        {
            Tokens = tokens.ToList();
            TokenLogprobs = tokenLogprobs.ToList();
            TopLogprobs = topLogprobs.ToList();
            TextOffset = textOffset.ToList();
        }

        /// <summary> Gets the tokens. </summary>
        public IReadOnlyList<string> Tokens { get; }
        /// <summary> Gets the token logprobs. </summary>
        public IReadOnlyList<float> TokenLogprobs { get; }
        /// <summary> Gets the top logprobs. </summary>
        public IReadOnlyList<IDictionary<string, float>> TopLogprobs { get; }
        /// <summary> Gets the text offset. </summary>
        public IReadOnlyList<int> TextOffset { get; }
    }
}
