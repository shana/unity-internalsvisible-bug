using System;

namespace ExternalLibrary
{
    internal class CalledClass
    {
        public static string StaticProp { get; } = IndirectCalledClass.GetString<CalledClass>();        
    }
}