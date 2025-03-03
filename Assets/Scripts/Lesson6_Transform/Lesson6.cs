using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        #region 知识点一 Vector3
        Vector3 v = new Vector3();
        v.x = 10;
        v.y = 10;
        v.z = 10;

        //只传x和y,z默认是0
        Vector3 v2 = new Vector3(10, 10);
        //一步到位
        Vector3 v3 = new Vector3(10, 10, 10);

        Vector3 v4;
        v4.x = 10;
        v4.y = 10;
        v4.z = 10;


        //Vector的基本运算
        Vector3 v1 = new Vector3(1,1,1);
        Vector3 v12 = new Vector3(2,2,2);
        print(v1 + v12);
        print(v1 - v12);


        //常用
        print(Vector3.zero);//000
        print(Vector3.right);//100
        print(Vector3.left);//-100
        print(Vector3.forward);//001
        print(Vector3.back);//00-1
        print(Vector3.up);//010
        print(Vector3.down);//0-10

        //常用的一个方法
        //计算两个点直接距离的方法
        print(Vector3.Distance(v1, v12));

        #endregion


        #region 知识点二 位置
        //相对世界坐标系位置
        print(this.transform.position);

        //面板上显示的位置是相对与父对象的位置
        //相对父对象的位置
        print(this.transform.localPosition);

        //他们两个可能出现是一样的情况
        //1、父对象的坐标就是0.0.0
        //2、对象没有父对象


        //位置的改变不能直接改变x、y、z，只能一起改变
        this.transform.position = new Vector3(0, 10, 0);
        this.transform.localPosition = Vector3.up * 10;


        //对象当前的各朝向
        //对象当前的面朝向
        print(this.transform.forward);
        //上朝向
        print(this.transform.up);
        //右朝向
        print(this.transform.right);

        #endregion

        #region 知识点三 位移
        #endregion
    }

    // Update is called once per frame
    void Update()
    {


    }
}
