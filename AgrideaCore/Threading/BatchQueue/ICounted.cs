﻿using Agridea.Diagnostics.Contracts;
using Agridea.Diagnostics.Logging;
using Agridea.Threading;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Agridea.Threading
{
    public interface ICounted
    {
        string Counter { get; set; }
    }
}
