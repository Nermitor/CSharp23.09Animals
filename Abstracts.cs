namespace CSharp23._09Animals
{
    public abstract class AbstractAnimal
    {
        public abstract string GetInfo();
    }

    public abstract class AnimalCreator
    {
        public abstract AbstractAnimal CreateAnimal(int ind, string name);

        public AbstractAnimal[] GetZoo(int[] inds, string[] names)
        {
            AbstractAnimal[] animals = new AbstractAnimal[inds.Length];

            for (int i = 0; i < inds.Length; i++)
            {
                animals[i] = CreateAnimal(inds[i], names[i]);
            }

            return animals;
        }
    }
}