using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarAudio : MonoBehaviour
{
    public AudioSource Engine;
    public SpeedCalculator Speed;

    public AudioSource GearChangeSound;


    public float PitchOffSet1;
    public float PitchOffSet2;
    public float PitchOffSet3;
    public float PitchOffSet4;
    public float PitchOffSet5;
    public float PitchOffSet6;
    public float PitchOffSet7;
    public float PitchOffSet8;

    void Start()
    {

    }

    void Update()
    {
        PitchControl();
        GearChange();
        EngineVolume();
    }


    public void EngineVolume()
    {

            if (Input.GetAxis("Vertical") == 1)
            {
                Engine.volume += Time.deltaTime;
            }
            else
            {
                if (Engine.volume > 0.1f)
                {
                    Engine.volume -= Time.deltaTime;
                }
            }      

    }


    public void GearChange()
    {
        if (Speed.Speed > 30 & Speed.Speed < 31)
        {
            if(GearChangeSound.isPlaying == false)
            {
                GearChangeSound.Play();
            }
        }

        if (Speed.Speed > 60 & Speed.Speed < 61)
        {
            if (GearChangeSound.isPlaying == false)
            {
                GearChangeSound.Play();
            }
        }

        if (Speed.Speed > 90 & Speed.Speed < 91)
        {
            if (GearChangeSound.isPlaying == false)
            {
                GearChangeSound.Play();
            }
        }

        if (Speed.Speed > 120 & Speed.Speed < 121)
        {
            if (GearChangeSound.isPlaying == false)
            {
                GearChangeSound.Play();
            }
        }

        if (Speed.Speed > 150 & Speed.Speed < 151)
        {
            if (GearChangeSound.isPlaying == false)
            {
                GearChangeSound.Play();
            }
        }

        if (Speed.Speed > 200 & Speed.Speed < 201)
        {
            if (GearChangeSound.isPlaying == false)
            {
                GearChangeSound.Play();
            }
        }

        if (Speed.Speed > 280 & Speed.Speed < 281)
        {
            if (GearChangeSound.isPlaying == false)
            {
                GearChangeSound.Play();
            }
        }

        if (Speed.Speed > 340 & Speed.Speed < 341)
        {
            if (GearChangeSound.isPlaying == false)
            {
                GearChangeSound.Play();
            }
        }
    }

    public void PitchControl()
    {
        if (Speed.Speed > 0 & Speed.Speed < 30)
        {
            Engine.pitch = Speed.Speed * PitchOffSet1;
        }

        if (Speed.Speed > 30 & Speed.Speed < 60)
        {
            Engine.pitch = Speed.Speed * PitchOffSet2;
        }

        if (Speed.Speed > 60 & Speed.Speed < 90)
        {
            Engine.pitch = Speed.Speed * PitchOffSet3;
        }

        if (Speed.Speed > 90 & Speed.Speed < 120)
        {
            Engine.pitch = Speed.Speed * PitchOffSet4;
        }

        if (Speed.Speed > 120 & Speed.Speed < 150)
        {
            Engine.pitch = Speed.Speed * PitchOffSet5;
        }

        if (Speed.Speed > 150 & Speed.Speed < 200)
        {
            Engine.pitch = Speed.Speed * PitchOffSet6;
        }

        if (Speed.Speed > 200 & Speed.Speed < 280)
        {
            Engine.pitch = Speed.Speed * PitchOffSet7;
        }

        if (Speed.Speed > 280 & Speed.Speed < 340)
        {
            Engine.pitch = Speed.Speed * PitchOffSet8;
        }
    }


}
