using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson4_lianxi1 : MonoBehaviour
{

    public GameObject tank;
    // Start is called before the first frame update
    void Start()
    {
        GameObject tankObj = GameObject.Instantiate(tank);
        tankObj.name = "Ì¹¿Ë";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
