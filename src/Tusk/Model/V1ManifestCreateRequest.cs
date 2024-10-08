/*
 * Tusk Logistics API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * Contact: devsupport@tusklogistics.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Tusk.Model
{
    /// <summary>
    /// V1ManifestCreateRequest
    /// </summary>
    [DataContract(Name = "V1ManifestCreateRequest")]
    public partial class V1ManifestCreateRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1ManifestCreateRequest" /> class.
        /// </summary>
        [JsonConstructor]
        public V1ManifestCreateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1ManifestCreateRequest" /> class.
        /// </summary>
        /// <param name="labelIds">Label Id to be added to manifest.</param>
        /// <param name="shipmentTrackingNumbers">Shipments to be added to manifest.</param>
        /// <param name="addressFrom">addressFrom (required).</param>
        public V1ManifestCreateRequest(List<int> labelIds = default(List<int>), List<string> shipmentTrackingNumbers = default(List<string>), Address addressFrom = default(Address))
        {
            // to ensure "addressFrom" is required (not null)
            if (addressFrom == null)
            {
                throw new ArgumentNullException("addressFrom is a required property for V1ManifestCreateRequest and cannot be null");
            }
            this.AddressFrom = addressFrom;
            this.LabelIds = labelIds;
            this.ShipmentTrackingNumbers = shipmentTrackingNumbers;
        }

        /// <summary>
        /// Label Id to be added to manifest
        /// </summary>
        /// <value>Label Id to be added to manifest</value>
        [DataMember(Name = "label_ids", EmitDefaultValue = false)]
        [JsonPropertyName("label_ids")]
        public List<int>? LabelIds { get; set; }

        /// <summary>
        /// Shipments to be added to manifest
        /// </summary>
        /// <value>Shipments to be added to manifest</value>
        [DataMember(Name = "shipment_tracking_numbers", EmitDefaultValue = false)]
        [JsonPropertyName("shipment_tracking_numbers")]
        public List<string>? ShipmentTrackingNumbers { get; set; }

        /// <summary>
        /// Gets or Sets AddressFrom
        /// </summary>
        [DataMember(Name = "address_from", IsRequired = true, EmitDefaultValue = true)]
        [JsonPropertyName("address_from")]
        public Address? AddressFrom { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class V1ManifestCreateRequest {\n");
            sb.Append("  LabelIds: ").Append(LabelIds).Append("\n");
            sb.Append("  ShipmentTrackingNumbers: ").Append(ShipmentTrackingNumbers).Append("\n");
            sb.Append("  AddressFrom: ").Append(AddressFrom).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
