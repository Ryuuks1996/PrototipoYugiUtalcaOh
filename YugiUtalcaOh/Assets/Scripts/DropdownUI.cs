using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class DropdownUI : MonoBehaviour
{
    public GameObject tipo_normal;
    public GameObject tipo_mounstruo;
    public GameObject tipo_magico;
    public GameObject tipo_trampa;

    public GameObject fuego;
    public GameObject agua;
    public GameObject divinidad;
    public GameObject luz;
    public GameObject oscuridad;
    public GameObject tierra;
    public GameObject viento;

    public List<GameObject> stars;

    public object onValueChanged { get; internal set; }

    public void tipo_carta(int i)
    {
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

    public void StarAmount(int i)
    {

    }
}