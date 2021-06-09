#include<iostream>
#include<cstdio>
using namespace std;
int main() {
	freopen("output.txt", "r", stdin);
	freopen("cnt.txt", "w", stdout);
	ios::sync_with_stdio(false);
	long long a[10]={0};
	char tmp;
	while(cin>>tmp) {
		++a[tmp-'0'];
	}
	for(int i=0; i<10; ++i) {
		cout<<a[i]<<endl;
	}
	return 0;
}
