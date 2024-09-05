namespace Pieces.OS.Client.Util;

public class EventWaiter<TEventArgs>(CancellationToken cancellationToken = default) where TEventArgs : EventArgs
{
    private TaskCompletionSource<TEventArgs> tcs = new(cancellationToken);

    public void EventRaised(object? sender, TEventArgs e)
    {
        tcs.TrySetResult(e);
    }

    public void EventRaisedWithError(object? sender, TEventArgs e)
    {
        IsError = true;
        tcs.TrySetResult(e);
    }

    public Task<TEventArgs> WaitForEventAsync() => tcs.Task;

    public void Reset()
    {
        tcs = new TaskCompletionSource<TEventArgs>();
    }

    public bool IsError { get; private set; }
}