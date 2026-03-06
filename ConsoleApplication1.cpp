// ConsoleApplication1.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
#include <cmath>

using namespace std;

int main()
{
    setlocale(LC_ALL, "RUS");


    cout << "Напишите значения a b c\n";
    
    double c, a, b, d, x1, x2;
    cin >> (a);
    cin >> (b);
    cin >> (c);
    
    d = ((b*b)-(4*a*c));
    cout << "Дескреминант = " << d << "\n";

    if (d > 0)
    {
       // cout << "Дескреминант = " << d << "\n";
        x1 = ((-b - sqrt(d)) / (2 * a));
        x2 = ((-b + sqrt(d)) / (2 * a));
        cout << "X1 и X2 " << x1 << " " << x2 << "\n";
        //break; 
    }
    else if (d == 0)
        {
            x1 = -b / (2 * a)
                cout << "X1" << x1 << "\n";
          //  break;

        }
        else
            cout << "Нет корней";
    }
    

}
