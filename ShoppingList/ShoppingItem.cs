using System;
using System.Collections.Generic;

namespace ShoppingList
{
    internal sealed class ShoppingItem : IEquatable<ShoppingItem>
    {
        private readonly string name;

        public ShoppingItem(string name)
        {
            this.name = name;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as ShoppingItem);
        }


        public bool Equals(ShoppingItem other)
        {
            return other != null &&
                   name == other.name;
        }

        public override int GetHashCode()
        {
            return 363513814 + EqualityComparer<string>.Default.GetHashCode(name);
        }

        public override string ToString()
        {
            return name;
        }

        public static bool operator ==(ShoppingItem first, ShoppingItem second)
        {
            return EqualityComparer<ShoppingItem>.Default.Equals(first, second);
        }

        public static bool operator !=(ShoppingItem first, ShoppingItem second)
        {
            return !(first == second);
        }
    }
}