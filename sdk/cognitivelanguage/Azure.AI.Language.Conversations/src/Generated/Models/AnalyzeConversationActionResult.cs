// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Conversations.Models
{
    /// <summary>
    /// The base class of a conversation input task result.
    /// Please note <see cref="AnalyzeConversationActionResult"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ConversationalAITaskResult"/> and <see cref="ConversationActionResult"/>.
    /// </summary>
    public abstract partial class AnalyzeConversationActionResult
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AnalyzeConversationActionResult"/>. </summary>
        protected AnalyzeConversationActionResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AnalyzeConversationActionResult"/>. </summary>
        /// <param name="kind"> The base class of a conversation input task result. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AnalyzeConversationActionResult(AnalyzeConversationResultKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Kind = kind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The base class of a conversation input task result. </summary>
        internal AnalyzeConversationResultKind Kind { get; set; }
    }
}
