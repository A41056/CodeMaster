namespace CodeMaster.Core.Entities
{
    public partial class ReceiveInvoice
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public string Name { get; set; }

        public string TaxCode { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string Description { get; set; }

        public bool Status { get; set; }

        public string OrderCode { get; set; }

        public long? ReceiptCode { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public string FullTextSearch { get; set; }

        public virtual WebUser.WebUser User { get; set; }
    }
}
