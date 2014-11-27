using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
	private float _tick;
	public List<GameObject> enemyList;
	public GameObject enemyPrefab;
	public float interval = 5; //every 5 secs
	public Transform[] spawnPoints;

	private void Start()
	{
		enemyList = new List<GameObject>();
		enemyPrefab = Resources.Load<GameObject>("EnemyPrefab");
		spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint").Select(g => g.transform).ToArray();
	}

	private void Update()
	{
		if ((_tick += Time.deltaTime) > interval)
		{
			Spawn();
			_tick = 0;
		}
	}

	private void Spawn()
	{
		enemyPrefab.name = "Enemy" + enemyList.Count;
		int i = Random.Range(0, spawnPoints.Length - 1);
		var go = Instantiate(enemyPrefab, spawnPoints[i].position, spawnPoints[i].rotation) as GameObject;
		int j = Random.Range(0, MatManager.Instance.materials.Length - 1);
		go.GetComponent<MeshRenderer>().material = MatManager.Instance.materials[j];
		enemyList.Add(go);
	}
}