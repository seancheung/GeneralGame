using UnityEngine;

public class EnemyNormalState : MonoBehaviour, IGameState
{
	private float _speed;

	public void OnEnter()
	{
		_speed = gameObject.GetComponent<Enemy>().speed;
		iTween.RotateBy(gameObject, iTween.Hash("speed", _speed, "x", 10, "y", 6, "z", 3, "looptype", iTween.LoopType.loop));
	}

	public void OnExit()
	{
		Destroy(this);
	}
}