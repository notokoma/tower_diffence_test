using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTitleNext : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void OnClick()
    {
        TitleNextSound.SoundFlag1 = true;
        //切り替える
        SceneManager.LoadScene("SceneGame");
    }
}