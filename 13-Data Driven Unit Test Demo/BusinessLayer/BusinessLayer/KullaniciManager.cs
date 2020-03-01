﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class KullaniciManager
    {
        public bool KullaniciEkle(string ad,string tel,string email)
        {
            if (ad.Length <= 3) return false;
            if (!System.Text.RegularExpressions.Regex.IsMatch(tel, "[0-9]")) return false;
            if (!email.Contains("@")) return false;

            return true;
        }
    }
}
