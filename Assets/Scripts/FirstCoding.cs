using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstCoding : MonoBehaviour
{

    // || 정수형 변수 선언하기 || <-- 전역 변수

    public int numberInt1 = 9; //  <-- 변수의 선언 및 초기화 한 것이다. 객체 지향 프로그래밍의 특성상, 기존 변수 말고, 변수에 새로운 값을 넣으며느 그 값이 출력 된다.
    public int numberInt2 = 2;

    int numberSum;
    int numberReminder;
    int numberSubstract;
    int numberMultiply;
    int numberDivide;
    // || 실수형 변수 선언하기 ||

    public float numberFloat1;
    public float numberFloat2;
    float numberResult;

    // || 문자열 변수 선언하기 ||

    public string name = "김상후";
    string job = " 개인사업자";

    // || 논리형 변수 선언하기 ||

    private bool isMan; // <-- private 는 외부 툴에 노출 시키지 않는다.

    void Start() // void 는 반환을 하지 않고 처리만 하는 함수이다.
    {
        // 변수사용법
        // 변수 이름 = 값;



        /* number = 10;
         number2 = 1.5684565156f;
         name = "김상후";
         isMan = true; */



        // numberResult = (float)numberInt1 / (float)numberInt2; // 결과값을 받는 곳(numberResult2)에서는 임시 형변황을 할 수 없다. 형변환

        // numberReminder = numberInt2 % numberInt1; 

        // 사칙 연산자 -- [+(더하기), -(나누기), *(곱하기), /(나누기 몫), %(나는 값의 나머지)]

        //  string result = name + job; // string result = name + numberInt1.ToString(); <-- 정수와 문자열간의 상관과계는 없기 때문에, 왼쪽과 같이 코드를 작성 하면 문자열로 연결 된다.

        // print(result);



        // number1과 number2 변수의 합계값을 출력한다.

        //numberSum = Sum(10, 20);

        // -------------------------------------------------------------------------------------

        numberSum = Sum(numberInt1, numberInt2); // 변수 = 함수(변수1, 변수2)
        print(numberSum); // 변수 numberSum 을 출력.

        // -------------------------------------------------------------------------------------

        numberSubstract = Substract(numberInt1, numberInt2);
        print(numberSubstract);

        // -------------------------------------------------------------------------------------

        numberMultiply = Multiply(numberInt1, numberInt2);
        print(numberMultiply);

        // -------------------------------------------------------------------------------------

        numberDivide = Divide(numberInt1, numberInt2);
        print(numberDivide);

        // -------------------------------------------------------------------------------------


    }

    void Update() // void 는 반환을 하지 않고 처리만 하는 함수이다.
    {
        
    }

    // 함수 선언
    // 함수를 선언 할 때는


    /*
     반환 자료형, 함수 이름 그리고 (매개 변수1, 매개변수2....)
      {
        할일
      }
    */


    // 이 필요하다.

    // 두 정수를 입력 받아서 그 두 수의 합계 값을 정수 형태로 반환하는 함수를 만들고 싶다.


    // -------------------------------------------------------------------------------------

    int Sum(int num1, int num2)
    {
        return num1 + num2;
    }


    // --------------------------------------------------------------------------------------------

    // 두 정수를 입력 받아서 그 두 수의 차 값을 정수 형태로 반환하는 함수를 만들고 싶다.

    int Substract(int num1, int num2)
    {
        return num1 - num2;
    }

    // -------------------------------------------------------------------------------------

    // 두 정수를 입력 받아서 그 두 수의 곱 값을 정수 형태로 반환하는 함수를 만들고 싶다.

    int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }

    // -------------------------------------------------------------------------------------

    // 두 정수를 입력 받아서 그 두 수의 나눈 몫 값을 정수 형태로 반환하는 함수를 만들고 싶다.

    int Divide(int num1, int num2)
    {
        return num1 / num2;
    }

    // 형변환을 할 때는 [[[[ 아래 ]]]] 와 같이 해 준다. <-- 두 정수의 값을 입력으로 받아서, 두 정수의 아눗셈 결과를 실수 형태로 반환한다.

    /*
     
    float Divide(int num1, int num2)
    {
        return (float)num1 / (float)num2;
    }
     
     */

    // -------------------------------------------------------------------------------------

}
