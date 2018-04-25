using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesCrudLogPlusPlus
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            List<string> list2 = new List<string>();

            var query = from item in list
                        join item2 in list2 on item equals item2
                        into groupe
                        from c_joined in groupe.DefaultIfEmpty()
                        select new { };
            
            
        }
    }
}
