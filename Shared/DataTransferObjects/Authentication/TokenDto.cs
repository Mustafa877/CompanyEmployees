using System.ComponentModel.DataAnnotations;

namespace Shared.DataTransferObjects;

public record TokenDto(string AccessToken, string RefreshToken);

