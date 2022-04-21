using PostService;


var list = new List<Post>()
{
    new Post("a", "b", DateTime.Now), 
    new Post("a", "b", DateTime.Now), 
    new Post("a", "b", DateTime.Now), 
    new Post("a", "b", DateTime.Now), 
    new Post("a", "b", DateTime.Now), 
    new Post("b", "b", DateTime.Now), 
    new Post("b", "b", DateTime.Now), 
    new Post("b", "b", DateTime.Now), 
    new Post("b", "b", DateTime.Now), 
    new Post("b", "b", DateTime.Now), 
    new Post("c", "b", DateTime.Now), 
    new Post("c", "b", DateTime.Now), 
    new Post("c", "b", DateTime.Now), 
};

var fetcher = new PostFetcher(list);


foreach (var hello in fetcher)
{
    foreach (var post in hello)
    {
        Console.WriteLine(post.Sender);
    }
    Console.WriteLine(new string('-', 10));
}

foreach (var hello in fetcher)
{
    foreach (var post in hello)
    {
        Console.WriteLine(post.Sender);
    }
    Console.WriteLine(new string('-', 10));
}




