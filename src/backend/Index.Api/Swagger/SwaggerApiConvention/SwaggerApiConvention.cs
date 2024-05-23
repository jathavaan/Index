namespace Index.Api.Swagger.SwaggerApiConvention;

public static class SwaggerApiConvention
{

    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status403Forbidden)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    [ApiConventionNameMatch(ApiConventionNameMatchBehavior.Any)]
    public static void StatusResponseTypes()
    {
    }
}