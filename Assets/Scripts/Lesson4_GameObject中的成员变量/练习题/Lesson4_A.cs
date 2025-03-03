using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson4_A : MonoBehaviour
{
    //方法二 通过公共成员变量直接关联
    //虽然简单 但有一些破坏面向对象思想结构
    //相当于A有了一个特征是B
    public Lesson4_B b;
    // Start is called before the first frame update
    void Start()
    {

        //方法一
        GameObject B = GameObject.Find("Obj_B");
        Lesson4_B lb = B.GetComponent<Lesson4_B>();

        if (lb != null)
        {
            lb.enabled = false;
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
