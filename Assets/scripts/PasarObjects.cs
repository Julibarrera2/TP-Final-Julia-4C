using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasarObjects : MonoBehaviour
{
    public GameObject[] alimentos;
    public int currentIndex = -1;

    void Start()
    {
        DeactivateAll();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {

            currentIndex++;
            if (currentIndex < alimentos.Length)
            {
                ActivateByIndex(currentIndex);
            }
            if (currentIndex > alimentos.Length - 1)
            {
                currentIndex = -1;
                DeactivateAll();
            }
        }
    }
    void DeactivateAll()
    {
        for (int i = 0; i < alimentos.Length; i++)
        {
            alimentos[i].SetActive(false);
        }
    }

    void ActivateByIndex(int index)
    {
        alimentos[index].SetActive(true);
    }

}
