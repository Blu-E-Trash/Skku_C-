using UnityEngine;

public class Dog : Animal
{
    

    public Dog(string name, float height, double weight)
    {
        _name = name;
        _height = height;
        _weight = weight;
    }

    override public void Introduce()
    {
        Debug.Log($"왈왈 이름: {_name}, 키: {_height}, 몸무게: {_weight} ");
    }
    //public void Run()
    //{
    //    Debug.Log($"[{_name}] 달린다! 속도: {100 - (_height / _weight)}");
    //}
}
