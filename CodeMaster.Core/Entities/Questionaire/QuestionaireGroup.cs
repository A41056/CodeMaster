﻿namespace CodeMaster.Core.Entities.Questionaire
{
    public partial class QuestionnaireGroup
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Level { get; set; }

        public Guid? ParentIdOne { get; set; }

        public Guid? ParentIdTwo { get; set; }

        public Guid? ParentIdThree { get; set; }

        public Guid? ParentIdFour { get; set; }

        public string ParentNameOne { get; set; }

        public string ParentNameTwo { get; set; }

        public string ParentNameThree { get; set; }

        public string ParentNameFour { get; set; }

        public string Identifier { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public string FullTextSearch { get; set; }

        public virtual ICollection<QuestionnaireGroup> InverseParentIdOneNavigation { get; set; } = new List<QuestionnaireGroup>();

        public virtual QuestionnaireGroup ParentIdOneNavigation { get; set; }

        public virtual ICollection<Questionnaire> Questionnaires { get; set; } = new List<Questionnaire>();
    }
}
