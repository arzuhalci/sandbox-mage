using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        button = gameObject.transform.Find("Play").gameObject.GetComponent<Button>();

        button.onClick.AddListener(butonStart);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void butonStart()
    {
        SceneManager.LoadScene(1);
    }
}
