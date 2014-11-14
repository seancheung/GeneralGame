public class GameController : MVCController, IStateController
{
	public static GameController Instance { get; private set; }
	public GameFSM MainFsm { get; private set; }

	private void Awake()
	{
		MainFsm = new GameFSM();
		Instance = this;
	}

	private void Start()
	{
	}

	private void Update()
	{
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
	}
}