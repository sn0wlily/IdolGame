using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class targetCollision : MonoBehaviour
{
    public static int gtime = 0;
    public static int hp = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision){
		
		Debug.Log("当たった!");
    if(hp==0){
            //hp = 10;
            gtime = (int)Time.time;
            Debug.Log("プレイ時間(秒)" + gtime);
       SceneManager.LoadScene("GameOver");
        }
    else{
      if(collision.gameObject.tag == "anti"){
        Destroy(collision.gameObject);
        hp -= 1;
        Debug.Log(hp);
      }
      if(collision.gameObject.tag == "fan"){
        Destroy(collision.gameObject);
        hp -= 1;
        Debug.Log(hp);
      }
    }
	}
}
