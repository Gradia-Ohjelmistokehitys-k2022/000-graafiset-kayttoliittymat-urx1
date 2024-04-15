using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegaatitJaEventit
{
    public class Tuote
    {
        string _nimi;
        int _paino;
        int _lukumaara;
        DateTime _hakupaiva;


        public Tuote(string nimi, int paino, int lukumaara, DateTime hakupaiva) 
        {
            _nimi = nimi;
            _paino = paino;
            _lukumaara = lukumaara;
            _hakupaiva = hakupaiva;
        }
    }
}
