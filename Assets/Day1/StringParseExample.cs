using UnityEngine;

public class StringParseExample : MonoBehaviour
{
    void Start()
    {
        //문자열을 int로 변환
        string age = "26";
        int intAge = int.Parse(age); // 문자열을 정수로 변환
        int tryAge;
        bool result1 = int.TryParse(age, out tryAge); // 문자열을 정수로 변환 시도, 성공하면 true 반환
        if(result1)
        {
            Debug.Log("나이 변환 성공: " + tryAge);
        }
        else
        {
            Debug.Log("나이 변환 실패");
            Debug.Log("나이: " + intAge);
        }

        // float -> 문자열
        float floatHeight = 171.5f; // 키 (cm)
        string stringHeight = floatHeight.ToString(); // 실수를 문자열로 변환
        
        // 문자열을 float로 변환
        string weight = "70.5";
        float floatWeight = float.Parse(weight); // 문자열을 실수로 변환
        float tryWeight;
        bool result2 = float.TryParse(weight, out tryWeight); // 문자열을 실수로 변환 시도, 성공하면 true 반환
        if(result2)
        {
            Debug.Log("몸무게 변환 성공: " + tryWeight);
        }
        else
        {
            Debug.Log("몸무게 변환 실패");
            Debug.Log("몸무게: " + floatWeight);
        }
    }
}
