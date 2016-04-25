namespace InternetApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AnswerSet")]
    public partial class AnswerSet
    {
        public int Id { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public string IsRight { get; set; }

        public int Question_Id { get; set; }

        public virtual QuestionSet QuestionSet { get; set; }
    }
}
