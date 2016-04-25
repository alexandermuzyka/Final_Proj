namespace InternetApp
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TestsContext : DbContext
    {
        public TestsContext()
            : base("name=TestsContext")
        {
        }

        public virtual DbSet<AnswerSet> AnswerSets { get; set; }
        public virtual DbSet<QuestionSet> QuestionSets { get; set; }
        public virtual DbSet<TestSet> TestSets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QuestionSet>()
                .HasMany(e => e.AnswerSets)
                .WithRequired(e => e.QuestionSet)
                .HasForeignKey(e => e.Question_Id)
                .WillCascadeOnDelete(false);
            modelBuilder.Entity<TestSet>()
                .HasMany(e => e.QuestionSets)
                .WithRequired(e => e.TestSet)
                .HasForeignKey(e => e.Test_Id)
                .WillCascadeOnDelete(false);
        }
    }
}
