using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao
{
    public class Lamport
    {
        List<Tuple<int,int>> t = new List<Tuple<int,int>>();
        List<Tuple<int,bool>> e = new List<Tuple<int,bool>>();

        public void Verificar(int id)
        {
            e.Add(new Tuple<int, bool>(id,true));
            int max = 0;
            for (int i = 0; i < 5; i++)
            {
                if (t.Count != 0)
                {
                    var atual = t[0].Item1;
                    if (atual > max)
                    {
                        max = atual;
                    }
                }
            }
            t.Add(new Tuple<int, int>(id, 1 + max));
            

        }
    }
}
