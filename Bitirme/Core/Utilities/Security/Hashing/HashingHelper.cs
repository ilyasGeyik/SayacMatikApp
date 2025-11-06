using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        public static void CreatePasswordHash(string sifre,out byte[] sifreHash,out byte[] sifreSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                sifreSalt = hmac.Key;
                sifreHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(sifre));
            }
        }
        public static bool VerifyPasswordHash(string sifre, byte[] sifreHash, byte[] sifreSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(sifreSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(sifre));

                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != sifreHash[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
