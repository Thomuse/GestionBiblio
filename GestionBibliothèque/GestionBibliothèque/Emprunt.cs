//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionBibliothèque
{
    using System;
    using System.Collections.Generic;
    
    public partial class Emprunt
    {
        public System.DateTime Date_Emprunt { get; set; }
        public Nullable<System.DateTime> Date_Retour { get; set; }
        public int Id_Lecteur { get; set; }
        public int Id_Exemp { get; set; }
        public Nullable<decimal> CA { get; set; }
    
        public virtual Exemplaire Exemplaire { get; set; }
        public virtual Lecteur Lecteur { get; set; }
    }
}
