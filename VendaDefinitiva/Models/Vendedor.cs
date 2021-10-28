using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace VendaDefinitiva.Models
{
    public class Vendedor
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="{0}requered")]
        [StringLength(60, MinimumLength = 2, ErrorMessage = "{0} size should   be between{2} and {1}")]     
        public string Nome { get; set; }

        [Required(ErrorMessage = "{0}requered")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage ="{0} required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0}requered")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        [Display(Name = "Data de nascimento")]
        public DateTime DataDeNascimento { get; set; }

        [Required(ErrorMessage = "{0}requered")]
        [Range(100.0, 50000.0, ErrorMessage ="{0} deve ser entre {1} e {2}")]
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
