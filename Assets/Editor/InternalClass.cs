namespace DefaultNamespace
{
    class InternalClass
    {
        public string AProp { get { return ExternalLibrary.CalledClass.GetString(GetType()); }}
    }
}