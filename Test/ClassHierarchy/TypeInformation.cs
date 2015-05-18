using System;
using System.Reflection;

namespace Test
{
    public class TypeInformation
    {
        readonly bool is_base_type_generic;
        readonly Type base_type_gen_def;

        public Type Type
        {
            get;
            private set;
        }

        public Type BaseType
        {
            get;
            private set;
        }

        public bool IsXamarinForms
        {
            get;
            private set;
        }

        public TypeInformation(Type type, bool isXamarinForms)
        {
            Type = type;
            IsXamarinForms = isXamarinForms;

            var type_info = type.GetTypeInfo();
            BaseType = type_info.BaseType;

            if (BaseType != null)
            {
                var base_type_info = BaseType.GetTypeInfo();
                if (base_type_info.IsGenericType)
                {
                    is_base_type_generic = true;
                    base_type_gen_def = base_type_info.GetGenericTypeDefinition();
                }
            }
        }

        public bool IsDevivedFrom(Type parent)
        {
            if (BaseType != null && is_base_type_generic)
            {
                if (base_type_gen_def == parent)
                    return true;
            }
            else if (BaseType == parent)
            {
                return true;
            }
            return false;
        }

    }
}

