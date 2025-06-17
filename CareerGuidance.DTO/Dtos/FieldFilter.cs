using EducationChallengerBE.Shared.Enum;

namespace EducationChallengerBE.Shared.Dtos
{
    public class FieldFilter
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public FilterFieldType FieldType { get; set; }
        public FilterLogicalOperatorType LogicalOperatorType { get; set; }
        public FilterConditionalOperatorType ConditionalOperatorType { get; set; }
        public OrderType Order { get; set; }
    }
}
