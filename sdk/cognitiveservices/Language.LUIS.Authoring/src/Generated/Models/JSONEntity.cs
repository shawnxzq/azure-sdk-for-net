// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Authoring.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Exported Model - Extracted Entity from utterance.
    /// </summary>
    public partial class JSONEntity
    {
        /// <summary>
        /// Initializes a new instance of the JSONEntity class.
        /// </summary>
        public JSONEntity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JSONEntity class.
        /// </summary>
        /// <param name="startPos">The index within the utterance where the
        /// extracted entity starts.</param>
        /// <param name="endPos">The index within the utterance where the
        /// extracted entity ends.</param>
        /// <param name="entity">The entity name.</param>
        /// <param name="role">The role of the entity within the
        /// utterance.</param>
        public JSONEntity(int startPos, int endPos, string entity, string role = default(string))
        {
            StartPos = startPos;
            EndPos = endPos;
            Entity = entity;
            Role = role;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the index within the utterance where the extracted
        /// entity starts.
        /// </summary>
        [JsonProperty(PropertyName = "startPos")]
        public int StartPos { get; set; }

        /// <summary>
        /// Gets or sets the index within the utterance where the extracted
        /// entity ends.
        /// </summary>
        [JsonProperty(PropertyName = "endPos")]
        public int EndPos { get; set; }

        /// <summary>
        /// Gets or sets the entity name.
        /// </summary>
        [JsonProperty(PropertyName = "entity")]
        public string Entity { get; set; }

        /// <summary>
        /// Gets or sets the role of the entity within the utterance.
        /// </summary>
        [JsonProperty(PropertyName = "role")]
        public string Role { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Entity == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Entity");
            }
        }
    }
}
