using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Scoretext : MonoBehaviour
{
    // UIオブジェクト"Text Score"のTextコンポーネントを格納する変数
    public Text Score;
    
    // ゲーム実行中の繰り返し処理
    void Update()
    { 
        Score.text = "ResultScore: " + targetCollision.gtime.ToString();

    }
}
