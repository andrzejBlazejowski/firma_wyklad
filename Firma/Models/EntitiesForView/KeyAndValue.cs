using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma.Models.EntitiesForView
{//to jest klasa ktora bedzie sluzyla glownie do przechowywania danych na przyklad w komboboxie
    public class KeyAndValue
    {
        public int Key { get; set; }//tu bedzie przechowywane na przyklad ID towaru
        public string Value { get; set; } // tu bedzie przechowywane na przyklad nazwa towaru
    }
}
