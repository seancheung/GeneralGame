using UnityEngine;

public class PlayerController : MonoBehaviour
{
	private float speed = 4f;

	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			var target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			target.z = 0;
			iTween.MoveTo(gameObject,
				iTween.Hash("position", target,
					"speed",
					speed));
		}
	}
}