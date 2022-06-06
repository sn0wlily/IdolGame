using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObj : MonoBehaviour
{
    public float deletetime = 2.0f;
	// Use this for initialization
	void Start () {
		Destroy(gameObject, deletetime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
