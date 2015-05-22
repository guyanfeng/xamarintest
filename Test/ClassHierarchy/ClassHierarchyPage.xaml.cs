using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Reflection;
using Xamarin.Forms.Xaml;

namespace Test
{
    public partial class ClassHierarchyPage : ContentPage
    {
        public ClassHierarchyPage()
        {
            InitializeComponent();

            var types = new List<TypeInformation>();

            get_pulbic_type(typeof(View).GetTypeInfo().Assembly, types);

            get_pulbic_type(typeof(Extensions).GetTypeInfo().Assembly, types);

            int index = 0;
            // Watch out! Loops through expanding classList!
            do
            {
                // Get a child type from the list.
                TypeInformation childType = types[index];
                if (childType.Type != typeof(Object))
                {
                    bool hasBaseType = false;
                    foreach (TypeInformation parentType in types)
                    {
                        if (childType.IsDevivedFrom(parentType.Type))
                        {
                            hasBaseType = true;
                        }
                    }
                    // If there's no base type, add it.
                    if (!hasBaseType && childType.BaseType != typeof(Object))
                    {
                        types.Add(new TypeInformation(childType.BaseType, false));
                    }
                }
                index++;
            }
            while (index < types.Count);


            types.Sort((t1, t2) => string.Compare(t1.Type.Name, t2.Type.Name));

            var root = new ClassAndSubclasses(typeof(Object), false);
            add_children_to_parent(root, types);


            add_item_to_layout(root, 0);
        }

        void get_pulbic_type(Assembly assembly, List<TypeInformation> types)
        {
            foreach (var t in assembly.ExportedTypes)
            {
                var info = t.GetTypeInfo();
                if (info.IsPublic && !info.IsInterface)
                {
                    types.Add(new TypeInformation(t, true));
                }
            }
        }

        void add_children_to_parent(ClassAndSubclasses parent_class, List<TypeInformation> types)
        {
            foreach (var t in types)
            {
                if (t.IsDevivedFrom(parent_class.Type))
                {
                    var sub_class = new ClassAndSubclasses(t.Type, t.IsXamarinForms);
                    parent_class.Subclasses.Add(sub_class);
                    add_children_to_parent(sub_class, types);
                }
            }
        }

        void add_item_to_layout(ClassAndSubclasses parent_class, int level)
        {
            var name = parent_class.IsXamarinForms ? parent_class.Type.Name : parent_class.Type.FullName;

            var info = parent_class.Type.GetTypeInfo();
            if (info.IsGenericType)
            {
                var pas = info.GenericTypeParameters;
                name = name.Substring(0, name.Length - 2);//去掉最后的"[]"
                name += "<";
                foreach (var p in pas)
                {
                    name += p.Name + ",";
                }
                name = name.Substring(0, name.Length - 1) + ">";
            }
            //加上前置空格
            name = new string(' ', level * 8) + name;
            var clr = info.IsAbstract ? Color.Accent : Color.White;
            var lbl = new Label()
            {
                TextColor = clr,
                Text = name,
            };
            pal.Children.Add(lbl);

            level++;
            foreach (var child in parent_class.Subclasses)
            {
                add_item_to_layout(child, level);
            }
        }
    }
}

