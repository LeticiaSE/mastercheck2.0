using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MasterCheck2._0
{
    class CRUD
    {

        BaseDeDatos db = new BaseDeDatos();
        public void Lista()
        {
            string consulta = string.Format("SELECT idrfid * FROM registros");
            
        }
    }
}
