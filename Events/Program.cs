using Events;

ProcessBusinessLogic processBusinessLogic = new ProcessBusinessLogic();

processBusinessLogic.ProcessCompleted = bl_ProcessCompleted;

processBusinessLogic.StartProcess();
void bl_ProcessCompleted()
{
    Console.WriteLine("Method Invoked");
}