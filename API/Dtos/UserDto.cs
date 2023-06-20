namespace API.Dtos;

public record UserDto
{
    public string Email { get; set; } = string.Empty;

    public string DisplayName { get; set; } = string.Empty;

    public string Token { get; set; } = string.Empty;
}