using UnityEngine;

public class QuitCommand : ICommand
{
	public object Data { get; set; }
	public EventDispatcher Dispatcher { get; set; }

	public void Init()
	{
	}

	public void Execute(IEvent evt)
	{
		Debug.Log("Quiting game...");
		Application.Quit();
	}
}