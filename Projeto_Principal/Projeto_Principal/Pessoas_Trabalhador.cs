//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projeto_Principal
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pessoas_Trabalhador
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pessoas_Trabalhador()
        {
            this.Pedidos = new HashSet<Pedido>();
        }
    
        public decimal Salario { get; set; }
        public string Posicao { get; set; }
        public int IdRestaurante { get; set; }
        public int Id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pedido> Pedidos { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual Restaurante Restaurante { get; set; }
    }
}
