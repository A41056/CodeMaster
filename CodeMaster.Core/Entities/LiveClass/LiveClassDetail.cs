﻿namespace CodeMaster.Core.Entities.LiveClass
{
    public partial class LiveClassDetail
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string LiveClassTypeName { get; set; }

        public Guid LiveClassTypeId { get; set; }

        public short Status { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public long? ClassinCourseId { get; set; }

        public Guid CreatedBy { get; set; }

        public Guid? ImageFileId { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public string FullTextSearch { get; set; }

        public virtual ICollection<LiveClassBooking> LiveClassBookings { get; set; } = new List<LiveClassBooking>();

        public virtual ICollection<LiveClassDetailTest> LiveClassDetailTests { get; set; } = new List<LiveClassDetailTest>();

        public virtual LiveClassType LiveClassType { get; set; }

        public virtual ICollection<LiveLessonDetail> LiveLessonDetails { get; set; } = new List<LiveLessonDetail>();
    }
}
