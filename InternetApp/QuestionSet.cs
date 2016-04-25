namespace InternetApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QuestionSet")]
    public partial class QuestionSet
    {
        public QuestionSet()
        {
            AnswerSets = new HashSet<AnswerSet>();
        }

        public int Id { get; set; }

        [Required]
        public string Text { get; set; }

        public int Test_Id { get; set; }

        public virtual ICollection<AnswerSet> AnswerSets { get; set; }

        public virtual TestSet TestSet { get; set; }
    }
}
