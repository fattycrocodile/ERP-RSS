﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktura.Model
{
    public class Grupa
    {
        public Grupa()
        {
            //Artikls = new HashSet<Artikl>();
        }

        public int GrupaId { get; set; }
        public string Naziv { get; set; }
        public int? VrstaId { get; set; }
        public int? KlijentId { get; set; }
        public int? PorezId { get; set; }
        //public bool? Obrisan { get; set; }

        //public virtual Klijent Klijent { get; set; }
        //public virtual Porez Porez { get; set; }
        //public virtual Vrstum Vrsta { get; set; }
        //public virtual ICollection<Artikl> Artikls { get; set; }
    }
}
