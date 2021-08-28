﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace VendaDefinitiva.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public double SalarioBase{ get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<RegistroDeVenda> Vendas { get; set; } = new List<RegistroDeVenda>();

        public Vendedor()
        {

        }

        public Vendedor(int id, string nome, string email, DateTime dataDeNascimento, double salarioBase, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataDeNascimento = dataDeNascimento;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AdicionarVenda(RegistroDeVenda sr)
        {
            Vendas.Add(sr);
        }

        public void RemoverVenda(RegistroDeVenda sr)
        {
            Vendas.Remove(sr);
        }

        public double VendaTotal(DateTime inicial, DateTime final)
        {
            return Vendas.Where(sr => sr.Data >= inicial &&
            sr.Data <= final).Sum(sr => sr.Amount);
        }
    }
}
