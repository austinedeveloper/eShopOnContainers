﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.eShopOnContainers.BuildingBlocks.Resilience.HttpResilience.Policies
{
    internal class CircuitBreakerPolicy : ResilientPolicy
    {
        public CircuitBreakerPolicy(int exceptionsAllowedBeforeBreaking, int durationOfBreakInMinutes)
        {
            ExceptionsAllowedBeforeBreaking = exceptionsAllowedBeforeBreaking;
            DurationOfBreakInMinutes = durationOfBreakInMinutes;
        }

        public int ExceptionsAllowedBeforeBreaking { get; }
        public int DurationOfBreakInMinutes { get; }
    }
}