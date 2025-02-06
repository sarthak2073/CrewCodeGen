using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Sample.Core
{
    /// <summary>
    /// Represents the service connection object for interacting with an external service.
    /// </summary>
    public class SampleService
    {
        private readonly HttpClient _httpClient;

        public SampleService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// Gets data from the service using the specified endpoint.
        /// </summary>
        /// <param name="endpoint">The endpoint to fetch data from.</param>
        /// <returns>The response data as a string.</returns>
        public async Task<string> GetServiceData(string endpoint)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(endpoint);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }

            throw new Exception("Failed to retrieve data from the service.");
        }
    }
}