using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameInterfase : MonoBehaviour
{
    public int and;
    public int his_Cor;
    public Data data;
    public Text record, hiscor;
    public static GameInterfase rid { get; set; }
    private int stat;
    void Awake()
    {
        his_Cor = data.record;
        stat = data.record + and;
        if (rid == null)
        {
            rid = this;
        }
        else
        {
            Destroy(this);
        }
    }
    void OnDestroy()
    {
        rid = null;
    }
    void Update()
    {
        record.text = "" + data.record;
        hiscor.text = "" + his_Cor;

        if (his_Cor == data.record + 10)
        {
            data.record = his_Cor;
            SaveAndLoad.Instance.Save();
            Teleport.rid.Rendom();
        }
        if (his_Cor == stat)
        {
            Interface.rid.Andlevel();
            data.record = his_Cor;
            SaveAndLoad.Instance.Save();
        }
    }
}
