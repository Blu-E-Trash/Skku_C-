using UnityEngine;

public class PersonClassExaple : MonoBehaviour
{
    private void Start()
    {
        Chair chair1 = new Chair();
        Chair chair2 = new Chair();
        chair2.Color = "Blue";
        Person Person1 = new Person("JuYeol",18, 182.7f, 78, false );
        //Debug.Log(Person1.Name);
        //Person1.Name = "Good";
        //Person1.Age = 18;
        Debug.Log(Person1.HasGlasses);

        //Person1.Name = "JuYeol";
        //Person1.Age = 18;
        //Person1.Height = 182.7f;
        //Person1.Weight = 78;
        //Person1.HasGlasses = false;

        Person1.Introduce();
        Person1.Run();
        Person1.SitDown(chair1);

        Person Person2 = new Person("Cat", 18, 182.7f, 78, false);

        //Person2.Name = "Cat";
        //Person2.Age = 18;
        //Person2.Height = 182.7f;
        //Person2.Weight = 78;
        //Person2.HasGlasses = false;

        Person2.Introduce();
        Person2.Run();
        Person1.SitDown();

        Person1.Punch(Person2);

        Person Person3 = null; // 메모리 주소를 가리킬 변수만 만들었지, 알맹이는 존재하지 않음
        //null - 존재하지 않음
        // 객체지향 프로그래밍에서 제임스 고슬링이 후회하는 문법 중 하나
        // 가장 빈번하게 오류를 일으키는 문법

        Person1.Punch(Person3);
    }

    private void Update()
    {
        
    }
}
