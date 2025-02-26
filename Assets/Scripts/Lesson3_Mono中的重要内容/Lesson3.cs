using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Lesson3 : MonoBehaviour
{
    public Lesson3 otherLesson3;
    void Start()
    {
        #region 知识点一 重要成员
        //1.获取依附的GameObject
        print(gameObject.name + "@@@");

        //2.获取依附的gameObject的位置信息
        print(this.transform.position);//位置
        print(this.transform.eulerAngles);//角度
        print(this.transform.lossyScale);//缩放大小

        //this.gameObject.tranform  和上面一样

        //3.获取脚本是否激活
        enabled = true;
        enabled = false;

        //获取别的脚本对象 依附的gameObject和tranform信息
        if (otherLesson3.gameObject != null)
        {
            print(otherLesson3.gameObject.name);
            print(otherLesson3.gameObject.transform.position);
        }
        #endregion

        #region 知识点二 重要方法
        //1.得到自己挂载的单个脚本
        //根据脚本名字获取 如果获取失败 就是没有对应的脚本 会返回空
        Lesson3_Test t = this.GetComponent("Lesson3_Test") as Lesson3_Test;
        print(t);

        //根据Type获取
        t = this.GetComponent(typeof(Lesson3_Test)) as Lesson3_Test;
        print(t);

        //根据泛型获取 建议使用泛型获取
        t = this.GetComponent<Lesson3_Test>();

        //只要能够得到场景中别的对象或者对象的脚本
        //那你就可以获得它的所有信息


        //2.得到自己挂载的多个脚本
        Lesson3[] array = this.GetComponents<Lesson3>();
        print(array.Length);

        List<Lesson3> list = new List<Lesson3>();
        this.GetComponents<Lesson3>(list);
        #endregion


        //3.得到子对象挂载的脚本（默认也会找自己身上是否挂载脚本）
        //函数参数 默认不传是false 意思是如果子对象失活 则不会找子对象上的脚本
        //如果是true,则会寻找
        t = this.GetComponentInChildren<Lesson3_Test>();
        print(t);

        Lesson3_Test[] lts = this.GetComponentsInChildren<Lesson3_Test>(true);
        print(lts.Length);

        List<Lesson3_Test> list2 = new List<Lesson3_Test>();
        this.GetComponentsInChildren(true, list2);
        print(list2.Count);

        //4.获取父对象挂载的脚本（默认也会找自己身上是否挂载脚本）
        t = this.GetComponentInParent<Lesson3_Test>();
        print(t);
        lts = this.GetComponentsInParent<Lesson3_Test>();
        print(lts.Length);


        //5.尝试获取脚本
        //提供了一个更加安全的获得脚本的方法

        Lesson3_Test l3t;
        if (this.TryGetComponent<Lesson3_Test>(out l3t))
        { 
        
        }

    }

    void Update()
    { 
    
    }
}