using System.Collections;

namespace PostService;

public class PostFetcherEnumerator : IEnumerator<IEnumerable<Post>>
{
    private List<Post>? _posts;

    private readonly PostFetcher _fetcher;
    
    public PostFetcherEnumerator(PostFetcher fetcher)
    {
        _fetcher = fetcher;
    }
    
    public bool MoveNext()
    {
        _posts = _fetcher.FetchChunk();
        return _posts != null;
    }

    public void Reset()
    {
        _posts = null;
    }

    public IEnumerable<Post> Current => _posts!;

    object IEnumerator.Current => Current;


    public void Dispose()
    {
        
    }
}