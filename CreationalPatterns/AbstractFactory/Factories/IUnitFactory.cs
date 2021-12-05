﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns
{
    public interface IUnitFactory
    {
        public IArcher GetArcher(int range, int damage);
        public IChilivary GetChilivary(int damage);
    }
}
