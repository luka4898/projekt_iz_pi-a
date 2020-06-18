﻿using OzoMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OzoMvc.ViewModels
{
    public class OpremaViewModel
    {

        public IEnumerable<Oprema> Oprema { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public OpremaFilter Filter { get; set; }
    }
}
