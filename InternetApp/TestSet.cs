namespace InternetApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TestSet")]
    public partial class TestSet
    {
        public TestSet()
        {
            QuestionSets = new HashSet<QuestionSet>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string BeginDate { get; set; }

        [Required]
        public string EndDate { get; set; }

        [Required]
        public string IsPublic { get; set; }

        public virtual ICollection<QuestionSet> QuestionSets { get; set; }
    }
}
