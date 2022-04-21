namespace PostService;

public interface IPostFetcher : IEnumerable<IEnumerable<Post>>
{
    public List<Post>? FetchChunk();
}