public interface IModel
{
	string Name { get; set; }
	IData Data { get; set; }
	EventDispatcher Dispatcher { get; set; }
	void Init();
	void Dispose();
}