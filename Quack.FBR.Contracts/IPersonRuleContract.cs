namespace Quack.FBR.Contracts
{
    public interface IPersonRuleContract : IRule
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }
    }
}