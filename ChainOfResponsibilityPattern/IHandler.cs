namespace ChainOfResponsibilityPattern;

public interface IHandler
{
    void SetNext(IHandler handler);
    
    
}