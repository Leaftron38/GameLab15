using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerControl : MonoBehaviour
{
    public string ScenetoLoad;
    public Button button;
    
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(ChangeScene);
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Input.GetButtonDown("Fire1") == true)
        {
            SceneManager.LoadScene(ScenetoLoad);
        }*/
    }
    void ChangeScene()
    {
        SceneManager.LoadScene(ScenetoLoad);
    }
}
