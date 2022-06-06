using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heartCollision : MonoBehaviour
{
		// Start is called before the first frame update
    void Start()
    {
    	//Debug.Log(targetCollision.hp);  
			
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision){
		
		Debug.Log("当たった!");

		if(collision.gameObject.tag == "anti"){
			Destroy(collision.gameObject);
			Destroy(this.gameObject);
			Debug.Log(targetCollision.hp);
		}
		if(collision.gameObject.tag == "fan"){
			Destroy(collision.gameObject);
			Destroy(this.gameObject);	
			targetCollision.hp += 1;
			Debug.Log(targetCollision.hp);
		}
	}
}
