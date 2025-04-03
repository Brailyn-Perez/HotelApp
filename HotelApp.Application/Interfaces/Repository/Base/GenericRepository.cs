using HotelApp.Core.Domain.Interfaces;
using System.Net.Http.Json;

namespace HotelApp.Application.Interfaces.Repository.Base
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly HttpClient _httpClient;
        private readonly string _endpoint;

        public GenericRepository(HttpClient httpClient, string endpoint)
        {
            _httpClient = httpClient;
            _endpoint = endpoint;
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync(_endpoint);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<IEnumerable<T>>();
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            var response = await _httpClient.GetAsync($"{_endpoint}/{id}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<T>();
        }

        public virtual async Task<T> AddAsync(T entity)
        {
            var response = await _httpClient.PostAsJsonAsync(_endpoint, entity);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<T>();
        }

        public virtual async Task<bool> UpdateAsync(int id, T entity)
        {
            var response = await _httpClient.PutAsJsonAsync($"{_endpoint}/{id}", entity);
            return response.IsSuccessStatusCode;
        }

        public virtual async Task<bool> DeleteAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"{_endpoint}/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
