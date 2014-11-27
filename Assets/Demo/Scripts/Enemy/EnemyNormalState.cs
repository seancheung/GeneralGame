using UnityEngine;

public class EnemyNormalState : MonoBehaviour, IGameState
{
	private float _speed;

	public void OnEnter()
	{
		_speed = gameObject.GetComponent<Enemy>().speed;

		iTween.RotateBy(gameObject,
			iTween.Hash("speed", _speed, "x", Random.Range(-10, 10), "y", Random.Range(-10, 10), "z", Random.Range(-10, 10),
				"looptype", iTween.LoopType.loop));

		iTween.MoveTo(gameObject,
			iTween.Hash("position", new Vector3(-transform.position.x, -transform.position.y, transform.position.z),
				"speed",
				_speed/Random.Range(1f, _speed), "oncomplete", "OnComplete"))
			;
	}

	private void OnComplete()
	{
		GameController.Instance.RemoveView(name);
	}

	public void OnExit()
	{
		Destroy(this);
	}
}