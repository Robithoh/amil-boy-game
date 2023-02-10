using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PindahPanel : MonoBehaviour
{
    public GameObject PanelAwal;
    public GameObject PanelTujuan;

    public void GantiKePanelBaru(){
        PanelAwal.SetActive (false);
        PanelTujuan.SetActive (true);
    }
}
