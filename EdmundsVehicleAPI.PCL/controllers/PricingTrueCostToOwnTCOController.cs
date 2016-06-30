/*
 * EdmundsVehicleAPI.PCL
 *
 * This file was automatically generated by APIMATIC BETA v2.0 on 01/27/2016
 */
using EdmundsVehicleAPI.PCL.Http.Client;
using EdmundsVehicleAPI.PCL.Http.Request;
using EdmundsVehicleAPI.PCL.Http.Response;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdmundsVehicleAPI.PCL.Controllers
{
    public partial class PricingTrueCostToOwnTCOController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static PricingTrueCostToOwnTCOController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static PricingTrueCostToOwnTCOController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new PricingTrueCostToOwnTCOController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Get the total 5-year True Cost to Own for a new vehicle
        /// </summary>
        /// <param name="callback">Required parameter: The callback function that the JSON response will be wrapped in if desired</param>
        /// <param name="fmt">Required parameter: Response format (json only) (Acceptable values are: "json")</param>
        /// <param name="styleid">Required parameter: Vehicle style ID</param>
        /// <param name="zip">Required parameter: five-digit zipcode</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetNewtruecosttoownbystyleidandzipAsync(
                string callback,
                string fmt,
                string styleid,
                string zip)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v1/api/tco/newtruecosttoownbystyleidandzip/{styleid}/{zip}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "styleid", styleid },
                { "zip", zip }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "callback", callback },
                { "fmt", fmt },
                { "api_key", Configuration.ApiKey }
            });

            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

        /// <summary>
        /// Get the total 5-year True Cost to Own for a used vehicle
        /// </summary>
        /// <param name="callback">Required parameter: The callback function that the JSON response will be wrapped in if desired</param>
        /// <param name="fmt">Required parameter: Response format (json only) (Acceptable values are: "json")</param>
        /// <param name="styleid">Required parameter: Vehicle style ID</param>
        /// <param name="zip">Required parameter: Five-digit zipcode</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetUsedtruecosttoownbystyleidandzipAsync(
                string callback,
                string fmt,
                string styleid,
                string zip)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v1/api/tco/usedtruecosttoownbystyleidandzip/{styleid}/{zip}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "styleid", styleid },
                { "zip", zip }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "callback", callback },
                { "fmt", fmt },
                { "api_key", Configuration.ApiKey }
            });

            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

        /// <summary>
        /// The Total Cash Price displayed is the vehicle's True Market Value® price plus the Typically Equipped options, destination charge, base tax and fees assessed by your state, and, if applicable, gas guzzler tax; less any widely available manufacturer-to-customer cash rebates. (However, we do not account for other types of cash rebates or incentives because of the variability of those offers and their eligibility requirements.)
        /// </summary>
        /// <param name="callback">Required parameter: The callback function that the JSON response will be wrapped in if desired</param>
        /// <param name="fmt">Required parameter: Response format (json only) (Acceptable values are: "json")</param>
        /// <param name="styleid">Required parameter: Vehicle style ID</param>
        /// <param name="zip">Required parameter: Five-digit zipcode</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetNewtotalcashpricebystyleidandzipAsync(
                string callback,
                string fmt,
                string styleid,
                string zip)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v1/api/tco/newtotalcashpricebystyleidandzip/{styleid}/{zip}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "styleid", styleid },
                { "zip", zip }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "callback", callback },
                { "fmt", fmt },
                { "api_key", Configuration.ApiKey }
            });

            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

        /// <summary>
        /// The Total Cash Price displayed is the vehicle's True Market Value® price plus the Typically Equipped options, destination charge, base tax and fees assessed by your state, and, if applicable, gas guzzler tax; less any widely available manufacturer-to-customer cash rebates. (However, we do not account for other types of cash rebates or incentives because of the variability of those offers and their eligibility requirements.)
        /// </summary>
        /// <param name="callback">Required parameter: The callback function that the JSON response will be wrapped in if desired</param>
        /// <param name="fmt">Required parameter: Response format (json only) (Acceptable values are: "json")</param>
        /// <param name="styleid">Required parameter: Vehicle style ID</param>
        /// <param name="zip">Required parameter: Five-digit zipcode</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetUsedtotalcashpricebystyleidandzipAsync(
                string callback,
                string fmt,
                string styleid,
                string zip)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v1/api/tco/usedtotalcashpricebystyleidandzip/{styleid}/{zip}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "styleid", styleid },
                { "zip", zip }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "callback", callback },
                { "fmt", fmt },
                { "api_key", Configuration.ApiKey }
            });

            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

        /// <summary>
        /// Get a list of vehicle makes with available True Cost to Own data
        /// </summary>
        /// <param name="callback">Required parameter: The callback function that the JSON response will be wrapped in if desired</param>
        /// <param name="fmt">Required parameter: Response format (json only) (Acceptable values are: "json")</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetmakeswithtcodataAsync(
                string callback,
                string fmt)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v1/api/tco/getmakeswithtcodata");


            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "callback", callback },
                { "fmt", fmt },
                { "api_key", Configuration.ApiKey }
            });

            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

        /// <summary>
        /// Get a list of vehicle models with available True Cost to Own data
        /// </summary>
        /// <param name="callback">Required parameter: The callback function that the JSON response will be wrapped in if desired</param>
        /// <param name="fmt">Required parameter: Response format (json only) (Acceptable values are: "json")</param>
        /// <param name="makeid">Required parameter: The Car Make ID</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetmodelswithtcodataAsync(
                string callback,
                string fmt,
                string makeid)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v1/api/tco/getmodelswithtcodata");


            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "callback", callback },
                { "fmt", fmt },
                { "makeid", makeid },
                { "api_key", Configuration.ApiKey }
            });

            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

        /// <summary>
        /// Get a list of vehicle styles with available True Cost to Own data
        /// </summary>
        /// <param name="callback">Required parameter: The callback function that the JSON response will be wrapped in if desired</param>
        /// <param name="fmt">Required parameter: Response format (json only) (Acceptable values are: "json")</param>
        /// <param name="make">Required parameter: Vehicle make niceName</param>
        /// <param name="makeyear">Required parameter: The vehicle make year</param>
        /// <param name="model">Required parameter: Vehicle model niceName</param>
        /// <param name="submodel">Required parameter: Vehicle submodel</param>
        /// <param name="year">Required parameter: Vehicle year (YYYY)</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetstyleswithtcodatabysubmodelAsync(
                string callback,
                string fmt,
                string make,
                string makeyear,
                string model,
                string submodel,
                string year)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v1/api/tco/getstyleswithtcodatabysubmodel");


            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "callback", callback },
                { "fmt", fmt },
                { "make", make },
                { "makeyear", makeyear },
                { "model", model },
                { "submodel", submodel },
                { "year", year },
                { "api_key", Configuration.ApiKey }
            });

            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

        /// <summary>
        /// Get the 5-year breakdown values of all TCO categories for a NEW vehicle based on its specified style Id, zip code, and state code.
        /// </summary>
        /// <param name="callback">Required parameter: The callback function that the JSON response will be wrapped in if desired</param>
        /// <param name="fmt">Required parameter: Response format (json only) (Acceptable values are: "json")</param>
        /// <param name="state">Required parameter: US State Code (e.g. CA, NY, NJ, PA, ...etc)</param>
        /// <param name="styleid">Required parameter: Vehicle style ID</param>
        /// <param name="zip">Required parameter: Five-digit zipcode</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetAllnewtcobystyleidzipandstateAsync(
                string callback,
                string fmt,
                string state,
                string styleid,
                string zip)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/tco/v1/details/allnewtcobystyleidzipandstate/{styleid}/{zip}/{state}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "state", state },
                { "styleid", styleid },
                { "zip", zip }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "callback", callback },
                { "fmt", fmt },
                { "api_key", Configuration.ApiKey }
            });

            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

        /// <summary>
        /// Get the 5-year breakdown values of all TCO categories for a USED vehicle based on its specified style Id, zip code, and state code.
        /// </summary>
        /// <param name="callback">Required parameter: The callback function that the JSON response will be wrapped in if desired</param>
        /// <param name="fmt">Required parameter: Response format (json only) (Acceptable values are: "json")</param>
        /// <param name="state">Required parameter: US State Code (e.g. CA, NY, NJ, PA, ...etc)</param>
        /// <param name="styleid">Required parameter: Vehicle style ID</param>
        /// <param name="zip">Required parameter: Five-digit zipcode</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> GetAllusedtcobystyleidzipandstateAsync(
                string callback,
                string fmt,
                string state,
                string styleid,
                string zip)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/api/tco/v1/details/allusedtcobystyleidzipandstate/{styleid}/{zip}/{state}");

            //process optional template parameters
            APIHelper.AppendUrlWithTemplateParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "state", state },
                { "styleid", styleid },
                { "zip", zip }
            });

            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "callback", callback },
                { "fmt", fmt },
                { "api_key", Configuration.ApiKey }
            });

            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" },
                { "accept", "application/json" }
            };

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Get(_queryUrl,_headers);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return APIHelper.JsonDeserialize<dynamic>(_response.Body);
            }
            catch (Exception ex)
            {
                throw new APIException("Failed to parse the response: " + ex.Message, _context);
            }
        }

    }
} 