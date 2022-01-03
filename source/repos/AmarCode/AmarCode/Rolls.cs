namespace AmarCode
{
    class Rolls : IFactory
    {
        public string GetType()
        {
            return "Rolls";
        }

        public int GetPrice()
        {
            return 30;
        }
    }
}