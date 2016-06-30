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
    public partial class MediaVehiclePhotoController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static MediaVehiclePhotoController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static MediaVehiclePhotoController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new MediaVehiclePhotoController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Get vehicle photos by Edmunds vehicle style ID
        /// </summary>
        /// <param name="callback">Required parameter: The callback function that the JSON response will be wrapped in if desired</param>
        /// <param name="fmt">Required parameter: Response format (json only) (Acceptable values are: "json")</param>
        /// <param name="styleId">Required parameter: Edmunds vehicle style ID</param>
        /// <return>Returns the dynamic response from the API call</return>
        public async Task<dynamic> FindphotosbystyleidAsync(
                string callback,
                string fmt,
                string styleId)
        {
            //the base uri for api requestss
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/v1/api/vehiclephoto/service/findphotosbystyleid");


            //process optional query parameters
            APIHelper.AppendUrlWithQueryParameters(_queryBuilder, new Dictionary<string, object>()
            {
                { "callback", callback },
                { "fmt", fmt },
                { "styleId", styleId },
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