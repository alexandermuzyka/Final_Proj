//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InternetApp.App_Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Test
    {
        public Test()
        {
            this.Question = new HashSet<Question>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string BeginDate { get; set; }
        public string EndDate { get; set; }
        public string IsPublic { get; set; }
    
        public virtual ICollection<Question> Question { get; set; }
    }
}
