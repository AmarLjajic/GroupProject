namespace AmarCode
{
    class LoafBreads : IFactory
    {
        public string GetType()
        {
            return "LoafBreads";
        }

        public int GetPrice()
        {
            return 20;
        }
    }
}