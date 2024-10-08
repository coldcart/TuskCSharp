/*
 * Tusk Logistics API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * Contact: devsupport@tusklogistics.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Tusk.Model
{
    /// <summary>
    /// ShipmentPurchaseResponse
    /// </summary>
    [DataContract(Name = "ShipmentPurchaseResponse")]
    public partial class ShipmentPurchaseResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentPurchaseResponse" /> class.
        /// </summary>
        /// <param name="shipmentId">The identifier of this Shipment..</param>
        /// <param name="rateId">The Rate which was used to create Labels for this Shipment..</param>
        /// <param name="shipmentTrackingNumber">The Tusk tracking number used to track this Shipment..</param>
        /// <param name="labels">labels.</param>
        public ShipmentPurchaseResponse(int shipmentId = default(int), int rateId = default(int), string shipmentTrackingNumber = default(string), List<ShipmentLabel> labels = default(List<ShipmentLabel>))
        {
            this.ShipmentId = shipmentId;
            this.RateId = rateId;
            this.ShipmentTrackingNumber = shipmentTrackingNumber;
            this.Labels = labels;
        }

        /// <summary>
        /// The identifier of this Shipment.
        /// </summary>
        /// <value>The identifier of this Shipment.</value>
        [DataMember(Name = "shipment_id", EmitDefaultValue = false)]
        [JsonPropertyName("shipment_id")]
        public int ShipmentId { get; set; }

        /// <summary>
        /// The Rate which was used to create Labels for this Shipment.
        /// </summary>
        /// <value>The Rate which was used to create Labels for this Shipment.</value>
        [DataMember(Name = "rate_id", EmitDefaultValue = false)]
        [JsonPropertyName("rate_id")]
        public int RateId { get; set; }

        /// <summary>
        /// The Tusk tracking number used to track this Shipment.
        /// </summary>
        /// <value>The Tusk tracking number used to track this Shipment.</value>
        [DataMember(Name = "shipment_tracking_number", EmitDefaultValue = false)]
        [JsonPropertyName("shipment_tracking_number")]
        public string ShipmentTrackingNumber { get; set; }

        /// <summary>
        /// Gets or Sets Labels
        /// </summary>
        [DataMember(Name = "labels", EmitDefaultValue = false)]
        [JsonPropertyName("labels")]
        public List<ShipmentLabel> Labels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShipmentPurchaseResponse {\n");
            sb.Append("  ShipmentId: ").Append(ShipmentId).Append("\n");
            sb.Append("  RateId: ").Append(RateId).Append("\n");
            sb.Append("  ShipmentTrackingNumber: ").Append(ShipmentTrackingNumber).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
