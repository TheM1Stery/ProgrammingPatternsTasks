using System.Collections;

namespace PostService;

public class PostFetcher : IPostFetcher
{
    private readonly List<Post> _post;

    private int _postFetched;
    
    
    public IEnumerator<IEnumerable<Post>> GetEnumerator()
    {
        return new PostFetcherEnumerator(this);
    }

    public PostFetcher(List<Post> post)
    {
        _post = post;
        _postFetched = 0;
    }
    

    public List<Post>? FetchChunk()
    {
        if (_postFetched >= _post.Count)
        {
            _postFetched = 0;
            return null;
        }
        
        if (_postFetched + 5 < _post.Count)
        {
            var list = _post.GetRange(_postFetched, 5);
            _postFetched += 5;
            return list;
        }
        var list2 = _post.GetRange(_postFetched,_post.Count - _postFetched);
        _postFetched += (_post.Count - _postFetched);
        return list2;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}