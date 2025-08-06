using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayTest : MonoBehaviour
{
    public Transform Player;
    // Start is called before the first frame update
    void Start()
    {

        //射线检测创建有两种方式
        //第一种:创建一个射线,这个射线是从0,0,0点触发,向上打出去
        //Ray ray = new Ray(Vector3.zero,Vector3 .up);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //第二种:从屏幕上打出一个点,这个点是通过相机窗口 鼠标点击打出的
        //Ray  ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Input.GetMouseButtonDown(0))
        {
            //按下鼠标左键,发射射线
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //声明一个碰撞信息类
            RaycastHit hit;
            bool res = Physics.Raycast(ray, out hit);
            //如果碰撞到的情况下
            if(res == true)
            {

                Debug .Log (hit.point );
                //移动的位置就等于射线检测到的位置
                Player.position = hit.point;
            }

            //多检测:多检测是检测一组数组,并且需要设置范围,不然它会检测无穷远,也可以设置图层检测1<<10 就是1到10图层的意思,一般用的最多的还是正常的单射线检测
            RaycastHit[]hits= Physics.RaycastAll(ray,100,1<<10);
        }
    }
}
