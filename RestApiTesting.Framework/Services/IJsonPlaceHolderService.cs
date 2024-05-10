using RestApiTesting.Framework.Services.Impl;

namespace RestApiTesting.Framework.Services
{
    public interface IJsonPlaceHolderService
    {
        PostsControllerProxy PostsControllerProxy { get; set; }
    }
}
