/*
 * Tusk Logistics API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * Contact: devsupport@tusklogistics.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Tusk.Model
{
    /// <summary>
    /// TrackingLabelHistory
    /// </summary>
    [DataContract(Name = "TrackingLabelHistory")]
    public partial class TrackingLabelHistory : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingLabelHistory" /> class.
        /// </summary>
        [JsonConstructor]
        public TrackingLabelHistory()
        {
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingLabelHistory" /> class.
        /// </summary>
        /// <param name="location">location.</param>
        /// <param name="status">Status of the Shipment at the time of the tracking event_date. Possible values are: CREATED, RECEIVED_BY_CARRIER, IN_TRANSIT, OUT_FOR_DELIVERY, DELIVERY_FAILURE, DELIVERED, CANCELLED, UNKNOWN.</param>
        /// <param name="eventDate">Timestamp at which the tracking event occurred..</param>
        public TrackingLabelHistory(TrackingLabelLocation location = default(TrackingLabelLocation), string status = default(string), string eventDate = default(string))
        {
            this.Location = location;
            this.Status = status;
            this.EventDate = eventDate;
        }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name = "location", EmitDefaultValue = false)]
        [JsonPropertyName("location")]
        public TrackingLabelLocation? Location { get; set; }

        /// <summary>
        /// Status of the Shipment at the time of the tracking event_date. Possible values are: CREATED, RECEIVED_BY_CARRIER, IN_TRANSIT, OUT_FOR_DELIVERY, DELIVERY_FAILURE, DELIVERED, CANCELLED, UNKNOWN
        /// </summary>
        /// <value>Status of the Shipment at the time of the tracking event_date. Possible values are: CREATED, RECEIVED_BY_CARRIER, IN_TRANSIT, OUT_FOR_DELIVERY, DELIVERY_FAILURE, DELIVERED, CANCELLED, UNKNOWN</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Timestamp at which the tracking event occurred.
        /// </summary>
        /// <value>Timestamp at which the tracking event occurred.</value>
        [DataMember(Name = "event_date", EmitDefaultValue = false)]
        [JsonPropertyName("event_date")]
        public string? EventDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrackingLabelHistory {\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  EventDate: ").Append(EventDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
