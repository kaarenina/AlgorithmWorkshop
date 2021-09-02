using System;
using System.Collections.Generic;

namespace Isomorphic_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = IsIsomorphicStrings("egg", "add");
            System.Console.WriteLine(result);
        }

        public static bool IsIsomorphicStrings(string S, string T)
        {
            if(S.Length != T.Length)
                return false;
            
            var map1 = new Dictionary<char, char>();
            var map2 = new Dictionary<char, char>();

            for (int i = 0; i < S.Length; i++)
            {
                char c1 = S[i];
                char c2 = T[i];

                if(map1.ContainsKey(c1))
                {
                    if(c2 != map1[c1])
                        return false;
                }
                else
                {
                    if(map2.ContainsKey(c2))
                        return false;

                    map1[c1] = c2;
                    map2[c2] = c1;
                }
            } 

            return true;
        }
    }
}
