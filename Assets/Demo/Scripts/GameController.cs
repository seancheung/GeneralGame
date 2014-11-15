public class GameController : MVCController, IStateController
{
	public static GameController Instance { get; private set; }
	public GameFSM MainFsm { get; private set; }

	private void Awake()
	{
		MainFsm = new GameFSM();
		Instance = this;
		DontDestroyOnLoad(this);
		Init();
	}

	private void Start()
	{
		MainFsm.StateChange(gameObject.AddComponent<LaunchScene>());
	}

	protected override void RegisterWires()
	{
	}

	protected override void RegisterViews()
	{
	}

	protected override void RegisterModels()
	{
	}

	protected override void RegisterCommands()
	{
		AddCommand<StartCommand>(EventCenter.StartGame);
		AddCommand<QuitCommand>(EventCenter.QuitGame);
	}
}