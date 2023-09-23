namespace CSharp23._09Animals
{
    public class CatCreator : AnimalCreator
    {
        public override AbstractAnimal CreateAnimal(int ind, string name)
        {
            switch (ind)
            {
                case 0:
                    return new Lion(name);
                case 1:
                    return new Tiger(name);
                default:
                    return new Leopard(name);
            }
        }
    }
    
    public class ApeCreator : AnimalCreator
    {
        public override AbstractAnimal CreateAnimal(int ind, string name)
        {
            switch (ind)
            {
                case 0:
                    return new Gorilla(name);
                case 1:
                    return new Orangutan(name);
                default:
                    return new Chimpanzee(name);
            }
        }
    }
}