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
    /// V1RateCheckRequest
    /// </summary>
    [DataContract(Name = "V1RateCheckRequest")]
    public partial class V1RateCheckRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="V1RateCheckRequest" /> class.
        /// </summary>
        [JsonConstructor]
        public V1RateCheckRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="V1RateCheckRequest" /> class.
        /// </summary>
        /// <param name="confirmation">Request confirmation for this shipment. Options are: NONE, SIGNATURE, ADULT_SIGNATURE. Defaults to NONE if not specified. A surcharge might apply..</param>
        /// <param name="shipDate">Format YYYY-MM-DD. Date the carrier is expected to receive the parcel. Required to get estimated_delivery_date..</param>
        /// <param name="addressFrom">addressFrom (required).</param>
        /// <param name="postalCodeTo">Destination postal code (required).</param>
        /// <param name="parcels">Parcels sent as part of this Shipment. (required).</param>
        /// <param name="finalMileCarrier">Check rate for a specific final mile carrier. If nothing is specified, the default carrier will be used.</param>
        public V1RateCheckRequest(string confirmation = default(string), string shipDate = default(string), Address addressFrom = default(Address), string postalCodeTo = default(string), List<Parcel> parcels = default(List<Parcel>), string finalMileCarrier = default)
        {
            // to ensure "addressFrom" is required (not null)
            if (addressFrom == null)
            {
                throw new ArgumentNullException("addressFrom is a required property for V1RateCheckRequest and cannot be null");
            }
            this.AddressFrom = addressFrom;
            // to ensure "postalCodeTo" is required (not null)
            if (postalCodeTo == null)
            {
                throw new ArgumentNullException("postalCodeTo is a required property for V1RateCheckRequest and cannot be null");
            }
            this.PostalCodeTo = postalCodeTo;
            // to ensure "parcels" is required (not null)
            if (parcels == null)
            {
                throw new ArgumentNullException("parcels is a required property for V1RateCheckRequest and cannot be null");
            }
            this.Parcels = parcels;
            this.Confirmation = confirmation;
            this.ShipDate = shipDate;
            this.FinalMileCarrier = finalMileCarrier;
        }
        
        /// <summary>
        /// Check rate for a specific final mile carrier. If nothing is specified, the default carrier will be used.
        /// <value>
        /// Options are:
        /// cdl,
        /// gls-us,
        /// lso,
        /// uds,
        /// courier_express,
        /// optima,
        /// groscale,
        /// speedx,
        /// uniuni
        /// </value>
        /// </summary>
        [DataMember(Name = "final_mile_carrier", EmitDefaultValue = false)]
        [JsonPropertyName("final_mile_carrier")]
        public string? FinalMileCarrier { get; set; }

        /// <summary>
        /// Request confirmation for this shipment. Options are: NONE, SIGNATURE, ADULT_SIGNATURE. Defaults to NONE if not specified. A surcharge might apply.
        /// </summary>
        /// <value>Request confirmation for this shipment. Options are: NONE, SIGNATURE, ADULT_SIGNATURE. Defaults to NONE if not specified. A surcharge might apply.</value>
        [DataMember(Name = "confirmation", EmitDefaultValue = false)]
        [JsonPropertyName("confirmation")]
        public string? Confirmation { get; set; }

        /// <summary>
        /// Format YYYY-MM-DD. Date the carrier is expected to receive the parcel. Required to get estimated_delivery_date.
        /// </summary>
        /// <value>Format YYYY-MM-DD. Date the carrier is expected to receive the parcel. Required to get estimated_delivery_date.</value>
        [DataMember(Name = "ship_date", EmitDefaultValue = false)]
        [JsonPropertyName("ship_date")]
        public string? ShipDate { get; set; }

        /// <summary>
        /// Gets or Sets AddressFrom
        /// </summary>
        [DataMember(Name = "address_from", IsRequired = true, EmitDefaultValue = true)]
        [JsonPropertyName("address_from")]
        public Address? AddressFrom { get; set; }

        /// <summary>
        /// Destination postal code
        /// </summary>
        /// <value>Destination postal code</value>
        [DataMember(Name = "postal_code_to", IsRequired = true, EmitDefaultValue = true)]
        [JsonPropertyName("postal_code_to")]
        public string? PostalCodeTo { get; set; }

        /// <summary>
        /// Parcels sent as part of this Shipment.
        /// </summary>
        /// <value>Parcels sent as part of this Shipment.</value>
        [DataMember(Name = "parcels", IsRequired = true, EmitDefaultValue = true)]
        [JsonPropertyName("parcels")]
        public List<Parcel>? Parcels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class V1RateCheckRequest {\n");
            sb.Append("  Confirmation: ").Append(Confirmation).Append("\n");
            sb.Append("  ShipDate: ").Append(ShipDate).Append("\n");
            sb.Append("  AddressFrom: ").Append(AddressFrom).Append("\n");
            sb.Append("  PostalCodeTo: ").Append(PostalCodeTo).Append("\n");
            sb.Append("  Parcels: ").Append(Parcels).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
