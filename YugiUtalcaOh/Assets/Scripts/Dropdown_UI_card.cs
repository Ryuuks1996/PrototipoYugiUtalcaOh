using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class Dropdown_UI_card : MonoBehaviour
{
    public GameObject dropdownType;
    public GameObject tipo_normal;
    public GameObject tipo_mounstruo;
    public GameObject tipo_magico;
    public GameObject tipo_trampa;
    public int cardTypeCount = 0;

    public GameObject fuego;
    public GameObject agua;
    public GameObject divinidad;
    public GameObject luz;
    public GameObject oscuridad;
    public GameObject tierra;
    public GameObject viento;
    public int cardElementCount = 0;

    public List<GameObject> stars = new List<GameObject>();
    public int cardStarCount = 0;




    public void tipo_carta(int i)
    {
        cardTypeCount = i;
        
        if (i == 0)
        {
            tipo_mounstruo.SetActive(true);
            tipo_magico.SetActive(false);
            tipo_trampa.SetActive(false);
        }
        else if (i == 1)
        {
            tipo_magico.SetActive(true);
            tipo_trampa.SetActive(false);
            tipo_mounstruo.SetActive(false);
        }
        else if (i == 2)
        {
            tipo_trampa.SetActive(true);
            tipo_magico.SetActive(false);
            tipo_mounstruo.SetActive(false);
        }

        tipo_normal.SetActive(false);
    }

    public void tipo_atributo(int i)
    {
        cardElementCount = i;
        
        if (i == 0)
        {
            agua.SetActive(true);
            fuego.SetActive(false);
            luz.SetActive(false);
            oscuridad.SetActive(false);
            tierra.SetActive(false);
            viento.SetActive(false);
            divinidad.SetActive(false);
        }
        else if (i == 1)
        {
            fuego.SetActive(true);
            agua.SetActive(false);
            luz.SetActive(false);
            oscuridad.SetActive(false);
            tierra.SetActive(false);
            viento.SetActive(false);
            divinidad.SetActive(false);
        }
        else if (i == 2)
        {
            luz.SetActive(true);
            agua.SetActive(false);
            fuego.SetActive(false);
            oscuridad.SetActive(false);
            tierra.SetActive(false);
            viento.SetActive(false);
            divinidad.SetActive(false);
        }
        else if (i == 3)
        {
            oscuridad.SetActive(true);
            agua.SetActive(false);
            fuego.SetActive(false);
            luz.SetActive(false);
            tierra.SetActive(false);
            viento.SetActive(false);
            divinidad.SetActive(false);
        }
        else if (i == 4)
        {
            tierra.SetActive(true);
            agua.SetActive(false);
            fuego.SetActive(false);
            luz.SetActive(false);
            oscuridad.SetActive(false);
            viento.SetActive(false);
            divinidad.SetActive(false);
        }
        else if (i == 5)
        {
            viento.SetActive(true);
            agua.SetActive(false);
            fuego.SetActive(false);
            luz.SetActive(false);
            oscuridad.SetActive(false);
            tierra.SetActive(false);
            divinidad.SetActive(false);
        }
        else if (i == 6)
        {
            divinidad.SetActive(true);
            agua.SetActive(false);
            fuego.SetActive(false);
            luz.SetActive(false);
            oscuridad.SetActive(false);
            tierra.SetActive(false);
            viento.SetActive(false);
        }
    }

    public void StarType(int i)
    {
        cardStarCount = i;
        ClearStars();

        for(int count = 0; count <= i; count++)
            stars[count].SetActive(true);
    }

    public void ClearStars()
    {
        for (int i = 0; i < stars.Count; i++)
            stars[i].SetActive(false);
    }
}