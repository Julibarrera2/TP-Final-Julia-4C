using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasarObjects : MonoBehaviour
{
    public GameObject[] alimentos;
    public int currentsIndex = 10;
    void Start()
    {
        DeactivateAll();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ActivatePrevious();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            ActivateNext();
        }

    }

    public void ActivateNext()
    {
        currentsIndex++;
        if (currentsIndex >= alimentos.Length)
        {
            currentsIndex = 0;
        }
       
        DeactivateAll();
        alimentos[currentsIndex].SetActive(true);
    }

    public void ActivatePrevious()
    {
        currentsIndex--;
        if (currentsIndex < 0)
        {
            currentsIndex = alimentos.Length - 1;
        }
        DeactivateAll();
        alimentos[currentsIndex].SetActive(true);
    }


    void DeactivateAll()
    {
        for (int i = 0; i < alimentos.Length; i++)
        {
            alimentos[i].SetActive(false);
        }
    }
}
