using System.Collections.Generic;
using UnityEngine;

public class LaunchScene : MonoBehaviour, IView, IGameState
{
	public UIButton btnQuit;
	public UIButton btnStart;

	public void OnEnter()
	{
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
		btnStart = GameObject.Find("btnStart").GetComponent<UIButton>();
		btnQuit = GameObject.Find("btnQuit").GetComponent<UIButton>();

		EventDelegate.Add(btnStart.onClick, () => Dispatcher.TriggerEvent(new BasicEvent(EventCenter.StartGame)));
		EventDelegate.Add(btnQuit.onClick, () => Dispatcher.TriggerEvent(new BasicEvent(EventCenter.QuitGame)));
	}

	public void Dispose()
	{
		Destroy(this);
	}

	public void Notify(IEvent evt)
	{
	}
}