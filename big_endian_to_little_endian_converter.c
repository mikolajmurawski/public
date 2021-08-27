#include<stdio.h>
#include<math.h>
void bits16(unsigned short x)
{
	unsigned short reversed_number=0;
	unsigned int array[2][8] = {0}, byte_position=0, bit_position=0, q=15;
	printf("Big Endian\n");
	for(int i=15;i>=0;i--)
	{
		if(x & 1<<i)
		{
			printf("1");
			array[byte_position][bit_position]=1;
		}
		else
		{
			printf("0");
			array[byte_position][bit_position]=0;
		}
		bit_position++;
		if(i%8 == 0)
		{
			printf(" ");
			byte_position++;
			bit_position=0;
		};
	}
	printf(" = %hu\n",x);
	printf("Little Endian\n");
	for(int i=1;i>=0;i--)
	{
		for(int j=0;j<8;j++)
		{
			printf("%u",array[i][j]);
			if(array[i][j]==1)
			{
				reversed_number=reversed_number+pow(2,q);
			};
			q--;
		}
		printf(" ");
	}
	printf(" = %hu\n",reversed_number);
	printf("------------------------------------\n");
}
void bits32(unsigned int x)
{
	unsigned int reversed_number=0;
	unsigned int array[4][8] = {0}, byte_position=0, bit_position=0, q=31;
	printf("Big Endian\n");
	for(int i=31;i>=0;i--)
	{
		if(x & 1<<i)
		{
			printf("1");
			array[byte_position][bit_position]=1;
		}
		else
		{
			printf("0");
			array[byte_position][bit_position]=0;
		}
		bit_position++;
		if(i%8 == 0)
		{
			printf(" ");
			byte_position++;
			bit_position=0;
		};
	}
	printf(" = %u\n",x);
	printf("Little Endian\n");
	for(int i=3;i>=0;i--)
	{
		for(int j=0;j<8;j++)
		{
			printf("%u",array[i][j]);
			if(array[i][j]==1)
			{
				reversed_number=reversed_number+pow(2,q);
			};
			q--;
		}
		printf(" ");
	}
	printf(" = %u\n",reversed_number);
	printf("------------------------------------\n");
}
void bits64(unsigned long long x)
{
	unsigned long long reversed_number=0;
	unsigned int array[8][8] = {0}, byte_position=0, bit_position=0, q=63;
	printf("Big Endian\n");
	for(int i=63;i>=0;i--)
	{
		if(x & (long long)1<<i)
		{
			printf("1");
			array[byte_position][bit_position]=1;
		}
		else
		{
			printf("0");
			array[byte_position][bit_position]=0;
		}
		bit_position++;
		if(i%8 == 0)
		{
			printf(" ");
			byte_position++;
			bit_position=0;
		};
	}
	printf(" = %llu\n",x);
	printf("Little Endian\n");
	for(int i=7;i>=0;i--)
	{
		for(int j=0;j<8;j++)
		{
			printf("%u",array[i][j]);
			if(array[i][j]==1)
			{
				reversed_number=reversed_number+powl(2,q);
			};
			q--;
		}
		printf(" ");
	}
	printf(" = %llu\n",reversed_number);
	printf("------------------------------------\n");
}
int main(){
	while(1)
	{
		unsigned long long n;
		printf("Enter a number: ");
		scanf("%llu",&n);
		bits16((unsigned short)n);
		bits32((unsigned int)n);
		bits64(n);
	}
}
