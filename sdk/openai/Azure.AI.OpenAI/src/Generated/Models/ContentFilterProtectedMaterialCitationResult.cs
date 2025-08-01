// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI
{
    /// <summary> The ContentFilterProtectedMaterialCitationResult. </summary>
    public partial class ContentFilterProtectedMaterialCitationResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        /// <summary> Initializes a new instance of <see cref="ContentFilterProtectedMaterialCitationResult"/>. </summary>
        internal ContentFilterProtectedMaterialCitationResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContentFilterProtectedMaterialCitationResult"/>. </summary>
        /// <param name="license"> The name or identifier of the license associated with the detection. </param>
        /// <param name="uri"></param>
        /// <param name="additionalBinaryDataProperties"> Keeps track of any properties unknown to the library. </param>
        internal ContentFilterProtectedMaterialCitationResult(string license, Uri uri, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            License = license;
            Uri = uri;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        /// <summary> The name or identifier of the license associated with the detection. </summary>
        public string License { get; }

        /// <summary></summary>
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
