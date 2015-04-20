﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArchAngel.Scripting.NHibernate.Model
{
    public class ReferenceBase
    {
        public ReferenceBase()
        {
        }

        public string Name { get; set; }
        public string Type { get; set; }
        public bool IsSetterPrivate { get; set; }
        public object ScriptObject { get; set; }
    }
}
