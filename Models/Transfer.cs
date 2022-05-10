namespace SampleAutomationFramework.Models
{
    public class Transfer
    {
        public string TransferFrom;
        public string TransferTo;
        public string Address;
        public string Amount;
        public Transfer(string transferFrom, string transferTo, string address, string amount)
        {
            TransferFrom = transferFrom;
            TransferTo = transferTo;
            Address = address;
            Amount = amount;
        }
    }
}
