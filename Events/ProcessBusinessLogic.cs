namespace Events;

internal class ProcessBusinessLogic
{
    public Action? ProcessCompleted;

    /// <summary>
    /// Starts the process.
    /// Return Type: void
    /// </summary>
    public void StartProcess()
    {
        Console.WriteLine("Process Started");
        OnProcessCompleted();
    }
    /// <summary>
    /// Raises the event and invokes.
    /// </summary>
    protected virtual void OnProcessCompleted() 
    {
        //if ProcessCompleted is not null then calling the delegate
        ProcessCompleted?.Invoke();
    }


}
