using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_ClassEncapsulation
{
    class Kisi
    {
        public int Id { get; set; }
        private string _adi;
        public string Adi
        {
            get
            {
                string ilkHarf = _adi.Substring(0, 1).ToUpper();
                string gerikalan = _adi.Substring(1).ToLower();
                _adi = ilkHarf + gerikalan;
                return _adi;
            }

            set
            {
                _adi = value;
            }
        }

        private string _soyadi;
        public string Soyadi
        {
            get
            {
                return _soyadi.ToUpper();
            }
            set
            {
                _soyadi = value;
            }
        }


    }
}
