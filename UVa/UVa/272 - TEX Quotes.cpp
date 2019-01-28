#include <cstdio>
#include <cstring>

using namespace std;

int main() {
	char c;
	bool open = 1;

	while (scanf("%c", &c) != EOF) {
		if (c == '"') {
			if (open)
				printf("``");
			else
				printf("''");

			open = (!open);
		}
		else {
			printf("%c", c);
		}
	}

	return 0;
}