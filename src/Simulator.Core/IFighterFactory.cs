﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator.Core
{
    public interface IFighterFactory
    {
        IFighter CreateFighter(int fighterClass, string team);
    }
}
