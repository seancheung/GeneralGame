using System.Collections.Generic;
using UnityEngine;

public class EnemyView : MonoBehaviour, IView, IStateController
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
	}

	public void Dispose()
	{
	}

	public void Notify(IEvent evt)
	{
	}

	private void Start()
	{
		MainFsm = new GameFSM();
		GameController.Instance.AddView(this);
	}

	private void Update()
	{
	}
}