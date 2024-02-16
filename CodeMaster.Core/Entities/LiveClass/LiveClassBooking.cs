﻿namespace CodeMaster.Core.Entities.LiveClass
{
    public partial class LiveClassBooking
    {
        public Guid Id { get; set; }

        public Guid? ClassTypeId { get; set; }

        public Guid? LiveClassDetailId { get; set; }

        public Guid WebUserId { get; set; }

        public string CoursePriceName { get; set; }

        public Guid? CoursePriceId { get; set; }

        public Guid? CourseId { get; set; }

        public Guid OrderId { get; set; }

        public string CourseCode { get; set; }

        public string Name { get; set; }

        public DateTime? BlockStartDate { get; set; }

        public DateTime? BlockEndDate { get; set; }

        public bool Deleted { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public virtual LiveClassDetail LiveClassDetail { get; set; }
    }
}
