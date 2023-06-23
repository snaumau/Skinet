namespace API.Dtos;

public record AddressDto
{
    public string FirstName { get; set; } = string.Empty;
    
    public string LastName { get; set; } = string.Empty;
    
    public string Street { get; set; } = string.Empty;
    
    public string City { get; set; } = string.Empty;
    
    public string State { get; set; } = string.Empty;
    
    public string ZipCode { get; set; } = string.Empty;
}