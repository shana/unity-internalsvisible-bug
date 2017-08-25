using System;

namespace ExternalLibrary
{
    internal static class IndirectCalledClass
    {
       public static string GetString<T>() { return typeof(T).ToString(); }
    }
}