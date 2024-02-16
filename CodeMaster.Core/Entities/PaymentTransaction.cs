namespace CodeMaster.Core.Entities
{
    public partial class PaymentTransaction
    {
        public Guid Id { get; set; }

        public string OrderCode { get; set; }

        public string TransactionCode { get; set; }

        public string TraceId { get; set; }

        public string BankCode { get; set; }

        public string PaymentContent { get; set; }

        public string Status { get; set; }

        public DateTime? PayDate { get; set; }

        public string CardType { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public virtual Order.Order Order { get; set; }
    }
}
