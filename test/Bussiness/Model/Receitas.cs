using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace test.Bussiness.Model
{
    [XmlRoot(ElementName = "Receitas")]
    public class Receitas
    {
        [XmlElement(ElementName = "Ingrediente")]
        public string Ingrediente { get; set; }
        [XmlElement(ElementName = "Qtd")]
        public string Qtd { get; set; }
    }
}