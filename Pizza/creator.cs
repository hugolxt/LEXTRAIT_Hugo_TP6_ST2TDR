using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEXTRAIT_Hugo_TP6_ST2TDR
{
    interface Creator
    {
        void deletePizza() { }
        void setName(string name) { }
        void setSize(string size) { }
        void setDough(string dough) { }
        void setTopping(string[] topping) { }

    }
}
