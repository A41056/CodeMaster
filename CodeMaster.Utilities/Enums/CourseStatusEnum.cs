using System.ComponentModel;

namespace CodeMaster.Utilities.Enums
{
    public enum CourseStatusEnum
    {
        [Description("Đang hoạt động")]
        Active = 1,

        [Description("Chưa kích hoạt")]
        InActive = 2,

        [Description("Dừng hoạt động")]
        StopWorking = 3
    }
}
