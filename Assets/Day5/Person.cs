using UnityEngine;

public class Person: Animal
{
    // 필드 (속성)
    // public -> 외부에서 접근(읽기, 쓰기) 가능
    // private -> 외부에서 접근이 불가능하다.
    // -> 접근 제한자(public, private, protected, internal)

    // 추상화 -> 은닉화 -> 캡슐화
    public bool HasGlasses = false;
    //private string _name;
    private int _age = 0;
    //private float _height = 0f;
    //private double _weight = 0f;



    // 생성자 메서드
    // - 객체가 생성될 때, new 키워드와 함께 호출하는 메서드
    // - 클래스 이름과 같아야 한다.
    public Person(string name, int age, float height, double weight, bool hasGlasses)
    {
        _name = name;
        _age = age;
        _height = height;
        _weight = weight;
        HasGlasses = hasGlasses;
    }

    // 메서드 (기능, 함수)
    override public void Introduce()
    {
        Debug.Log($"Hi, My Name is {_name}, Age is {_age}, height is {_height}, weight is {_weight}");
    }
    //public void Run() 
    //{
    //    Debug.Log($"[{_name}] is Riunnig! Speed: {100 - _height / _weight}");
    //}
    
    // 매서드 오버로드: 같은 이름의 메서드를 중복하여 여러 개 만드는 것
    // -매개 변수의 개수나 자료형이 달라야 한다.
    public void SitDown(Chair Chair)
    {
        Debug.Log($"{Chair.Color}색 의자에 앉는다.");
    }
    public void SitDown()
    {
        Debug.Log("앉는다.");
    }
    public void Punch(Person otherPerson)
    {
        // 김이 박을 때렸다
        Debug.Log($"{_name}가 {otherPerson._name}이를 때렸다. ");
    }

    // public 필드 변수는 : Name(파스칼)
    // private 필드 변수는 : _name(_카멜)
    //          지역 변수는 : name(카멜)

}