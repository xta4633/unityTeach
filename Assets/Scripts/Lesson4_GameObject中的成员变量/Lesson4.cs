using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson4 : MonoBehaviour
{
    //������һ�������еĶ���
    //������һ��Ԥ�������
    public GameObject myObj;
    public GameObject myObj2;

    public void TestFun()
    {
        print("Lesson4��TestFun");
    }

    // Start is called before the first frame update
    void Start()
    {
        print(this.gameObject.name);
        gameObject.name = "Lesson4����";
        print(gameObject.name);

        //�Ƿ񼤻�
        print(gameObject.activeSelf);
        //�Ƿ�̬
        print(gameObject.isStatic);
        //�㼶
        print(gameObject.layer);
        //��ǩ
        print(gameObject.tag);

        //transform
        print(transform.position);


        #region ֪ʶ��� GameObject�еľ�̬����
        //�����Դ�������
        //ֻҪ�õ�һ��GameObject���󣬾��ܵõ�������ص��κνű���Ϣ
        GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        obj.name = "�����ļ�����";
        

        //���Ҷ�����ص�֪ʶ
        //1.���ҵ�������
        //�������Ч�ʱȽϵͣ���������������ж���
        //�޷��ҵ�ʧ��Ķ���

        GameObject obj2 = GameObject.Find("����ʦ");
        if (obj2 != null)
        {
            print(obj2.name);
        }
        else
        {
            print("û���ҵ�����");
        }

        //�޷��ҵ�ʧ��Ķ���
        //ͨ����ǩ
        //������ڶ�����������Ķ��� �޷�ȷ���ҵ������ĸ�
        GameObject obj3 = GameObject.FindWithTag("Player");
        if (obj3 != null)
        {
            print(obj3.name);
        }
        else
        {
            print("û�и���Tag�ҵ�����");
        }

        //�õ�ĳһ���������� Ŀǰ����������
        //1.ֱ������
        //2��ͨ��API

        //2.���Ҷ������
        //ֻ���ҵ��������
        GameObject[] objs = GameObject.FindGameObjectsWithTag("Player");
        print("�ҵ��ĸ���Ϊ" + objs.Length);

        //�õıȽ��ٵķ��� ��GameObject����Object�ṩ
        //���Object��������֮��
        //�����ҵ������й��ص�ĳ���ű�����
        //Ч�ʸ��� �������������б������ؽű�
        Lesson4 o = GameObject.FindObjectOfType<Lesson4>();
        print(o.gameObject.name);



        //ʵ��������¡���󣩶��󷽷�
        //�������� �Ǹ���һ��GameObjectd���� ������һ������һģһ���Ķ���
        GameObject obj5 = GameObject.Instantiate(myObj);



        //ɾ������ķ���
        //ע�⣺���������Ƴ� һ������»�����һ֡����������Ƴ� �����ڴ����Ƴ�
        GameObject.Destroy(myObj2);
        //�ڶ����������ӳټ�����ɾ��
        GameObject.Destroy(obj5, 5);
        //��������ɾ������ ������ɾ���ű�
        //GameObject.Destroy(this);

        //����ɾ��
        //GameObject.DestroyImmediate()



        //���������Ƴ�
        //Ĭ��������л�����ʱ �����ж��󶼻ᱻ�Զ��Ƴ�
        //�����ϣ��ĳ������ �����������Ƴ� �ʹ�˭
        //һ�㶼�Ǵ�������GameObject����
        GameObject.DontDestroyOnLoad(this.gameObject);

        #endregion


        #region ֪ʶ����� ��Ա����

        //����һ��������
        GameObject obj6 = new GameObject();
        GameObject obj7 = new GameObject("new��������");
        GameObject obj8 = new GameObject("˳��ӽű��Ŀ�����", typeof(Lesson1), typeof(Lesson3));

        //Ϊ������ӽű�
        //�̳�MonoBehavior�Ľű� ����new
        //����붯̬����Ӽ̳���MonoBehavior�Ľű�
        obj6.AddComponent(typeof(Lesson1));
        Lesson3 les2 = obj6.AddComponent<Lesson3>();


        //�õ��ű�
        //��MonoBehaviorһ��
        Lesson1 les1 = obj.GetComponent<Lesson1>();

        //��ǩ�Ƚ�
        if (this.gameObject.CompareTag("Player"))
        {
            print("��ǩ��Player");
        }

        if (this.gameObject.tag == "Player") 
        {
            print("��ǩ��Player");
        }

        //���ü���ʧ��
        obj6.SetActive(false);
        obj7.SetActive(false);


        //��Ҫ�ĳ�Ա���� �˽⼴�� ������ʹ��
        //ǿ��
        //���潲�ķ�����������ʹ��

        //ͨ���㲥������Ϣ����ʽ ���Լ������ ִ��ĳЩ��Ϊ����

        //֪ͨ�Լ� ִ��ʲô��Ϊ
        this.gameObject.SendMessage("TestFun");

        //�㲥��Ϊ ���Լ����Լ����Ӷ���ִ��
        //this.gameObject.BroadcastMessage("������");
        //�򸸶�����Լ�������Ϣ ��ִ��
        //this.gameObject.SendMessageUpwards("������");


        #endregion


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
