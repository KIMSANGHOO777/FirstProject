using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstCoding : MonoBehaviour
{

    // || ������ ���� �����ϱ� || <-- ���� ����

    public int numberInt1 = 9; //  <-- ������ ���� �� �ʱ�ȭ �� ���̴�. ��ü ���� ���α׷����� Ư����, ���� ���� ����, ������ ���ο� ���� ������� �� ���� ��� �ȴ�.
    public int numberInt2 = 2;

    int numberSum;
    int numberReminder;
    int numberSubstract;
    int numberMultiply;
    int numberDivide;
    // || �Ǽ��� ���� �����ϱ� ||

    public float numberFloat1;
    public float numberFloat2;
    float numberResult;

    // || ���ڿ� ���� �����ϱ� ||

    public string name = "�����";
    string job = " ���λ����";

    // || ���� ���� �����ϱ� ||

    private bool isMan; // <-- private �� �ܺ� ���� ���� ��Ű�� �ʴ´�.

    void Start() // void �� ��ȯ�� ���� �ʰ� ó���� �ϴ� �Լ��̴�.
    {
        // ��������
        // ���� �̸� = ��;



        /* number = 10;
         number2 = 1.5684565156f;
         name = "�����";
         isMan = true; */



        // numberResult = (float)numberInt1 / (float)numberInt2; // ������� �޴� ��(numberResult2)������ �ӽ� ����Ȳ�� �� �� ����. ����ȯ

        // numberReminder = numberInt2 % numberInt1; 

        // ��Ģ ������ -- [+(���ϱ�), -(������), *(���ϱ�), /(������ ��), %(���� ���� ������)]

        //  string result = name + job; // string result = name + numberInt1.ToString(); <-- ������ ���ڿ����� �������� ���� ������, ���ʰ� ���� �ڵ带 �ۼ� �ϸ� ���ڿ��� ���� �ȴ�.

        // print(result);



        // number1�� number2 ������ �հ谪�� ����Ѵ�.

        //numberSum = Sum(10, 20);

        // -------------------------------------------------------------------------------------

        numberSum = Sum(numberInt1, numberInt2); // ���� = �Լ�(����1, ����2)
        print(numberSum); // ���� numberSum �� ���.

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

    void Update() // void �� ��ȯ�� ���� �ʰ� ó���� �ϴ� �Լ��̴�.
    {
        
    }

    // �Լ� ����
    // �Լ��� ���� �� ����


    /*
     ��ȯ �ڷ���, �Լ� �̸� �׸��� (�Ű� ����1, �Ű�����2....)
      {
        ����
      }
    */


    // �� �ʿ��ϴ�.

    // �� ������ �Է� �޾Ƽ� �� �� ���� �հ� ���� ���� ���·� ��ȯ�ϴ� �Լ��� ����� �ʹ�.


    // -------------------------------------------------------------------------------------

    int Sum(int num1, int num2)
    {
        return num1 + num2;
    }


    // --------------------------------------------------------------------------------------------

    // �� ������ �Է� �޾Ƽ� �� �� ���� �� ���� ���� ���·� ��ȯ�ϴ� �Լ��� ����� �ʹ�.

    int Substract(int num1, int num2)
    {
        return num1 - num2;
    }

    // -------------------------------------------------------------------------------------

    // �� ������ �Է� �޾Ƽ� �� �� ���� �� ���� ���� ���·� ��ȯ�ϴ� �Լ��� ����� �ʹ�.

    int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }

    // -------------------------------------------------------------------------------------

    // �� ������ �Է� �޾Ƽ� �� �� ���� ���� �� ���� ���� ���·� ��ȯ�ϴ� �Լ��� ����� �ʹ�.

    int Divide(int num1, int num2)
    {
        return num1 / num2;
    }

    // ����ȯ�� �� ���� [[[[ �Ʒ� ]]]] �� ���� �� �ش�. <-- �� ������ ���� �Է����� �޾Ƽ�, �� ������ �ƴ��� ����� �Ǽ� ���·� ��ȯ�Ѵ�.

    /*
     
    float Divide(int num1, int num2)
    {
        return (float)num1 / (float)num2;
    }
     
     */

    // -------------------------------------------------------------------------------------

}
