﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace poligonotiro.Models.ViewModels
{
    public class ListaLineaTiro
    {
        public int Idlineatiro { get; set; }
        public string nombre { get; set; }



        public decimal costopack { get; set; }

    }

}