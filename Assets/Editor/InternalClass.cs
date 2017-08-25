namespace DefaultNamespace
{
    class InternalClass
    {
        public string AProp {
            get
            {
                new ExternalLibrary.CalledClass();
                return "something";
            }
        }
    }
}