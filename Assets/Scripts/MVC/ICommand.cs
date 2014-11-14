public interface ICommand
{
	IData Data { get; set; }
	EventDispatcher Dispatcher { get; set; }
	void Init();
	void Execute(IEvent evt);
}