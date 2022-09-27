using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartExit : MonoBehaviour
{

    private Transform scene1;
    private Transform scene2;
    // Start is called before the first frame update
    void Start()
    {
        scene1 = GameObject.Find("Canvas").transform.GetChild(0);
        scene2 = GameObject.Find("Canvas").transform.GetChild(1);
    }

    public void openScene1()
    {
        scene1.gameObject.SetActive(true);
        scene2.gameObject.SetActive(false);
    }
    public void openScene2()
    {
        scene2.gameObject.SetActive(true);
        scene1.gameObject.SetActive(false);
    }
}
