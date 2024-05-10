using RestApiTesting.Framework.Helpers;

namespace RestApiTesting.Framework.Services.Impl
{
    public class JsonPlaceHolderService: IJsonPlaceHolderService
    {
        public PostsControllerProxy PostsControllerProxy { get; set; }

        public JsonPlaceHolderService()
        {
            PostsControllerProxy = new PostsControllerProxy(ConfigurationHelper.TestApiUrl);
        }
    }
}
