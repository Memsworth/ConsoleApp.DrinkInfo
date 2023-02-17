public static class Client
{
    public static HttpClient ApiClient { get; private set; }

    public static void InitializeClient(string url)
    {
        ApiClient = new HttpClient
        {
            BaseAddress = new Uri(url)
        };
        ApiClient.DefaultRequestHeaders.Clear();
    }
}