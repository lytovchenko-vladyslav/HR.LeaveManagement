namespace HR.LeaveManagement.Application.Loging;

public interface IAppLogger<T>
{
    void LogInformation(string message, params object[] args);
    void LogWarnings(string message, params object[] args);
}