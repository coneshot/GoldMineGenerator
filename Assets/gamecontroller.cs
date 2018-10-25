using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamecontroller : MonoBehaviour {

    // Use this for initialization
    public GameObject goldPrefab;

	void Start () 
    {
        Q3();
    }

    // Update is called once per frame
    void Update () {
		
	}





    public void Q1()
    {

        for (int i = 0; i < 7; i++)
        {
            float x1;
            float x2;
            float y;
            x1 = -(10.5f) + i * 3.5f;
            x2 = 10.5f - i * 3.5f;
            y = 10.5f - i * 3.5f;
            Instantiate(goldPrefab, new Vector3(x1, y, -3), Quaternion.identity);
            if (x1 != x2)
            {
                Instantiate(goldPrefab, new Vector3(x2, y, -3), Quaternion.identity);
            }

        }

    }




    public void Q2()
    {
        float x=-14;
        float y=7;
        for (int i = 0; i < 9; i++)
        {
            x += 7;
            if (i % 3 == 0 && i / 3 >= 1)
            {
                x = -7;
                y = y - 7;
            }
            Vector3 position = new Vector3(x, y, -3);
            Instantiate(goldPrefab, position, Quaternion.identity);
           
        }
    }





    public void Q3()
    {
        int x = -7;
        int y = 7;
        int num = 0;
        while (num<9)
        {
            Vector3 position = new Vector3(x, y, -3);
            Instantiate(goldPrefab, position, Quaternion.identity);
            num++;
            x = x + 7;
            if (x == 14)
            {
                x = -7;
                y = y - 7;
            }

        }

    }

}
