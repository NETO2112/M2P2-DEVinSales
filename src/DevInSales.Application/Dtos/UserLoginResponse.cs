namespace DevInSales.Application.Dtos
{
    public class UserLoginResponse
    {
        public bool Success { get; private set; }
        public List<string> Error { get; private set; }
        public UserLoginResponse() => 
            Error = new List<string>();
        public UserLoginResponse(bool success = true) : this() =>
            Success = success;
        public void AddError(IEnumerable<string> error) =>
            Error.AddRange(error);
    }
}