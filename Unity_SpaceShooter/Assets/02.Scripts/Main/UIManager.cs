using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    //// Start is called before the first frame update
    //void Start()
    //{
    //    
    //}
    //
    //// Update is called once per frame
    //void Update()
    //{
    //    
    //}

    public void OnClickStartBtn()
    {

        SceneManager.LoadScene("Level1");
        SceneManager.LoadScene("Play", LoadSceneMode.Additive);
        //Debug.Log("Click Button");
    }
}
