using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IView, IStateController
{
	public GameFSM MainFsm { get; private set; }
	public float speed;

	public string Name
	{
		get { return name; }
		set { name = value; }
	}

	public EventDispatcher Dispatcher { get; set; }
	public List<string> EventList { get; private set; }

	public void Init()
	{
		MainFsm.StateChange(gameObject.AddComponent<EnemyNormalState>());
	}

	public void Dispose()
	{
		Destroy(gameObject);
	}

	public void Notify(IEvent evt)
	{
	}

	private void Start()
	{
		MainFsm = new GameFSM();
		GameController.Instance.AddView(this);
	}
}