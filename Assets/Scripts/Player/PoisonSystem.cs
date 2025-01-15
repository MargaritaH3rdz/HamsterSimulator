using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PoisonSystem : MonoBehaviour
{
    // Variables publicas
    public PostProcessVolume ppVolume;
    public float healingTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ppVolume.weight > 0f)
        {
            ppVolume.weight -= (1f / healingTime) * Time.deltaTime;
        }
    }

    public void Poisoning()
    {
        ppVolume.weight = 1.0f;
    }
}
