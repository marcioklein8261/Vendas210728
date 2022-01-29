using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace VendaDefinitiva.Models
{
    public class Produto
    {
        [Key]
        public int Id{ get; set; }

        [Required(ErrorMessage = "{0}requered")]
        [StringLength(60, MinimumLength = 2, ErrorMessage = "{0} size should   be between{2} and {1}")]

        public string NomeProduto { get; set; }
        public string UnidadeProduto { get; set; }


        public Produto()
        {

        }

        public Produto(int id, string nomeProduto, string unidadeProduto, Departamento departamento)
        {
            Id = id;
            NomeProduto = nomeProduto;
            UnidadeProduto = unidadeProduto;
            Departamento = departamento;
        }
        public Departamento Departamento { get; set; }
        public int DepartamentoId { get; set; }

    }
}
