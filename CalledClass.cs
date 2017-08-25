using System;

namespace ExternalLibrary
{
    internal static class CalledClass
    {
           public static string GetString(Type type) { return type.Name; }
    }
}