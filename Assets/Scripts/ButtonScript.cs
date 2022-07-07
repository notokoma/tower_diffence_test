using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class ButtonScript : MonoBehaviour {
 
    // ボタンが押された場合、今回呼び出される関数
    public void OnClick()
    {
        // CubeプレハブをGameObject型で取得
        GameObject obj = (GameObject)Resources.Load ("Enemy");
        // Cubeプレハブを元に、インスタンスを生成、
        Instantiate (obj, new Vector3(0.0f,0.0f,0.0f), Quaternion.identity);
    }
}