using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TryAgain : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        button = gameObject.transform.Find("Try Again").gameObject.GetComponent<Button>();

        button.onClick.AddListener(tryAgain);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void tryAgain()
    {
        SceneManager.LoadScene(1);
    }
}
