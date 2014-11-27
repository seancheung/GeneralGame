using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IView, IStateController
{
	public GameFSM MainFsm { get; private set; }

	public string Name
	{
		get { return name; }
		set { name = value; }
	}

	public EventDispatcher Dispatcher { get; set; }

	public List<string> EventList { get; private set; }

	public void Init()
	{
		EventList = new List<string> {EventCenter.PlayerGetHit};
		MainFsm.StateChange(gameObject.AddComponent<PlayerNormalState>());
	}


	public void Dispose()
	{
		Destroy(gameObject);
	}

	public void Notify(IEvent evt)
	{
		switch (evt.Name)
		{
			case EventCenter.PlayerGetHit:
				break;
		}
	}

	private void Start()
	{
		MainFsm = new GameFSM();
		GameController.Instance.AddView(this);
	}
}