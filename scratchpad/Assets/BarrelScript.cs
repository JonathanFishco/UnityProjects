using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelScript : MonoBehaviour
{
    public int m_gallons
    public int m_size

    public void fill(int gallons)
    {
        m_gallons +=gallons;

        if (m_gallons > m_size)
            m_gallons = m_size;
    }
    public void drain(int gallons)
    {
        m_gallons -=gallons;

        if (m_gallons < 0)
            m_gallons = 0;
    }
}
