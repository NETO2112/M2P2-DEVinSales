namespace DevInSales.Application.Dtos
{
    public record AddAddress(string Street, int Number, string? Complement, string Cep) { }
}
