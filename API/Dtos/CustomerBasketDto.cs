using System.ComponentModel.DataAnnotations;

namespace API.Dtos;

public record CustomerBasketDto
{
    [Required]
    public string Id { get; set; } = string.Empty;

    public List<BasketItemDto> BasketItems { get; set; } = new();
}