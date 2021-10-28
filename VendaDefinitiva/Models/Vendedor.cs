using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace VendaDefinitiva.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        [Display(Name = "Data de nascimento")]
        public DateTime DataDeNascimento { get; set; }
        [Display(Name = "Base Salarial")]
        [DisplayFormat(DataFormatString ="{0:F2}")]
        public double SalarioBase{ get; set; }
        public Departamento Departamento { get; set; }
        public int DepartamentoId { get; set; }
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
