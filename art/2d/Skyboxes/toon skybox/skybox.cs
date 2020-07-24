//includes rotating and daynight cycle
using UnityEngine;
public class skybox :MonoBehaviour
{

    [SerializeField]
    bool rotate;
    public float RotationPerSecond = 1;

    [SerializeField] 
    bool day_night_cycle;
    [SerializeField]
    int day_length = 300;
     int time;
    int t;
    bool ascending=true;

    [SerializeField]
    Material[] Skyboxes;



 void Start()
    {
        ascending = true;
        time = PlayerPrefs.GetInt("time");
    }

    void FixedUpdate()
    {

        if (day_night_cycle) {
       
            t++;

            if (t > 60 - 1)
            {
                PlayerPrefs.SetInt("time", time);
                if (ascending)
                {
                    time++;
                }
                if (!ascending)
                {
                    time--;
                }

                RenderSettings.skybox = Skyboxes[Mathf.RoundToInt(time / (day_length / Skyboxes.Length + 1))];
                t = 0;
            }

            if (time > day_length - 1)
            {
                ascending = false;
            }
            if (time == 0)
            {
                ascending = true;
            }
        }


        if (rotate)
        {
            RenderSettings.skybox.SetFloat("_Rotation", Time.time * RotationPerSecond);

        }

    }

}
