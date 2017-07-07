using System;

namespace NetFrameworkLibrary
{
    public static class StringProvider
    {
        public static string GetHelloWorldString(string name)
        {
            return $"Hello {name}!";
        }
    }
}
