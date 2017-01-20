using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ShootManager : MonoBehaviour
{
    List<GameObject> children = new List<GameObject>();
    int timer = 2;
    float counter = 0;

    void Awake()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            children.Add(transform.GetChild(i).gameObject);
        }

        ShuffleChildren();
    }

    void Update()
    {
        counter += Time.deltaTime;

        if (counter > timer)
        {
            var nextLoop = true;

            for (int i = 0; i < children.Count; i++)
            {
                if (children[i].GetComponent<Enemy>().hasFired == false)
                {
                    children[i].GetComponent<Enemy>().Shoot();
                    counter = 0;
                    nextLoop = false;
                    return;
                }

                else
                {
                    nextLoop = true;
                }
            }

            if (nextLoop)
            {
                foreach (var child in children)
                {
                    child.GetComponent<Enemy>().hasFired = false;
                }

                ShuffleChildren();
            }
        }
    }

    void ShuffleChildren()
    {
        for (int i = 0; i < children.Count; i++)
        {
            GameObject temp = children[i];
            int random = Random.Range(i, children.Count);
            children[i] = children[random];
            children[random] = temp;
        }
    }
}
