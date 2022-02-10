.global _start
.data
        str: .ascii "Hello world\n"
        end:
.text
_start:
        mov $4, %EAX		#write() function
        mov $1, %EBX		#stdout
        mov $str, %ECX		#(char*) addr of str
        mov $end-str, %EDX	#str length
        int $0x80
        mov $1, %EAX		#exit() function
        mov $0, %EBX		#exit code
        int $0x80
	nop
