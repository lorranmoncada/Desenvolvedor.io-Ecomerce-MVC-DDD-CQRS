using EventStore.ClientAPI;
using Microsoft.Extensions.Configuration;

namespace EventSourcing
{
    public class EventStoreService : IEventStoreService
    {
        private readonly IEventStoreConnection _connection;

        public EventStoreService(IConfiguration _configuration)
        {
            // essa conexão tem que er imutável por isso ela é um singleton em startup
            _connection = EventStoreConnection.Create(_configuration.GetConnectionString("EventStoreConnection"));
            _connection.ConnectAsync();
        }
        public IEventStoreConnection GetConnection()
        {
            return _connection;
        }
    }
}
