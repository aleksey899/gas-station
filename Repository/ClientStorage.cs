﻿using gas_station.Domain;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace gas_station.Repository
{
    public class ClientStorage
    {
        private Dictionary<int, Client> Clients { get; } = new Dictionary<int, Client>();
        //private SqlConnection Connection { get; } = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;");
        //public ClientStorage() => Connection.Open();

        public void Create(Client client)
        {
            Clients.Add(client.ClientId, client);
            //var command = Connection.CreateCommand();
            //command.CommandText = "SELECT * FROM .....";
            //command.ExecuteNonQuery
            //command.ExecuteReader
            //command.ExecuteScalar
        }

        public Client Read(int ClientId)
        {
            return Clients[ClientId];
        }

        public Client Update(int ClientId, Client newClient)
        {
            Clients[ClientId] = newClient;
            return Clients[ClientId];
        }

        public bool Delete(int ClientId)
        {
            return Clients.Remove(ClientId);
        }
    }
}