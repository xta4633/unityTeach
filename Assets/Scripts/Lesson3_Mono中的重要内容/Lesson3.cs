using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Lesson3 : MonoBehaviour
{
    public Lesson3 otherLesson3;
    void Start()
    {
        #region ֪ʶ��һ ��Ҫ��Ա
        //1.��ȡ������GameObject
        print(gameObject.name + "@@@");

        //2.��ȡ������gameObject��λ����Ϣ
        print(this.transform.position);//λ��
        print(this.transform.eulerAngles);//�Ƕ�
        print(this.transform.lossyScale);//���Ŵ�С

        //this.gameObject.tranform  ������һ��

        //3.��ȡ�ű��Ƿ񼤻�
        enabled = true;
        enabled = false;

        //��ȡ��Ľű����� ������gameObject��tranform��Ϣ
        if (otherLesson3.gameObject != null)
        {
            print(otherLesson3.gameObject.name);
            print(otherLesson3.gameObject.transform.position);
        }
        #endregion

        #region ֪ʶ��� ��Ҫ����
        //1.�õ��Լ����صĵ����ű�
        //���ݽű����ֻ�ȡ �����ȡʧ�� ����û�ж�Ӧ�Ľű� �᷵�ؿ�
        Lesson3_Test t = this.GetComponent("Lesson3_Test") as Lesson3_Test;
        print(t);

        //����Type��ȡ
        t = this.GetComponent(typeof(Lesson3_Test)) as Lesson3_Test;
        print(t);

        //���ݷ��ͻ�ȡ ����ʹ�÷��ͻ�ȡ
        t = this.GetComponent<Lesson3_Test>();

        //ֻҪ�ܹ��õ������б�Ķ�����߶���Ľű�
        //����Ϳ��Ի������������Ϣ


        //2.�õ��Լ����صĶ���ű�
        Lesson3[] array = this.GetComponents<Lesson3>();
        print(array.Length);

        List<Lesson3> list = new List<Lesson3>();
        this.GetComponents<Lesson3>(list);
        #endregion


        //3.�õ��Ӷ�����صĽű���Ĭ��Ҳ�����Լ������Ƿ���ؽű���
        //�������� Ĭ�ϲ�����false ��˼������Ӷ���ʧ�� �򲻻����Ӷ����ϵĽű�
        //�����true,���Ѱ��
        t = this.GetComponentInChildren<Lesson3_Test>();
        print(t);

        Lesson3_Test[] lts = this.GetComponentsInChildren<Lesson3_Test>(true);
        print(lts.Length);

        List<Lesson3_Test> list2 = new List<Lesson3_Test>();
        this.GetComponentsInChildren(true, list2);
        print(list2.Count);

        //4.��ȡ��������صĽű���Ĭ��Ҳ�����Լ������Ƿ���ؽű���
        t = this.GetComponentInParent<Lesson3_Test>();
        print(t);
        lts = this.GetComponentsInParent<Lesson3_Test>();
        print(lts.Length);


        //5.���Ի�ȡ�ű�
        //�ṩ��һ�����Ӱ�ȫ�Ļ�ýű��ķ���

        Lesson3_Test l3t;
        if (this.TryGetComponent<Lesson3_Test>(out l3t))
        { 
        
        }

    }

    void Update()
    { 
    
    }
}