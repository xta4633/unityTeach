using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson9 : MonoBehaviour
{
    public Transform son;

    // Start is called before the first frame update
    void Start()
    {
        #region ֪ʶ��һ ��ȡ�����ø�����
        //��ȡ������
        //print(this.transform.parent.name);

        //���ø�����
        this.transform.parent = null;

        //���ø�����
        //this.transform.parent = GameObject.Find("Father2").transform;

        //ͨ��API
        //this.transform.SetParent(null);
        //this.transform.SetParent(GameObject.Find("Father2").transform);

        //����һ �ҵĸ��� 
        //������ �Ƿ������������ λ�� �Ƕ� ���� ����Ĭ����true

        //this.transform.SetParent(GameObject.Find("Father3").transform, false);
        #endregion

        #region ֪ʶ��� ��������
        //this.transform.DetachChildren();

        #endregion

        #region ֪ʶ���� ����Ӷ���

        //�����ֲ��Ҷ��ӵ�transform��Ϣ
        //���ҵ�ʧ���
        //�Ҳ����Լ�������
        print(this.transform.Find("Cube (1)").name);


        //��������
        //��εõ��ж��ٶ���
        //ʧ��Ķ���Ҳ������
        //���Ӳ���������
        print(this.transform.childCount);

        //ͨ�������ŵõ���Ӧ�Ķ���
        //����������Χ�ᱨ��
        //����ֵ��transform
        this.transform.GetChild(0);

        for (int i = 0; i < this.transform.childCount; i++)
        {
            print("���ӵ�����" + this.transform.GetChild(i).name);
        }

        #endregion


        #region ֪ʶ���� ���ӵĲ���
        if (son.IsChildOf(this.transform))
        {
            print("���ҵĶ���");
        }

        //�õ��Լ���Ϊ���ӵı仯
        print(son.GetSiblingIndex());

        //���Լ�����Ϊ��һ������
        son.SetAsFirstSibling();
        
        //���һ��
        son.SetAsLastSibling();

        //���Լ�����ָ�������� //����˲��ᱨ�������Ϊ���һ��
        son.SetSiblingIndex(3);
        #endregion

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
