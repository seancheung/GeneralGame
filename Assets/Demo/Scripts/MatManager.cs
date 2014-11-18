using UnityEngine;

public class MatManager : MonoBehaviour
{
	public static MatManager Instance;

	public Material[] materials;

	private void Awake()
	{
		Instance = this;
	}

	void Start()
	{
		materials = Resources.LoadAll<Material>("Materials");
	}
}