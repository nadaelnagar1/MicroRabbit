namespace MicroRabbit.Transfer.Domain.Models
{
    public class TransferLog
    {
        public int Id { get; set; }
        public int FromAcoount { get; set; }
        public int ToAccount { get; set; }
        public decimal TransferAmount { get; set; }
       
    }
}
