//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    
    public partial class Liste_EmpruntsAvecTarifs_Result
    {
        public string Nom { get; set; }
        public string Titre { get; set; }
        public string Code_Exemp { get; set; }
        public string Nom_biblio { get; set; }
        public System.DateTime Date_Emprunt { get; set; }
        public Nullable<System.DateTime> Date_Retour { get; set; }
        public decimal Prix_Emprunt { get; set; }
    }
}
