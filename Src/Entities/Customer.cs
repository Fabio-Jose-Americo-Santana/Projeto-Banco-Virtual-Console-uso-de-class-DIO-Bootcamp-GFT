using System;

namespace Projeto_Banco__uso_de_class__DIO_Bootcamp_GFT.Src.Entities
{
    internal class Customer
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string InitialsName { get; set; }
        public long Document { get; set; }

        public Customer(string name, string lastName, long document)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Document = document;

            InitialsName = name.Substring(0, 1) + lastName.Substring(0, 1);

        }
    }
}
