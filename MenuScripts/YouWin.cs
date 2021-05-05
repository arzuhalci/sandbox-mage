using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class YouWin : MonoBehaviour
{
    public static YouWin Instance;
    public GameObject restartbutton;
    public Button restartbuttoncomponent;
    public Button[] butonlar;

    private void Start()
    {
        restartbutton = gameObject.transform.Find("Restart").gameObject;
        restartbuttoncomponent = restartbutton.GetComponent<Button>();

        restartbuttoncomponent.onClick.AddListener(Restart);

    }

    public void Awake()
    {
        Instance = this;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }

}
