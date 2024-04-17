using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorttiNS;

public class Kortti
{
    public Image _etukuva;
    public Image _takakuva = Image.FromFile("C:\\Users\\Koti\\Documents\\GitHub\\000-graafiset-kayttoliittymat-urx1\\15_Lopputyo\\Muistipeli\\kuvia\\valkoinen.png");
    public bool _loydetty = false;
    
    public Kortti(Image etukuva)
    {
        _etukuva = etukuva;
    }
}
