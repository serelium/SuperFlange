﻿using SuperFlange.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFlange.ViewModel
{
    public class FlangeViewModel : ViewModel
    {
        private Flange _Flange;

        public FlangeViewModel()
        {
            Flange _Flange = new Flange();
        }
    }
}
