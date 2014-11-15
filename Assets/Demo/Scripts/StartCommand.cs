using UnityEngine;

public class StartCommand : ICommand
{
	public object Data { get; set; }
	public EventDispatcher Dispatcher { get; set; }

	public void Init()
	{
	}

	public void Execute(IEvent evt)
	{
		Debug.Log("Starting game...");
		GameController.Instance.MainFsm.StateChange(GameController.Instance.gameObject.AddComponent<GameScene>());
	}
}