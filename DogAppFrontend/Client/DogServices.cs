using System.Net.Http.Json;

namespace DogAppFrontend.Client
{
    public class DogService
    {
        private readonly HttpClient _httpClient;

        public DogService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Dog> GetRandomDog()
        {
            return await _httpClient.GetFromJsonAsync<Dog>("api/dogs/random");
        }
    }

    public class Dog
    {
        public string ImageUrl { get; set; }
        public string Breed { get; set; }
    }
}
