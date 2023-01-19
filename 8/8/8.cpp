#include <iostream>
#include <iomanip>
#include <istream>
#include <sstream>
#include <string>

using namespace std;
int main() {
	//флаг dec(10), hex(16), oct(8)
	int s;
	cout << "\nVvod : ";
	cin >> s;
	cout << "print v dec : " << dec << s << endl;
	cout << "print v oct : " << oct << s << endl;
	cout << "print v hex : " << hex << s << endl;



	//флаг setprecision()
	double d = 10.355;
	cin >> d;
	cout << setiosflags(ios::fixed);
	cout << setprecision(2) << d << endl;
	//Если флаг fixed не использовался, то число 1384 будет выведено как 1.4e+03, потому что setprecision(2)
	//в этом случае задаёт количество значащих десятичных цифр в числе. Если использовать fixed или scientific, то setprecision(2) 
	//задаёт количество цифр после точки, то есть вывод будет 1384.00 и 1.38e+03 соответственно.



	//флаг setfill()
	cout << "default fill: [" << setw(10 + 2) << 42 << "]\n";
	cout << "setfill('*'): [" << setfill('*') << setw(10 + 2) << 42 << "]\n";



	//флаг ws
		setlocale(LC_ALL, "rus");
		const char* str ("\t #2 test");
		string line;
		getline(istringstream{ str }, line);
		cout << "Вывод без ws: " << quoted(line) << '\n';
		istringstream iss{ str };
		getline(iss >> ws, line);
		cout << "Вывод с ws  : " << quoted(line) << '\n';


	float test = 13.4543;
	//cin >> test;
	cout << setw(12) << test << endl;
	cout << setw(12) << test << endl;
	cout << setfill('-') << setw(12) << test << endl;
	cout << setfill(' ') << setw(12) << test << endl;

	cout << setfill('-');
	cout << right << setw(8) << "left : " << setw(15) << test << endl;
	cout << left << setw(8) << "right: " << setw(15) << test << endl;

	// Zadanie 2
	//double test;
	//cin >> test;
	//cout << setprecision(2) << test << endl;

	//cout.setf(ios::left | ios::fixed | ios::showpos);
	//cout << setprecision(2) << test << endl;
	//cout.unsetf(ios::left | ios::fixed | ios::showpos);

	//cout.setf(ios::right | ios::scientific);
	//cout << setprecision(2) << test << endl;
	//cout.unsetf(ios::right | ios::scientific);

	//cout << setprecision(2) << test << endl;
}

//char s[255] = "Random text\n";
//
//ostream& endp(ostream& str)
//{
//	char ss[255];
//	static int k = 0;
//	int i, j, c = 2;
//	for (i = 0, j = 0; s[j] != '\0'; i++, j++){
//		ss[i] = s[j];
//		if (ss[i] == '\n'){
//			k++;
//			if (k == c){
//				ss[i + 1] = ' ';
//				str << "-------------\n";
//				i = -1;
//				k = 0;
//			}
//		}
//	}
//	if (i < 0){
//		ss[i + 1] = '\0';
//		str << ss;
//	}
//	return str;
//}
//
//int main(){
//	for (int i = 0; i < 7; i++)
//		cout << s << endp;
//}

//Now!is#the!time#for!fun#!
//int main(){
//	char ch;
//	cout << "enter: ";
//	while (cin.get(ch)){
//		if (ch == '!')
//			cin.putback('$');
//		else
//			cout << ch;
//		while (cin.peek() == '#')
//			cin.ignore(1, '#');
//	}
//}


////once upon а time
//int main(){
//	char string0ne[255];
//	char stringTwo[255];
//	cout << "Enter string one:";
//	cin.get(string0ne, 255);
//	cout << "String one: " << string0ne << endl;
//	cout << "Enter string two: ";
//	cin.getline(stringTwo, 255);
//	cout << "String two: " << stringTwo << endl;
//	cout << "\n\nNow try again...\n";
//	cin.ignore(255, '\n');
//	cout << "Enter string two: ";
//	cin.getline(stringTwo, 255);
//	cout << "String Two: " << stringTwo << endl;
//	cout << "Enter string one: ";
//	cin.get(string0ne, 255);
//	cout << "String one: " << string0ne << endl;
//}