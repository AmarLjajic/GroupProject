namespace AmarCode
{
    class Buns : IFactory
    {
        public string GetType()
        {
            return "Buns";
        }

        public int GetPrice()
        {
            return 20;
        }
    }
}