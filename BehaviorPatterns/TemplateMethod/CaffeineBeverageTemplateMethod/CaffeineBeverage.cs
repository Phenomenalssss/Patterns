namespace CaffeineBeverageTemplateMethod
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        protected abstract void Brew();

        protected abstract void AddCondiments();

        protected void BoilWater()
        {
            Console.WriteLine("Кипятим воду");
        }

        protected void PourInCup()
        {
            Console.WriteLine("Наливаем в чашку");
        }
    }
}
