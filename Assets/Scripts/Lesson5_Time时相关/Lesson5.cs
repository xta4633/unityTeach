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


        #region ֪ʶ��һ ʱ�����ű���

        //ʱ��ֹͣ
        Time.timeScale = 0;
        //������
        Time.timeScale = 2;
        //�ָ�����
        Time.timeScale = 1;

        #endregion

        #region ֪ʶ��� ֡���ʱ��
        //֡���ʱ�� ��Ҫ����λ��
        //·�� = �ٶ� * ʱ��

        //��������ѡ��������ļ��ʱ��
        //�����Ҫ ��Ϸ��ͣʱ�Ͳ����� ���� deltaTime
        //���ϣ�� ������ͣӰ�� unscaledDeltaTime

        //��ScaleӰ��
        //print("��Ӱ��" + Time.deltaTime);

        //����ScaleӰ��
        //print("����Ӱ��" + Time.unscaledDeltaTime);
        #endregion


        #region ֪ʶ���� ��Ϸ��ʼ�����Ƶ�ʱ��
        //��Ҫ������ʱ ������Ϸ��
        //��scaleӰ��
        //print("��Ϸ��ʼ�����ڵ�ʱ�䣺" + Time.time);
        //����scaleӰ��
        //print("����Ӱ��scale��Ϸ��ʼ�����ڵ�ʱ�䣺" + Time.unscaledTime);

        #endregion

        #region ֪ʶ���� ֡��
        //�ӿ�ʼ��������Ϸ���˶���֡
        print(Time.frameCount);
        #endregion

    }

    private void FixedUpdate()
    {
        #region ֪ʶ���� ��Ϸ��ʼ�����Ƶ�ʱ��
        //��scaleӰ��
        //print(Time.fixedDeltaTime);
        //����scaleӰ��
        //print(Time.fixedUnscaledDeltaTime);

        #endregion 
    }

    

}
