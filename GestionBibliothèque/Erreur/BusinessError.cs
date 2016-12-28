using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erreur
{
    public class BusinessError : Exception
    {
        private int _ID;
        private string _Message;

        public int ID
        {
            get { return _ID; }
        }

        public override string Message
        {
            get { return _Message; }
        }
        //case 1 : erreur 15456
        //case 2 : erreur 4060
        //case 3 : erreur créée
        public BusinessError(int pID)
        {
            string MyMessage;
            switch (pID){
                case 1:
                    MyMessage = "Problème de connexion.";
                    break;
                case 2:
                    MyMessage = "Base de Données indisponible.";
                    break;
                case 3:
                    MyMessage = "ID lecteur et/ou ID Exemplaire inconnu(s).";
                    break;
                default:
                    MyMessage = "Erreur non-connue.";
                    _ID = 999;
                    break;
            
            }
            _Message = MyMessage;
        }
    }
    }

