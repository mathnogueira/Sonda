namespace Domain.Parser
{
    public interface ConfigurationParser
    {
        ProblemConfiguration Parse(string configuration);
    }
}
