using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayTest : MonoBehaviour
{
    public Transform Player;
    // Start is called before the first frame update
    void Start()
    {

        //���߼�ⴴ�������ַ�ʽ
        //��һ��:����һ������,��������Ǵ�0,0,0�㴥��,���ϴ��ȥ
        //Ray ray = new Ray(Vector3.zero,Vector3 .up);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //�ڶ���:����Ļ�ϴ��һ����,�������ͨ��������� ����������
        //Ray  ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Input.GetMouseButtonDown(0))
        {
            //����������,��������
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //����һ����ײ��Ϣ��
            RaycastHit hit;
            bool res = Physics.Raycast(ray, out hit);
            //�����ײ���������
            if(res == true)
            {

                Debug .Log (hit.point );
                //�ƶ���λ�þ͵������߼�⵽��λ��
                Player.position = hit.point;
            }

            //����:�����Ǽ��һ������,������Ҫ���÷�Χ,��Ȼ����������Զ,Ҳ��������ͼ����1<<10 ����1��10ͼ�����˼,һ���õ����Ļ��������ĵ����߼��
            RaycastHit[]hits= Physics.RaycastAll(ray,100,1<<10);
        }
    }
}
