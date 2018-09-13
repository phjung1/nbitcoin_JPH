using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NBitcoin;

namespace NBitcoin_jph
{
    class Program
    {
        static void Main(string[] args)
        {
            Key privateKey = new Key();
            PubKey publicKey = privateKey.PubKey;
            Console.WriteLine(publicKey);

            Console.WriteLine(Network.Main);
            Console.WriteLine(Network.TestNet);

        }
    }
}
