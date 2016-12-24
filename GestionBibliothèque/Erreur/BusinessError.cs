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
        public BusinessError(int pID)
        {
            string MyMessage;
            switch (pID){
                default:
                    MyMessage = "Erreur non-connue.";
                    _ID = 999;
                    break;
            
            }
            _Message = MyMessage;
        }
    }
    }

