﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace SINners.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class SINnerVisibility
    {
        /// <summary>
        /// Initializes a new instance of the SINnerVisibility class.
        /// </summary>
        public SINnerVisibility() { }

        /// <summary>
        /// Initializes a new instance of the SINnerVisibility class.
        /// </summary>
        public SINnerVisibility(Guid? id = default(Guid?), bool? isPublic = default(bool?), bool? isGroupVisible = default(bool?), IList<SINerUserRight> userRights = default(IList<SINerUserRight>))
        {
            Id = id;
            IsPublic = isPublic;
            IsGroupVisible = isGroupVisible;
            UserRights = userRights;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public Guid? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isPublic")]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isGroupVisible")]
        public bool? IsGroupVisible { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userRights")]
        public IList<SINerUserRight> UserRights { get; set; }

    }
}
