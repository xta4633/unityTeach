using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson4_A : MonoBehaviour
{
    //������ ͨ��������Ա����ֱ�ӹ���
    //��Ȼ�� ����һЩ�ƻ��������˼��ṹ
    //�൱��A����һ��������B
    public Lesson4_B b;
    // Start is called before the first frame update
    void Start()
    {

        //����һ
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
