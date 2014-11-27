using UnityEngine;

public class PlayerNormalState : MonoBehaviour, IGameState
{
	public void OnEnter()
	{
		iTween.RotateBy(gameObject, iTween.Hash("speed", 10, "x", 10, "looptype", iTween.LoopType.loop));
	}

	public void OnExit()
	{
		iTween.Stop(gameObject);
		Destroy(this);
	}
}