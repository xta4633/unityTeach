using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        #region ֪ʶ��һ Vector3
        Vector3 v = new Vector3();
        v.x = 10;
        v.y = 10;
        v.z = 10;

        //ֻ��x��y,zĬ����0
        Vector3 v2 = new Vector3(10, 10);
        //һ����λ
        Vector3 v3 = new Vector3(10, 10, 10);

        Vector3 v4;
        v4.x = 10;
        v4.y = 10;
        v4.z = 10;


        //Vector�Ļ�������
        Vector3 v1 = new Vector3(1,1,1);
        Vector3 v12 = new Vector3(2,2,2);
        print(v1 + v12);
        print(v1 - v12);


        //����
        print(Vector3.zero);//000
        print(Vector3.right);//100
        print(Vector3.left);//-100
        print(Vector3.forward);//001
        print(Vector3.back);//00-1
        print(Vector3.up);//010
        print(Vector3.down);//0-10

        //���õ�һ������
        //����������ֱ�Ӿ���ķ���
        print(Vector3.Distance(v1, v12));

        #endregion


        #region ֪ʶ��� λ��
        //�����������ϵλ��
        print(this.transform.position);

        //�������ʾ��λ��������븸�����λ��
        //��Ը������λ��
        print(this.transform.localPosition);

        //�����������ܳ�����һ�������
        //1����������������0.0.0
        //2������û�и�����


        //λ�õĸı䲻��ֱ�Ӹı�x��y��z��ֻ��һ��ı�
        this.transform.position = new Vector3(0, 10, 0);
        this.transform.localPosition = Vector3.up * 10;


        //����ǰ�ĸ�����
        //����ǰ���泯��
        print(this.transform.forward);
        //�ϳ���
        print(this.transform.up);
        //�ҳ���
        print(this.transform.right);

        #endregion

        #region ֪ʶ���� λ��
        #endregion
    }

    // Update is called once per frame
    void Update()
    {


    }
}
