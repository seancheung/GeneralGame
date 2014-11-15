using System.Collections.Generic;
using UnityEngine;

public class GameScene : MonoBehaviour, IView, IGameState
{
	public void OnEnter()
	{
		Application.LoadLevel(1);
		GameController.Instance.AddView(this);
	}

	public void OnExit()
	{
		GameController.Instance.RemoveView(Name);
	}

	public string Name
	{
		get { return name; }
		set { name = value; }
	}

	public EventDispatcher Dispatcher { get; set; }
	public List<string> EventList { get; private set; }

	public void Init()
	{
	}

	public void Dispose()
	{
		Destroy(this);
	}

	public void Notify(IEvent evt)
	{
	}
}