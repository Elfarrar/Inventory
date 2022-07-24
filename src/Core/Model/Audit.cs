using Model.Enums;

namespace Model
{
    public class Audit
    {

        public Guid Id { get; set; }
        public AuditType Type { get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public string SerializedData { get; set; }
    }
}
