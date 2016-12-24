using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ExemplaireModel
    {
        public int _IdExemplaire { get; set; }
        public string _CodeExemplaire { get; set; }
        public bool _Emprunte { get; set; }
        public DateTime _DateAchat { get; set; }
        public int _Id_Biblio { get; set; }
        public int _Id_Livre { get; set; }

    }
}
