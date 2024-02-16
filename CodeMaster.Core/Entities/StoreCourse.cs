﻿namespace CodeMaster.Core.Entities
{
    public partial class StoreCourse
    {
        public Guid Id { get; set; }

        public Guid CourseId { get; set; }

        public Guid CoursePriceId { get; set; }

        public Guid WebUserId { get; set; }

        public Guid OrderId { get; set; }

        public string CourseCode { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public decimal? SalePrice { get; set; }

        public decimal TotalPrice { get; set; }

        public decimal TotalSalePrice { get; set; }

        public string Name { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public int? NumberOfMonth { get; set; }

        public DateTime? LearningCourseExpired { get; set; }

        public bool? LearnInOrder { get; set; }

        public bool? IsFreeLearningUnit1Lesson1 { get; set; }

        public short ProductType { get; set; }

        public string CoursePriceName { get; set; }

        public Guid? ExamToolCategoryId { get; set; }

        public bool? IsMocktestType { get; set; }

        public Guid? ClassTypeId { get; set; }

        public virtual Order.Order Order { get; set; }
    }
}
