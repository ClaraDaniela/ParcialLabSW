﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_parcial_solid_transporte
{
    internal interface TransporteAereo : ITransporte
    {
        void Volar(int altitud);
    }
}
