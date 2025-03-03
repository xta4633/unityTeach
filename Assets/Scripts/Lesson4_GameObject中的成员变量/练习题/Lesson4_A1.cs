using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum E_Do_Type
{ 
    //改名
    ChangeName,
    //失活
    ActiveFalse,
    //延迟删除
    DelayDes,
    //删除
    Des,
}

public class Lesson4_A1 : MonoBehaviour
{

    //申明一个枚举
    public E_Do_Type type = E_Do_Type.ChangeName;

    // Start is called before the first frame update
    void Start()
    {
        GameObject B = GameObject.Find("B2");

        switch (type)
        {
            case E_Do_Type.ChangeName:
                B.name = "B改名";
                break;
            case E_Do_Type.ActiveFalse:
                B.SetActive(false);
                break;
            case E_Do_Type.DelayDes:
                Destroy(B, 5);
                break;
            case E_Do_Type.Des:
                Destroy(B);
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
