using UnityEngine;

abstract public class Animal : MonoBehaviour //추상 클래스 : new 연산자를 이용해서 객체를 못만듬
{
    // protected : 외부에서는 접근 불가능하지만, 내부 혹은 자식 클래스에서는 접근 가능
    protected string _name = string.Empty;
    protected float _height = 0f;
    protected double _weight = 0f;

    // 추상 메서드 -> 구현이 없는 메소드(함수만 선언되어 있음) -> 상속받은 자식 클래스에서 반드시 구현해야 함
    abstract public void Introduce();

    virtual public void Run()
    {
        Debug.Log($"[{_name}] 달린다! 속도: {100 - (_height / _weight)}");
    }
}
