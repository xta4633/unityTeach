using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        #region 知识点一 时间缩放比例

        //时间停止
        Time.timeScale = 0;
        //二倍速
        Time.timeScale = 2;
        //恢复正常
        Time.timeScale = 1;

        #endregion

        #region 知识点二 帧间隔时间
        //帧间隔时间 主要计算位移
        //路程 = 速度 * 时间

        //根据需求选择参与计算的间隔时间
        //如果需要 游戏暂停时就不动的 就用 deltaTime
        //如果希望 不受暂停影响 unscaledDeltaTime

        //受Scale影响
        //print("受影响" + Time.deltaTime);

        //不受Scale影响
        //print("不受影响" + Time.unscaledDeltaTime);
        #endregion


        #region 知识点三 游戏开始到限制的时间
        //主要用来记时 单机游戏中
        //受scale影响
        //print("游戏开始到现在的时间：" + Time.time);
        //不受scale影响
        //print("不受影响scale游戏开始到现在的时间：" + Time.unscaledTime);

        #endregion

        #region 知识点五 帧数
        //从开始到现在游戏跑了多少帧
        print(Time.frameCount);
        #endregion

    }

    private void FixedUpdate()
    {
        #region 知识点四 游戏开始到限制的时间
        //受scale影响
        //print(Time.fixedDeltaTime);
        //不受scale影响
        //print(Time.fixedUnscaledDeltaTime);

        #endregion 
    }

    

}
