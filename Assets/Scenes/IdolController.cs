﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdolController : MonoBehaviour
{
    public float speed = 8f;
	public float moveableRange = 5.5f;
	public float power = 1000f;
	public GameObject heart;
	public Transform spawnPoint;

	// Update is called once per frame
	void Update () {
		Debug.Log("経過時間(秒)" + Time.time);
		transform.Translate(0, Input.GetAxisRaw("Vertical") * speed * Time.deltaTime, 0);
		transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, -moveableRange, moveableRange));
		if (Input.GetKeyDown(KeyCode.Space)){
			Shoot();
		}
	}
	void Shoot(){
		GameObject newBullet = Instantiate(heart, spawnPoint.position, Quaternion.identity) as GameObject;
		newBullet.GetComponent<Rigidbody2D> ().AddForce(Vector3.left * power);
	}

}
