﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIDemo.ExampleClasses
{
    public class ScopedDependencyExample : IScopedDependencyExample
    {
        public Guid ID { get; set; }

        public ScopedDependencyExample()
        {
            ID = Guid.NewGuid();
        }
    }
}
