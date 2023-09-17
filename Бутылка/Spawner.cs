using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float time = 1; //��� ����� ��������, 1 ��� � ������� �� ���������, ���� �������� � ����������
    public GameObject obj; //����� ������ ��������, ����� ����� ���������� ������ ��� ������.
    
    void Start()  //�������� ��� ������ ����
    {
        InvokeRepeating("Spawn", //����� ������ �������� Spawn
            0,                  //����� 0 ������ ����� ������
            time                //� �������������� �������� � time
            );
    }

    
    void Spawn()            //���� �������� Spawn
    {
        GameObject newObj = Instantiate( //������� ������
            obj,                //����� ������ �� ���� obj
            transform.position,    //������� ������ � ��������� �������, � ������� ����� ������ ������
            transform.rotation      //������� ������ � ����� �� ���������
            );
        newObj.SetActive(true);     //������ ��������� ������ �������
    }
}
