// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Bot.Connector
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// </summary>
    public partial class Image
    {
        /// <summary>
        /// Initializes a new instance of the Image class.
        /// </summary>
        public Image() { }

        /// <summary>
        /// Initializes a new instance of the Image class.
        /// </summary>
        public Image(string url = default(string), string alt = default(string), Action tap = default(Action))
        {
            Url = url;
            Alt = alt;
            Tap = tap;
        }

        /// <summary>
        /// URL Thumbnail image for major content property.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Image description intended for screen readers
        /// </summary>
        [JsonProperty(PropertyName = "alt")]
        public string Alt { get; set; }

        /// <summary>
        /// Action assigned to specific Attachment.E.g.navigate to specific
        /// URL or play/open media content
        /// </summary>
        [JsonProperty(PropertyName = "tap")]
        public Action Tap { get; set; }

    }
}