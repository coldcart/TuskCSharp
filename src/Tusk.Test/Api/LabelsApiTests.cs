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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using Xunit;

using Tusk.Client;
using Tusk.Api;
using Tusk.Model;

// uncomment below to import models
//using Tusk.Model;

namespace Tusk.Test.Api
{
    /// <summary>
    ///  Class for testing LabelsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class LabelsApiTests : IDisposable
    {
        private LabelsApi instance;

        public LabelsApiTests()
        {
            ReadableConfiguration config = new ReadableConfiguration();
            config.BasePath = "https://apisandbox.tusklogistics.com";
            // Configure API key authorization: ApiKeyAuth
            config.ApiKey.Add("x-api-key", "X_API_KEY");
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            instance = new LabelsApi(httpClient, config, httpClientHandler);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of LabelsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' LabelsApi
            //Assert.IsType<LabelsApi>(instance);
        }

        /// <summary>
        /// Test GetaLabelbyID
        /// </summary>
        [Fact]
        public void GetaLabelbyIDTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int labelId = null;
            //var response = instance.GetaLabelbyID(labelId);
            //Assert.IsType<Label>(response);
        }

        /// <summary>
        /// Test PurchaseLabels
        /// </summary>
        [Fact(Skip = "Local testing")]
        public async Task PurchaseLabelsTest()
        {
            V1LabelsRequest? v1LabelsRequest = new V1LabelsRequest
            {
                Shipment = new CreateShipment
                {
                    Parcels = new List<Parcel>
                    {
                        new Parcel()
                        {
                            Dimensions = new ParcelDimensions
                            {
                                Height = 10,
                                Width = 10,
                                Length = 10,
                            },
                            Weight = new ParcelWeight
                            {
                                Unit = "Pound",
                                Value = 10
                            }
                        }
                    },
                    AddressTo = new Address
                    {
                        Name = "Dave",
                        Street1 = "123 South Street",
                        Street2 = "Unit 2",
                        City = "Chicago",
                        State = "IL",
                        PostalCode = "60601",
                        Country = "US",
                        Phone = "773-123-4567",
                        Email = "dave@email.com",
                    },
                    AddressFrom = new Address
                    {
                        Street1 = "571 Wheeling Rd",
                        City = "Wheeling",
                        State = "IL",
                        PostalCode = "60090",
                    },
                    ExternalReference = "1234",
                    
                }
            };
            var response = await instance.PurchaseLabelsAsync(v1LabelsRequest);
            await instance.VoidaLabelAsync(response.Labels[0].Id);
            //Assert.IsType<ShipmentPurchaseResponse>(response);
        }

        /// <summary>
        /// Test VoidaLabel
        /// </summary>
        [Fact]
        public void VoidaLabelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int labelId = null;
            //instance.VoidaLabel(labelId);
        }
    }
}
