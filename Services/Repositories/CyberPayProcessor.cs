
using ITHub.Models.Dto;
using ITHub.Models.Entity;
using ITHub.Services.Interfaces;
using System.Text.Json;
using System.Net.Http;
using System.Text;

namespace ITHub.Services.Repositories
{
    public class CyberPayProcessor : IPaymentManagement
    {     

        public CyberPayProcessor()
        {

        }
        public async Task<Response> ProcessPaymentAsync(string processorType, PaymentRequestDto model, PaymentGatewayConfigDto config)
        {
            Response response = new Response();

            try
            {
                
                model.IntegrationKey = config.IntegrationKey;

                var jsonString = JsonSerializer.Serialize(model);
                var client = new HttpClient();

                var request = new HttpRequestMessage(HttpMethod.Post, config.GatewayUrl);

                // Set the API key in the headers
                request.Headers.Add(config.Apikey,config.ApiSecret); //"MDc4YjQ4YTVjNjQ0NDJkZGI2M2FjM2QxZjA2MDQxNTM="//

                // Specify the Content-Type as application/json explicitly
                var content = new StringContent(jsonString, Encoding.UTF8, "application/json");

                // Assign the content to the request
                request.Content = content;

                // Send the request and ensure it is successful
                var result = await client.SendAsync(request);
                result.EnsureSuccessStatusCode();

                // Process the result

                 
                response.Data = await result.Content.ReadAsStringAsync();
                response.Message = $"{processorType}: Using {processorType}";
                response.Code = 200;
            }
            catch (Exception ex)
            {

                response.Data = null;
                response.Message = $"{processorType}: {ex.Message}";
                response.Code = 404;
            }

            return response;
        }

    }
}
