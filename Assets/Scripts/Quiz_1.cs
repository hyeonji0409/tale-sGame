using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Quiz_1 : MonoBehaviour
{

    public Text ResultText;

    // Start is called before the first frame update
    void Start()
    {
        ResultText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickButton1()
    {
        ResultText.text = "TRY AGAIN";
    }

    public void ClickButton2()
    {
        SceneManager.LoadScene("realcloudhouse");
    }

    public void ClickButton3()
    {
        ResultText.text = "TRY AGAIN";
    }

    public void ClickButton4()
    {
        ResultText.text = "TRY AGAIN";
    }

}
