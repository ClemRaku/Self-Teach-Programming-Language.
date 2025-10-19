.stack 100h
.model small
.data

head db "THIS IS VISIONARIES CALCULATOR", 0ah, 0dh, "$"





options db "Click 1 for Addition", 0ah, 0dh, "Click 2 for Subtraction" , 0ah, 0dh, "Click 3 for Multiplication", 0ah, 0dh, "Click 4 for Division", 0ah, 0dh , "$" 


ans db "Answer: $"
msg db "Enter first number: $"
msg2 db "Enter second number: $"
error db "ERROR$"


num1 dw 0
num2 dw 0

.code
main proc
    mov ax, @data
    mov ds, ax
    
    ;printing title
    lea dx, head
    mov ah, 09h
    int 21h
    
    ;printing huh
    lea dx, options
    mov ah, 09h
    int 21h
    
    ;taking input
    mov ah, 01h
    int 21h
    
    ;line break
    mov ah, 02h
    mov dl, 0ah
    int 21h
    mov ah, 02h
    mov dl, 0dh
    int 21h
    
    
    cmp al, '1'
    JZ addition
    cmp al, '2'
    ;JZ subtraction
    ;cmp al, '3'
    ;JZ multiplication
    ;cmp al, '4'
    ;JZ division
    

    
     
     
addition:

    lea dx, msg
    mov ah, 09h
    int 21h
    
    ;taking a number
    call ReadNumber
    mov num1, ax
    
    lea dx, msg2
    mov ah, 09h
    int 21h
    
    ;taking num 2
    call ReadNumber
    mov num2, ax
    
    mov ax, num1
    add ax, num2
    
    call PrintNumber
    
    jmp end


    
    


ReadNumber:
    xor ax, ax
    
    nextDigit:
    
    mov ah, 01h
    int 21h
    
    cmp al, 0dh ;checking whether Enter is clicked
    JE done
    
    sub al, "0"
    xor bx, bx
    mov bl, al
    ;AX = AX*10 + digit
    mov cx, 10
    mul cx
    add ax, bx
    jmp nextDigit
done:
    ret

    
PrintNumber:
    xor cx, cx
next:
    
    xor dx, dx
    mov bx, 10
    div bx
    push dx
    inc cx
    test ax, ax
    JNZ next
printLOOP:
    pop dx
    add dl, "0"; converting back to ascii
    ;printing
    mov ah, 02h
    int 21h
    
    ;dec
    dec cx
    test cx, cx
    JNZ printLOOP
    
    ret    
     
                       

     
end:     
    ;ending
    mov ah, 4ch
    int 21h
    
    main ENDP
end main
        
   
