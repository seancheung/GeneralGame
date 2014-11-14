public interface IEvent
{
	string Name { get; set; }
	IData Data { get; set; }
}

public class EventDispatcher
{
	public event TriggerEvent OnTriggerEvent;

	public void TriggerEvent(IEvent evt)
	{
		if (OnTriggerEvent != null)
		{
			OnTriggerEvent(evt);
		}
	}
}

public delegate void TriggerEvent(IEvent evt);