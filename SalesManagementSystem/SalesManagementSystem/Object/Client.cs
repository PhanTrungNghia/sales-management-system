using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.Object
{
    class Client
    {
        string idClient, nameClient, sexClient, addressClient,
            hotlineClient, emailClient, yearOfBirthClient;
        int scoreClient;
        string userName, password;   

        public Client()
        {
        }

        public Client(string idClient, string nameClient, string sexClient, string addressClient,
            string hotlineClient, string yearOfBirthClient, string emailClient, int scoreClient)
        {
            this.IdClient = idClient;
            this.NameClient = nameClient;
            this.SexClient = sexClient;
            this.AddressClient = addressClient;
            this.HotlineClient = hotlineClient;
            this.YearOfBirthClient = yearOfBirthClient;
            this.EmailClient = emailClient;
            this.ScoreClient = scoreClient;

        }

        public string IdClient { get => idClient; set => idClient = value; }
        public string NameClient { get => nameClient; set => nameClient = value; }
        public string SexClient { get => sexClient; set => sexClient = value; }
        public string AddressClient { get => addressClient; set => addressClient = value; }
        public string HotlineClient { get => hotlineClient; set => hotlineClient = value; }
        public int ScoreClient { get => scoreClient; set => scoreClient = value; }
        public string EmailClient { get => emailClient; set => emailClient = value; }
        public string YearOfBirthClient { get => yearOfBirthClient; set => yearOfBirthClient = value; }
    }
}
