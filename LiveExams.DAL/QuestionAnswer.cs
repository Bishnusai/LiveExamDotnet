//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LiveExams.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class QuestionAnswer
    {
        public long AnswerID { get; set; }
        public long QuestionID { get; set; }
        public string Answer { get; set; }
        public Nullable<bool> IsRightAnswer { get; set; }
        public int AnswerOrder { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        public virtual Question Question { get; set; }
    }
}