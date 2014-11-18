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
		gameObject.AddComponent<MatManager>();
	}

	public void Dispose()
	{
		Destroy(this);
		Destroy(gameObject.GetComponent<EnemySpawner>());
	}

	public void Notify(IEvent evt)
	{
	}

	private void OnLevelWasLoaded(int level)
	{
		if (level == 1)
			gameObject.AddComponent<EnemySpawner>();
	}
}