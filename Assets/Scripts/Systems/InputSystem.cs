using UnityEngine.UI;
using UnityEngine;

public class InputSystem : MonoBehaviour
{
    [SerializeField] private SpawnSystem spawnSystem;
    [SerializeField] private InputField _time;
    [SerializeField] private InputField _speed;
    [SerializeField] private InputField _distance;
    [SerializeField] private Text warning;
    private float time;
    private int speed;
    private int distance;
    private bool isSpawn;

    public void CheckInput()
    {
        var stringDistance = _distance.text;
        var stringSpeed = _speed.text;
        var stringTime = _time.text;
        if(float.TryParse(stringTime, out time))
        {
            if(time == 0)
            {
                warning.text = "Время не должно быть равно 0";
                return;
            }
        }
        else
        {
            warning.text = "Введите время";
            return;
        }

        if (int.TryParse(stringSpeed, out speed))
        {
            if (speed == 0)
            {
                warning.text = "Скорость не должна быть равна 0";
                return;
            }
        }
        else
        {
            warning.text = "Введите скорость";
            return;
        }

        if (int.TryParse(stringDistance, out distance))
        {
            if (distance == 0)
            {
                warning.text = "Расстояние не должно быть равно 0";
                return;
            }
        }
        else
        {
            warning.text = "Введите расстояние";
            return;
        }

        SpawnCube();
    }

    private void SpawnCube()
    {
        warning.text = "";
        isSpawn = true;
        
    }

    private void Update()
    {
        if (isSpawn)
        {
            time -= Time.deltaTime;
            warning.text = time.ToString("0.00");
            if (time <= 0)
            {
                _time.text = "";
                _speed.text = "";
                _distance.text = "";
                isSpawn = false;
                spawnSystem.SpawnCube(speed, distance);
            }
        }
    }
}
