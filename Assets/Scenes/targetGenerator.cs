using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetGenerator : MonoBehaviour
{
    public GameObject AntiPrefab;
	public GameObject FanPrefab;
	//public Transform spawnPoint1;
	//public Transform spawnPoint2;
	//public Transform spawnPoint3;
	public float interval = 5.0f;
	public float first = 0.1f;
	
	
	// Use this for initialization
	void Start () {
		InvokeRepeating("SpawnObj", first, interval);
	}
	
	// Update is called once per frsame
	void  SpawnObj() {
		//ランダムでアンチかファンか
		int value = Random.Range(0,5);
		//print(value);
		if(value == 0){
			GameObject cloneFan = Instantiate(FanPrefab, transform.position, transform.rotation) as GameObject;
			cloneFan.GetComponent<Rigidbody2D>().AddForce(Vector3.right * 500f);
		}
		else{
			GameObject cloneAnti = Instantiate(AntiPrefab, transform.position, transform.rotation) as GameObject;
			cloneAnti.GetComponent<Rigidbody2D>().AddForce(Vector3.right * 500f);
		}
	}
	
}
