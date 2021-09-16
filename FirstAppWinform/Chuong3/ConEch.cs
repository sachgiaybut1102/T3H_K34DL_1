using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppWinform.Chuong3
{
    public class ConEch : IDongVatDuoiNuoc, IDongVatTrenCan
    {
        public void Boi()
        {
            Console.WriteLine("");
        }

        public void Di()
        {
            Console.WriteLine("ech dang di");
        }

        public void Lan()
        {
            throw new NotImplementedException();
        }

        public void Nhay()
        {
            throw new NotImplementedException();
        }
    }
}
