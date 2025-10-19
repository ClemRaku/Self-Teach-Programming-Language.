.stack 100h
.model small
.data

head db "THIS IS VISIONARIES CALCULATOR", 0ah, 0dh, "$"





options db "Click 1 for Addition", 0ah, 0dh, "Click 2 for Subtraction" , 0ah, 0dh, "Click 3 for Multiplication", 0ah, 0dh, "Click 4 for Division", 0ah, 0dh , "$" 


ans db "Answer: $"
msg db "Enter first number: $"
msg2 db "Enter second number: $"
error db "ERROR$"

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
    JZ subtraction
    ;cmp al, '3'
    ;JZ multiplication
    ;cmp al, '4'
    ;JZ division
    

    
     
     
addition:

    lea dx, msg
    mov ah, 09h
    int 21h
    
    ;taking num1
    mov ah, 01h
    int 21h
    sub al, '0'

    mov bl, al;storing al in bl for later purposes
    
    ;line break
    mov ah, 02h
    mov dl, 0ah
    int 21h
    mov ah, 02h
    mov dl, 0dh
    int 21h
    
    
    lea dx, msg2
    mov ah, 09h
    int 21h
    
    ;taking num2
    mov ah, 01h
    int 21h
    sub al, '0'
        
    add bl, al;addition
    add bl, '0'

    ;line break
    mov ah, 02h
    mov dl, 0ah
    int 21h
    mov ah, 02h
    mov dl, 0dh
    int 21h    
    
    mov ah, 09h
    lea dx, ans
    int 21h
    
    ;printing the result
    mov ah, 02h
    mov dl, bl
    int 21h
    
    jmp end     
    
subtraction:
        
    lea dx, msg
    mov ah, 09h
    int 21h
    
    ;taking num1
    mov ah, 01h
    int 21h

    mov bl, al;storing al in bl for later purposes
    
    ;line break
    mov ah, 02h
    mov dl, 0ah
    int 21h
    mov ah, 02h
    mov dl, 0dh
    int 21h
    
    
    lea dx, msg2
    mov ah, 09h
    int 21h
    
    ;taking num2
    mov ah, 01h
    int 21h
                 
    sub bl, al
    
    sub bl, '0'
    
    ;line break
    mov ah, 02h
    mov dl, 0ah
    int 21h
    mov ah, 02h
    mov dl, 0dh
    int 21h    
    
    mov ah, 09h
    lea dx, ans
    int 21h
    ;printing the result
    mov ah, 02h
    mov dl, bl
    int 21h     
    
    jmp end     
     
     
end:     
    ;ending
    mov ah, 4ch
    int 21h
    
    main ENDP
end main
        
   
