using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_OPP;

public struct Book
{
    public string Adı;
    public string Yazar;
    public int SayfaSayısı;

    public override string ToString()
    {
        return $"KİTAP ADI: {Adı},KİTAP YAZARI: {Yazar},KİTABIN SAYFA SAYISI: {SayfaSayısı}";
    }
}
