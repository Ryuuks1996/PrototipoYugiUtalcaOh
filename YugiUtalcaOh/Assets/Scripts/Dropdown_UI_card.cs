using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class Dropdown_UI_card : MonoBehaviour
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

    public GameObject estrella_1;
    public GameObject estrella_2;
    public GameObject estrella_3;
    public GameObject estrella_4;
    public GameObject estrella_5;
    public GameObject estrella_6;
    public GameObject estrella_7;
    public GameObject estrella_8;
    public GameObject estrella_9;
    public GameObject estrella_10;
    public GameObject estrella_11;
    public GameObject estrella_12;



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

    public void tipo_estrella(int i)
    {
        if (i == 0)
        {
            estrella_1.SetActive(true);
            estrella_2.SetActive(false);
            estrella_3.SetActive(false);
            estrella_4.SetActive(false);
            estrella_5.SetActive(false);
            estrella_6.SetActive(false);
            estrella_7.SetActive(false);
            estrella_8.SetActive(false);
            estrella_9.SetActive(false);
            estrella_10.SetActive(false);
            estrella_11.SetActive(false);
            estrella_12.SetActive(false);
        }
        else if (i == 1)
        {
            estrella_1.SetActive(false);
            estrella_2.SetActive(true);
            estrella_3.SetActive(false);
            estrella_4.SetActive(false);
            estrella_5.SetActive(false);
            estrella_6.SetActive(false);
            estrella_7.SetActive(false);
            estrella_8.SetActive(false);
            estrella_9.SetActive(false);
            estrella_10.SetActive(false);
            estrella_11.SetActive(false);
            estrella_12.SetActive(false);
        }
        else if (i == 2)
        {
            estrella_1.SetActive(false);
            estrella_2.SetActive(false);
            estrella_3.SetActive(true);
            estrella_4.SetActive(false);
            estrella_5.SetActive(false);
            estrella_6.SetActive(false);
            estrella_7.SetActive(false);
            estrella_8.SetActive(false);
            estrella_9.SetActive(false);
            estrella_10.SetActive(false);
            estrella_11.SetActive(false);
            estrella_12.SetActive(false);
        }
        else if (i == 3)
        {
            estrella_1.SetActive(false);
            estrella_2.SetActive(false);
            estrella_3.SetActive(false);
            estrella_4.SetActive(true);
            estrella_5.SetActive(false);
            estrella_6.SetActive(false);
            estrella_7.SetActive(false);
            estrella_8.SetActive(false);
            estrella_9.SetActive(false);
            estrella_10.SetActive(false);
            estrella_11.SetActive(false);
            estrella_12.SetActive(false);
        }
        else if (i == 4)
        {
            estrella_1.SetActive(false);
            estrella_2.SetActive(false);
            estrella_3.SetActive(false);
            estrella_4.SetActive(false);
            estrella_5.SetActive(true);
            estrella_6.SetActive(false);
            estrella_7.SetActive(false);
            estrella_8.SetActive(false);
            estrella_9.SetActive(false);
            estrella_10.SetActive(false);
            estrella_11.SetActive(false);
            estrella_12.SetActive(false);
        }
        else if (i == 5)
        {
            estrella_1.SetActive(false);
            estrella_2.SetActive(false);
            estrella_3.SetActive(false);
            estrella_4.SetActive(false);
            estrella_5.SetActive(false);
            estrella_6.SetActive(true);
            estrella_7.SetActive(false);
            estrella_8.SetActive(false);
            estrella_9.SetActive(false);
            estrella_10.SetActive(false);
            estrella_11.SetActive(false);
            estrella_12.SetActive(false);
        }
        else if (i == 6)
        {
            estrella_1.SetActive(false);
            estrella_2.SetActive(false);
            estrella_3.SetActive(false);
            estrella_4.SetActive(false);
            estrella_5.SetActive(false);
            estrella_6.SetActive(false);
            estrella_7.SetActive(true);
            estrella_8.SetActive(false);
            estrella_9.SetActive(false);
            estrella_10.SetActive(false);
            estrella_11.SetActive(false);
            estrella_12.SetActive(false);
        }
        else if (i == 7)
        {
            estrella_1.SetActive(false);
            estrella_2.SetActive(false);
            estrella_3.SetActive(false);
            estrella_4.SetActive(false);
            estrella_5.SetActive(false);
            estrella_6.SetActive(false);
            estrella_7.SetActive(false);
            estrella_8.SetActive(true);
            estrella_9.SetActive(false);
            estrella_10.SetActive(false);
            estrella_11.SetActive(false);
            estrella_12.SetActive(false);
        }
        else if (i == 8)
        {
            estrella_1.SetActive(false);
            estrella_2.SetActive(false);
            estrella_3.SetActive(false);
            estrella_4.SetActive(false);
            estrella_5.SetActive(false);
            estrella_6.SetActive(false);
            estrella_7.SetActive(false);
            estrella_8.SetActive(false);
            estrella_9.SetActive(true);
            estrella_10.SetActive(false);
            estrella_11.SetActive(false);
            estrella_12.SetActive(false);
        }
        else if (i == 9)
        {
            estrella_1.SetActive(false);
            estrella_2.SetActive(false);
            estrella_3.SetActive(false);
            estrella_4.SetActive(false);
            estrella_5.SetActive(false);
            estrella_6.SetActive(false);
            estrella_7.SetActive(false);
            estrella_8.SetActive(false);
            estrella_9.SetActive(false);
            estrella_10.SetActive(true);
            estrella_11.SetActive(false);
            estrella_12.SetActive(false);
        }
        else if (i == 10)
        {
            estrella_1.SetActive(false);
            estrella_2.SetActive(false);
            estrella_3.SetActive(false);
            estrella_4.SetActive(false);
            estrella_5.SetActive(false);
            estrella_6.SetActive(false);
            estrella_7.SetActive(false);
            estrella_8.SetActive(false);
            estrella_9.SetActive(false);
            estrella_10.SetActive(false);
            estrella_11.SetActive(true);
            estrella_12.SetActive(false);
        }
        else if (i == 11)
        {
            estrella_1.SetActive(false);
            estrella_2.SetActive(false);
            estrella_3.SetActive(false);
            estrella_4.SetActive(false);
            estrella_5.SetActive(false);
            estrella_6.SetActive(false);
            estrella_7.SetActive(false);
            estrella_8.SetActive(false);
            estrella_9.SetActive(false);
            estrella_10.SetActive(false);
            estrella_11.SetActive(false);
            estrella_12.SetActive(true);
        }
    }
}