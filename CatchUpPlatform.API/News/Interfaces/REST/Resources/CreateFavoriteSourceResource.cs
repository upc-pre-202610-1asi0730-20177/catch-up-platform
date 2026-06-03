using System.ComponentModel.DataAnnotations;
using Swashbuckle.AspNetCore.Annotations;

namespace CatchUpPlatform.API.News.Interfaces.REST.Resources;

/// <summary>
///     Represents the data required to create a favorite source.
/// </summary>
/// <param name="NewsApiKey">The News API Key provided by NewsAPI (required)</param>
/// <param name="SourceId">The source identifier from NewsAPI (required)</param> 
[SwaggerSchema(Description = "Request payload to create a favorite source")]
public record CreateFavoriteSourceResource(
    [Required]
    [SwaggerParameter(Description = "The News API Key provided by NewsAPI")]
    string NewsApiKey,
    [Required]
    [SwaggerParameter(Description = "The source identifier from NewsAPI")]
    string SourceId);

