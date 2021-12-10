using System;
using VendaDefinitiva.Models.Enums;
using System.ComponentModel.DataAnnotations;
namespace VendaDefinitiva.Models
{
    public class RegistroDeVenda
    {

        public int Id { get; set; }

      //  [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Data { get; set; }
        public StatusDaVenda Status { get; set; }
        public Vendedor Vendedor { get; set; }

     //   [DataFormat(DataFormatString="{0:F2}")]
        public double Amount { get; set; }
        public double ValorDaVenda { get; set; }
        
        public RegistroDeVenda()
        {

        }

        public RegistroDeVenda(int id, DateTime data, double amount, StatusDaVenda status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Status = status;
            Amount= amount;
            Vendedor = vendedor;
        }
    }

    

}
