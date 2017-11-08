using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    class DBerror
    {
        string Error="";
        public void CatchError(string Error)
        {
            this.Error = Error;
        }

        public string getError() {
            return Error;
        }

    }

    
}
