namespace LifeBL.Check
{
    public enum TypeEnvironment
    {
        Land,
        Water
    }

    public class Environment
    {

        private TypeEnvironment _type;
        
        public TypeEnvironment Type
        {
            get => _type;
            set => _type = value;
        }

        public Environment()
        {
        }

        public Environment(TypeEnvironment type)
        {
            this.Type = type;
        }
    }
}