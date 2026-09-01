using UnityEngine;

public class AnimalWorldExample : MonoBehaviour
{
    // 다형성(폴리모피즐)
    // 많을 다 형태형 성질성
    // 하나의 객체가 여러 타입(자료형)을 가질 수 있는 성질
    private void Start()
    {
        Animal person1 = new Person("Seong", 26, 173f, 70, true);
        Animal cat1 = new Cat("Nabi", 0.5f, 1);

        Animal person2 = new Person("Blu_E", 26, 172f, 65, false);
        Animal dog1 = new Dog("Buddy", 1f, 2);

        Animal person3 = new Person("Bin", 26, 172f, 65, false);
        Animal dog2 = new Dog("ThurB", 2f, 5);

        Animal person4 = new Person("Jin", 26, 172f, 65, false);
        Animal goldFish1 = new GoldFish("Goldy", "gold");
        Animal goldFish2 = new GoldFish("Bubbles", "Orange");

        person1.Introduce();
        cat1.Introduce();
        person2.Introduce();
        dog1.Introduce();
        person3.Introduce();
        dog2.Introduce();
        person4.Introduce();
        goldFish1.Introduce();
        goldFish2.Introduce();

        // 클래스도 자료형이고 참조 타입이며 사용자 정의 자료형이라고 하기도 한다.
        Animal[] animals = new Animal[] { person1, cat1, person2, dog1, person3, dog2, person4, goldFish1, goldFish2 };
    
        for(int i = 0; i < animals.Length; i++)
        {
            //동물이 사람일 경우 자기소개 후 앉기
            if(animals[i] is Person person) // is: 객체가 실제로 해당 타입인지 검사한 후 그 결과를 bool 반환
            {
                person.Introduce();
                person.SitDown();
                /*
                Person person = (Person)animals[i]; // 명시적 형변환 - 강제 형변환 
                Person person = animals[i] as Person; // as: 객체가 해당 타입이면 형변환 후 반환, 아니면 null 반환
                 */
            }
            if(person = animals[i] as Person) // as: 객체가 해당 타입이면 형변환 후 반환, 아니면 null 반환
            {
                person.Introduce();
                person.SitDown();
            }
            else
                animals[i].Introduce();
        }
    }
}
