namespace DevInSales.Application.Dtos
{
    public class UserRegisterResponse
    {
        public bool Success { get; private set; }
        public List<string> Error { get; private set; }
        public UserRegisterResponse() => 
            Error = new List<string>();
        public UserRegisterResponse(bool success = true) : this() =>
            Success = success;
        public void AddError(IEnumerable<string> error) =>
            Error.AddRange(error);
    }
}