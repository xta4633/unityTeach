using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson4 : MonoBehaviour
{
    //可以是一个场景中的对象
    //可以是一个预设体对象
    public GameObject myObj;
    public GameObject myObj2;

    public void TestFun()
    {
        print("Lesson4的TestFun");
    }

    // Start is called before the first frame update
    void Start()
    {
        print(this.gameObject.name);
        gameObject.name = "Lesson4改名";
        print(gameObject.name);

        //是否激活
        print(gameObject.activeSelf);
        //是否静态
        print(gameObject.isStatic);
        //层级
        print(gameObject.layer);
        //标签
        print(gameObject.tag);

        //transform
        print(transform.position);


        #region 知识点二 GameObject中的静态方法
        //创建自带几何体
        //只要得到一个GameObject对象，就能得到上面挂载的任何脚本信息
        GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        obj.name = "创建的几何体";
        

        //查找对象相关的知识
        //1.查找单个对象
        //这个查找效率比较低，会变量场景上所有对象
        //无法找到失活的对象

        GameObject obj2 = GameObject.Find("唐老师");
        if (obj2 != null)
        {
            print(obj2.name);
        }
        else
        {
            print("没有找到对象");
        }

        //无法找到失活的对象
        //通过标签
        //如果存在多个满足条件的对象 无法确定找到的是哪个
        GameObject obj3 = GameObject.FindWithTag("Player");
        if (obj3 != null)
        {
            print(obj3.name);
        }
        else
        {
            print("没有根据Tag找到对象");
        }

        //得到某一个单个对象 目前有两个方法
        //1.直接拖入
        //2，通过API

        //2.查找多个对象
        //只能找到激活对象
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Player");
        print("找到的个数为" + objs.Length);

        //用的比较少的方法 有GameObject父类Object提供
        //这个Object不是万物之父
        //可以找到场景中挂载的某个脚本对象
        //效率更低 不仅遍历对象还有遍历挂载脚本
        Lesson4 o = GameObject.FindObjectOfType<Lesson4>();
        print(o.gameObject.name);



        //实例化（克隆对象）对象方法
        //它的作用 是根据一个GameObjectd对象 创建出一个和它一模一样的对象
        GameObject obj5 = GameObject.Instantiate(myObj);



        //删除对象的方法
        //注意：不会马上移除 一般情况下会在下一帧把这个对象移除 并从内存中移除
        GameObject.Destroy(myObj2);
        //第二个参数，延迟几秒钟删除
        GameObject.Destroy(obj5, 5);
        //不仅可以删除对象 还可以删除脚本
        //GameObject.Destroy(this);

        //立刻删除
        //GameObject.DestroyImmediate()



        //过场景不移除
        //默认情况在切换场景时 场景中对象都会被自动移除
        //如果你希望某个对象 过场景不被移除 就传谁
        //一般都是传依附的GameObject对象
        GameObject.DontDestroyOnLoad(this.gameObject);

        #endregion


        #region 知识点点三 成员函数

        //创建一个空物体
        GameObject obj6 = new GameObject();
        GameObject obj7 = new GameObject("new的新物体");
        GameObject obj8 = new GameObject("顺便加脚本的空物体", typeof(Lesson1), typeof(Lesson3));

        //为对象添加脚本
        //继承MonoBehavior的脚本 不能new
        //如果想动态的添加继承了MonoBehavior的脚本
        obj6.AddComponent(typeof(Lesson1));
        Lesson3 les2 = obj6.AddComponent<Lesson3>();


        //得到脚本
        //和MonoBehavior一样
        Lesson1 les1 = obj.GetComponent<Lesson1>();

        //标签比较
        if (this.gameObject.CompareTag("Player"))
        {
            print("标签是Player");
        }

        if (this.gameObject.tag == "Player") 
        {
            print("标签是Player");
        }

        //设置激活失活
        obj6.SetActive(false);
        obj7.SetActive(false);


        //次要的成员方法 了解即可 不建议使用
        //强调
        //下面讲的方法都不建议使用

        //通过广播或发送消息的形式 让自己或别人 执行某些行为方法

        //通知自己 执行什么行为
        this.gameObject.SendMessage("TestFun");

        //广播行为 让自己和自己的子对象执行
        //this.gameObject.BroadcastMessage("函数名");
        //向父对象和自己发送消息 并执行
        //this.gameObject.SendMessageUpwards("函数名");


        #endregion


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
