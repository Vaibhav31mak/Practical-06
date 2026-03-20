namespace Events;

internal class ProcessBusinessLogic
{
    public Action ProcessCompleted;

    // Start Process - To invoke the onProcessCompleted() method.
    // Return Type - void
    public void StartProcess()
    {
        Console.WriteLine("Process Started");
        OnProcessCompleted();
    }
    // Start Process - To invoke the ProcessCompleted Action.
    // Return Type - void
    protected virtual void OnProcessCompleted() 

    {
        //if ProcessCompleted is not null then calling the delegate
        ProcessCompleted?.Invoke();
    }


}
