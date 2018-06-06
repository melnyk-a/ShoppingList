using System;
using System.Collections.Generic;

namespace ShoppingList
{
    internal sealed class ShoppingItemWrapper : IEquatable<ShoppingItemWrapper>
    {
        private readonly ShoppingItem item;

        public ShoppingItemWrapper(ShoppingItem item)
        {
            this.item = item;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as ShoppingItemWrapper);
        }

        public bool Equals(ShoppingItemWrapper other)
        {
            return other != null && item.Equals(other.item);
        }

        public override int GetHashCode()
        {
            return -1566986794 + EqualityComparer<ShoppingItem>.Default.GetHashCode(item);
        }

        public override string ToString()
        {
            return item.ToString();
        }

        public static bool operator ==(ShoppingItemWrapper first, ShoppingItemWrapper second)
        {
            return EqualityComparer<ShoppingItemWrapper>.Default.Equals(first, second);
        }

        public static bool operator !=(ShoppingItemWrapper first, ShoppingItemWrapper second)
        {
            return !(first == second);
        }
    }
}