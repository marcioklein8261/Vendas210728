﻿using System;
using VendaDefinitiva.Models.Enums;

namespace VendaDefinitiva.Models
{
    public class RegistroDeVenda
    {
        public int Id {get; set; }
        public DateTime Data { get; set; }
        public StatusDaVenda  Status { get; set; }
        public Vendedor Vendedor { get; set; }
        public double Amount { get; set; }

        public RegistroDeVenda()
        {

        }

        public RegistroDeVenda(int id, DateTime data, StatusDaVenda status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Status = status;
            Vendedor = vendedor;
        }
    }

    

}
