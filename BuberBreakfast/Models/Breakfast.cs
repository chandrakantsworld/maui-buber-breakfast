namespace BuberBreakfast.Models;

public record Breakfast(
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    string Image,
    List<string> Savory,
    List<string> Sweet);

