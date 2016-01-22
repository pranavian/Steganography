using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steganography
{
    class Class1
    {
        private List<string> values = new List<String>();
        private List<int> IDs = new List<int>();

        public string getIDType(int inId)
        {
            string str = "";
            for (int i = 0; i < IDs.Count; i++)
            {
                if (IDs[i] == inId)
                {
                    str = values[i];
                }
            }
            return str;
        }
    }
}
