﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktura.Model.Requests
{
    public class VrstaPlacanjaInsertUpdate
    {        
        public string Naziv { get; set; }
        public int? KlijentId { get; set; }
        public int? FiskalniBroj { get; set; }
    }
}
