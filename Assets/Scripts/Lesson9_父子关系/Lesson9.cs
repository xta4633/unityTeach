using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson9 : MonoBehaviour
{
    public Transform son;

    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 获取和设置父对象
        //获取父对象
        //print(this.transform.parent.name);

        //设置父对象
        this.transform.parent = null;

        //设置父对象
        //this.transform.parent = GameObject.Find("Father2").transform;

        //通过API
        //this.transform.SetParent(null);
        //this.transform.SetParent(GameObject.Find("Father2").transform);

        //参数一 我的父亲 
        //参数二 是否保留世界坐标的 位置 角度 缩放 不填默认是true

        //this.transform.SetParent(GameObject.Find("Father3").transform, false);
        #endregion

        #region 知识点二 抛妻弃子
        //this.transform.DetachChildren();

        #endregion

        #region 知识点三 获得子对象

        //按名字查找儿子的transform信息
        //能找到失活的
        //找不到自己的孙子
        print(this.transform.Find("Cube (1)").name);


        //遍历儿子
        //如何得到有多少儿子
        //失活的儿子也算数量
        //孙子不会算数量
        print(this.transform.childCount);

        //通过索引号得到对应的儿子
        //索引超出范围会报错
        //返回值的transform
        this.transform.GetChild(0);

        for (int i = 0; i < this.transform.childCount; i++)
        {
            print("儿子的名字" + this.transform.GetChild(i).name);
        }

        #endregion


        #region 知识点四 儿子的操作
        if (son.IsChildOf(this.transform))
        {
            print("是我的儿子");
        }

        //得到自己作为儿子的变化
        print(son.GetSiblingIndex());

        //把自己设置为第一个儿子
        son.SetAsFirstSibling();
        
        //最后一个
        son.SetAsLastSibling();

        //把自己设置指定个儿子 //溢出了不会报错会设置为最后一个
        son.SetSiblingIndex(3);
        #endregion

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
