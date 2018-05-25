using UnityEngine;
using System.Collections;

public class SpawnerPipe : MonoBehaviour {

	[SerializeField]
	private GameObject pipeHolder;

	// Use this for initialization
	void Start () {
		StartCoroutine (Spawner ());
	}
	
	IEnumerator Spawner(){
		yield return new WaitForSeconds (2);
		Vector3 temp = pipeHolder.transform.position;
		temp.y = Random.Range (-2f, 2f);
		Instantiate (pipeHolder, temp, Quaternion.identity);
		StartCoroutine (Spawner ());
	}
}
