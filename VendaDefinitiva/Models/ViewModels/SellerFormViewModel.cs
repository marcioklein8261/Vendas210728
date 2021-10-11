
using System.Collections.Generic;


namespace VendaDefinitiva.Models.ViewModels
{
    public class SellerFormViewModel
    {
        public Vendedor Vendedor { get; set; }
        public ICollection<Departamento> Departamentos { get; set; }
    }
}
