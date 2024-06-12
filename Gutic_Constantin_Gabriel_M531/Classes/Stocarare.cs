namespace Gutic_Constantin_Gabriel_M531.Classes
{
    public static class Stocarare
    {
        public static List<Bank> Banks = new List<Bank>()
        {
            new Bank()
            {
                Id = new Guid("11111111-2222-3333-4444-555555555555"),
                Name = "BCR",
                Address = new Address()
                {
                    Street = "Palas",
                    Number = 10,
                    Apartment = "",
                },
                Clients = new List<Client> 
                { 
                    new Client()
                    {
                        Id = new Guid("00000000-2222-3333-4444-666666666666"),
                        LastName = "Gutic",
                        FirstName = "Gabriel",
                        Birthdate = DateTime.Now.AddYears(-20),
                        Address = new Address()
                        {
                            Street = "Mihai Eminescu",
                            Number = 14,
                            Apartment = "12C"
                        },
                        CreditType = "Debit",
                    },
                    new Client()
                    {
                        Id = new Guid("00000000-1111-3333-4444-666666666666"),
                        LastName = "Popescu",
                        FirstName = "Bogdan",
                        Birthdate = DateTime.Now.AddYears(-23),
                        Address = new Address()
                        {
                            Street = "Mihai Viteazu",
                            Number = 2,
                            Apartment = "11"
                        },
                        CreditType = "Credit",
                    }
                },
                GeneralInterest = 0.1M
            },
            new Bank()
            {
                Id = new Guid("11111111-2222-3333-4444-666666666666"),
                Name = "Transilvania",
                Address = new Address()
                {
                    Street = "Unirii",
                    Number = 3,
                    Apartment = "",
                },
                Clients = new List<Client>
                {
                    new Client()
                    {
                        Id = new Guid("00000000-1111-1111-4444-666666666666"),
                        LastName = "Cordunache",
                        FirstName = "Marius",
                        Birthdate = DateTime.Now.AddYears(-19),
                        Address = new Address()
                        {
                            Street = "Mihai Viteazu",
                            Number = 20,
                            Apartment = "15A"
                        },
                        CreditType = "Debit",
                    },
                    new Client()
                    {
                        Id = new Guid("55555555-1111-1111-4444-666666666666"),
                        LastName = "Iurascu",
                        FirstName = "Marian",
                        Birthdate = DateTime.Now.AddYears(-25),
                        Address = new Address()
                        {
                            Street = "Alexandru cel Bun",
                            Number = 5,
                            Apartment = ""
                        },
                        CreditType = "Debit",
                    }
                },
                GeneralInterest = 0.1M
            }
        };

        public static Bank GetBank(Guid bankId)
        {
            var bank = Banks.Find(b => b.Id == bankId);
            if (bank == null)
            {
                throw new Exception("Invalid bank id!");
            }
            return bank;
        }
    }
}
