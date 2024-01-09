namespace _02._Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        /*
        

1.산술 연산자

​

(1)이진 연산자

+ (더하기)

- (빼기)

* (곱하기)

/ (나누기) (int 5 / 3은 소수점 자동 버림)

% (나머지)

​

(2)단항 연산자

iValue = +iValue;   // + 단항연산자(양수)  : 값을 반환

iValue = -iValue;   // - 단항연산자(음수)  : 값의 마이너스를 반환

​

++iValue;           // ++ 전위증가연산자   : 값을 1 증가 (Console.WriteLine(++iValue); // output : 1)

iValue++;           // ++ 후위증가연산자   : 값을 1 증가( Console.WriteLine(iValue++); // output : 0)

--iValue;           // -- 전위감소연산자   : 값을 1 감소

iValue--;           // -- 후위감소연산자   : 값을 1 감소

2.대입 연산자

= : 오른쪽의 값을 왼쪽 변수에 대입

ex) iValue = 10;

3.비교 연산자

 >  : 왼쪽 피연산자가 더 클 경우 true

 <  : 왼쪽 피연산자가 더 작을 경우 true

 >= : 왼쪽 피연산자가 더 크거나 같은 경우 true

<= : 왼쪽 피연산자가 더 작거나 같은 경우 true

== : 두 피연산자가 같은 경우 true

!= : 두 피연산자가 다를 경우 true

4.논리 연산자

! (Not)  : 피연산자의 논리 부정을 반환

&& (And) : 두 피연산자가 모두 true 일 경우 true

|| (Or)  : 두 피연산자가 모두 false 일 경우 false

^ (Xor)  : 두 피연산자가 다를 경우 true

+연산자 우선순위

1. 기본 연산        : a[i], x++, x--

2. 단항 연산        : +x, -x, !x, ~x, ++x, --x, (Type)x

3. 곱하기 연산      : x * y, x / y, x % y

4. 더하기 연산      : x + y, x - y

5. 시프트 연산      : x << y, x >> y

6. 비교 연산        : x < y, x > y, x <= y, x >= y

7. 같음 연산        : x == y, x != y

8. 논리 AND 연산    : x & y, x && y

9. 논리 XOR 연산    : x ^ y

10. 논리 OR 연산    : x | y, x || y

11. 대입 연산       : x = y, x op= y




​*/
    }
}
