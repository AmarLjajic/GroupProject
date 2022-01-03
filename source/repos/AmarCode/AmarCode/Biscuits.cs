namespace AmarCode
{
    class Biscuits : IFactory
    {
        public string GetType()
        {
            return "Biscuits";
        }

        public int GetPrice()
        {
            return 35;
        }
    }
}