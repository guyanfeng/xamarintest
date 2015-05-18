using System;
using System.Collections.Generic;

namespace Test
{
    public class ClassAndSubclasses
    {
        public Type Type
        {
            get;
            private set;
        }

        public bool IsXamarinForms
        {
            get;
            private set;
        }

        public List<ClassAndSubclasses> Subclasses
        {
            get;
            private set;
        }

        public ClassAndSubclasses(Type parent, bool isXamarinForms)
        {
            Type = parent;
            IsXamarinForms = isXamarinForms;
            Subclasses = new List<ClassAndSubclasses>();
        }
    }
}

