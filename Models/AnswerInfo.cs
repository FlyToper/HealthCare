//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace 基于云的Web管理系统.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AnswerInfo
    {
        public long Id { get; set; }
        public Nullable<long> ForumInfoId { get; set; }
        public string Content { get; set; }
        public string FromNum { get; set; }
        public string FromName { get; set; }
        public Nullable<int> ToFloorNumber { get; set; }
        public string ToNum { get; set; }
        public string ToName { get; set; }
        public Nullable<int> FloorNumber { get; set; }
        public Nullable<System.DateTime> SubDate { get; set; }
        public Nullable<byte> DelFlag { get; set; }
        public string Remark { get; set; }
        public Nullable<long> UsefulCount { get; set; }
        public Nullable<long> UselessCount { get; set; }
    }
}
