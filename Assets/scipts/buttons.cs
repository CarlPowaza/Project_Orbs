using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class buttons : MonoBehaviour
{
     public Button StartButton;
    // Start is called before the first frame update
    void Start()
    {
        StartButton.onClick.AddListener(TaskOnClick);
        GameObject.Find("Start").GetComponentInChildren<Text>().text = "Start game";
    }
  void TaskOnClick()
    {
         Application.LoadLevel("SampleScene");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
