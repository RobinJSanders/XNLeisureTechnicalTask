namespace XNLeasureTechnicalTask.Services.Interfaces
{
    public interface ICharacterCountService
    {
        int GetNoOfCharacters(string input, char character, bool ignoreCase);
    }
}