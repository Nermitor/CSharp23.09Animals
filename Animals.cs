namespace CSharp23._09Animals
{
    
    public class AnimalBase : AbstractAnimal
    {
        protected string name;

        public AnimalBase(string name)
        {
            this.name = name;
        }
        
        public override string GetInfo()
        {
            return $"{this.GetType().Name} {name}";
        }
    }
    
    public class Lion : AnimalBase
    {
        public Lion(string name) : base(name){}
    }

    public class Tiger : AnimalBase
    {
        public Tiger(string name) : base(name){}
    }
    
    public class Leopard : AnimalBase
    {
        public Leopard(string name) : base(name){}
    }
    
    public class Gorilla : AnimalBase
    {
        public Gorilla(string name) : base(name){}
    }
    
    public class Orangutan : AnimalBase
    {
        public Orangutan(string name) : base(name){}
    }
    
    public class Chimpanzee  : AnimalBase
    {
        public Chimpanzee (string name) : base(name){}
    }
    
}