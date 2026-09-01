using System.Xml.Linq;
using UnityEngine;

public class GoldFish : Animal
{
    private string _color;
    public GoldFish(string name, string color)
    {
        _name = name;
        _color = color;
        float _height = 2;
        double _weight = 0.3;

    }
    override public void Introduce()
    {
        Debug.Log($"뽀글 이름: {_name}, 색깔: {_color}, 키: {_height}, 몸무게: {_weight}");
    }
}
