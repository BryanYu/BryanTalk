namespace Talk.DataAccess.Interfaces
{
    public interface IUserDataAccess
    {
        bool Verify(string account, string password);
    }
}