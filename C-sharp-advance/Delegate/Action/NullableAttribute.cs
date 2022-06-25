namespace System
{
    internal class NullableAttribute : Attribute
    {
        private int v;

        public NullableAttribute(int v)
        {
            this.v = v;
        }
    }
}