using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3_Static;

public static class SecurityHelper
{
//Şifreye ihtiyacım var
//PasswordHash
//PasswordSalt
//Hash için kullanılabilecek bazı algoritmalar...Hmac512,HmacSha256

    public static void CreatePasswordHash(string password,out byte[] passwordHash,out byte[] passwordSalt)
    {
        using (var hmac = new System.Security.Cryptography.HMACSHA512())
        {
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
        }
    }

}
