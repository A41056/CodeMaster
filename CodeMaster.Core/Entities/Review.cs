﻿namespace CodeMaster.Core.Entities
{
    public partial class Review
    {
        public Guid Id { get; set; }

        public Guid CourseId { get; set; }

        public Guid? WebUserId { get; set; }

        public string FullName { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Content { get; set; }

        public decimal Rate { get; set; }

        public Guid? ImageFileId { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public int? SortOrder { get; set; }

        public short Status { get; set; }

        public string FullTextSearch { get; set; }

        public virtual Course.Course Course { get; set; }

        public virtual WebUser.WebUser WebUser { get; set; }
    }
}
