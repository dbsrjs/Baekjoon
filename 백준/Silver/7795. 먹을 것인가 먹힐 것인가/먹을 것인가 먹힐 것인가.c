#include <stdio.h>
#include <stdlib.h>

// 비교 함수 (qsort에서 사용)
int compare(const void *a, const void *b) {
    return (*(int *)a - *(int *)b);
}

int main() {
    int len;
    scanf("%d", &len);

    for (int i = 0; i < len; i++) {
        int rs = 0;
        int sizeA, sizeB;
        
        // 입력 받기
        scanf("%d %d", &sizeA, &sizeB);
        
        int lisA[sizeA], lisB[sizeB];

        for (int j = 0; j < sizeA; j++)
            scanf("%d", &lisA[j]);

        for (int j = 0; j < sizeB; j++)
            scanf("%d", &lisB[j]);

        // B 배열 정렬
        qsort(lisB, sizeB, sizeof(int), compare);

        // A의 각 요소에 대해 B의 요소와 비교
        for (int j = 0; j < sizeA; j++) {
            int num = lisA[j];

            for (int k = 0; k < sizeB; k++) {
                if (num > lisB[k])
                    rs++;
                else
                    break;  // 정렬된 상태이므로 이후는 비교 불필요
            }
        }

        printf("%d\n", rs);
    }

    return 0;
}
