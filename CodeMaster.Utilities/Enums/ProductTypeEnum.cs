using System.ComponentModel;

namespace CodeMaster.Utilities.Enums
{
    public enum ProductTypeEnum
    {
        [Description("Khóa tự học")]
        SelfStudyCourse = 1,

        [Description("Công cụ ôn thi")]
        ExamTool,

        [Description("Học cùng giáo viên")]
        LearnWithTeacher,

        [Description("Thi thử online")]
        MockTest
    }
}
