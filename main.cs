#include<iostream>
using namespace std;
int main()
{
	int a = 5;
	int *ptr;
	ptr = &a;
	cout <<"NEXT ADDRESS OF ASSIGNED LOCATION :"<< ptr+1 <<"\n"<< "PREVIOUS ADDRESS OF ASSIGNED LOCATION :" <<ptr-1;
	system("pause>0");
}
