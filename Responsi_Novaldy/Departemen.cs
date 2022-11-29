using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi_Novaldy
{
    internal class Departemen
    {
        private int _idDep
        { get; set; }
        public string _namaDep
        { get; set; }

        public void GetDepartemen(int idDep, string namaDep)
        {
            _idDep = idDep;
            _namaDep = namaDep;
        }
    }
}
