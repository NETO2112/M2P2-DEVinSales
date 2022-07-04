namespace DevInSales.Application.Dtos
{
    public record UpdateAddress(string? Street, int? Number, string? Complement, string? Cep) { }
}
