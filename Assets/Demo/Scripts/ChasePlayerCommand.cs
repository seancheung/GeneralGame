using System;

public class ChasePlayerCommand : ICommand
{
	public object Data { get; set; }
	public EventDispatcher Dispatcher { get; set; }

	public void Init()
	{
		
	}

	public void Execute(IEvent evt)
	{
		
	}
}