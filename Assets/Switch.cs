using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Switch : MonoBehaviour
{
    public Image On;
    public Image off;
    public Image img;
    int index;

    // Start is called before the first frame update
    void Start()
    {        
    }

    // Update is called once per frame
    void Update()
    {
     if(index == 1)   
     {
        img.gameObject.SetActive(false);   
     }

    if(index == 0)   
     {
        img.gameObject.SetActive(true);   
     }
    }

    public void ON()
    {
        index = 1;
        off.gameObject.SetActive(true);
        On.gameObject.SetActive(false);
    }

    public void OFF()
    {
        index = 0;
        off.gameObject.SetActive(false);
        On.gameObject.SetActive(true);
    }
}
