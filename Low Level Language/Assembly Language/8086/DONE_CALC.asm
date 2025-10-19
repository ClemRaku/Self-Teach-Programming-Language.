.stack 100h
.model small
.data

head db "THIS IS VISIONARIES CALCULATOR", 0ah, 0dh, "$"


rule db "Calculator of numbers Ranging from 0 to 9", 0ah, 0dh, "$"


options db "Click 1 for Addition", 0ah, 0dh, "Click 2 for Subtraction" , 0ah, 0dh, "Click 3 for Multiplication", 0ah, 0dh, "Click 4 for Division", 0ah, 0dh , "$" 

again db "Click 1 to do Calculation again", 0ah, 0dh, "OR Click any button to end the Program", 0ah, 0dh, "$"

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
    
    ;printing rules
    lea dx, rule
    mov ah, 09h
    int 21h
    
    
reset:
    
    
    ;printing huh
    lea dx, options
    mov ah, 09h
    int 21h
    
    ;taking input
    mov ah, 01h
    int 21h

    cmp al, '1'
    JZ addition
    cmp al, '2'
    JZ subtraction
    cmp al, '3'
    JZ multiplication
    cmp al, '4'
    JZ division
    
    lea dx, error
    mov ah, 09h
    int 21h
     
addition:

    ;line break
    mov ah, 02h
    mov dl, 0ah
    int 21h
    mov ah, 02h
    mov dl, 0dh
    int 21h

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
    
    ;line break
    mov ah, 02h
    mov dl, 0ah
    int 21h
    mov ah, 02h
    mov dl, 0dh
    int 21h    
    
    lea dx, again
    mov ah, 09h
    int 21h
    
    ;checking to reset or not
    mov ah, 01h
    int 21h
    mov bl, al
    
    ;line break
    mov ah, 02h
    mov dl, 0ah
    int 21h
    mov ah, 02h
    mov dl, 0dh
    int 21h
        
    cmp bl, '1'
    jz reset    
    
    
    jmp end     
    
subtraction:
    ;line break
    mov ah, 02h
    mov dl, 0ah
    int 21h
    mov ah, 02h
    mov dl, 0dh
    int 21h
        
    lea dx, msg
    mov ah, 09h
    int 21h
    
    ;taking num1
    mov ah, 01h
    int 21h

    mov bl, al;storing al in bl for later purposes
    sub bl, '0'
    
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
                 
    sub bl, al
    
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

    ;line break
    mov ah, 02h
    mov dl, 0ah
    int 21h
    mov ah, 02h
    mov dl, 0dh
    int 21h    
    
    lea dx, again
    mov ah, 09h
    int 21h
    
    ;checking to reset or not
    mov ah, 01h
    int 21h
    mov bl, al
    
    ;line break
    mov ah, 02h
    mov dl, 0ah
    int 21h
    mov ah, 02h
    mov dl, 0dh
    int 21h
        
    cmp bl, '1'
    jz reset    

    
    jmp end
    
    
    
multiplication:
    ;line break
    mov ah, 02h
    mov dl, 0ah
    int 21h
    mov ah, 02h
    mov dl, 0dh
    int 21h    

        
    lea dx, msg
    mov ah, 09h
    int 21h

    ;taking num1
    mov ah, 01h
    int 21h

    mov bl, al
    sub bl, '0';converting to numerical value from ascii
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
    
    mul bl
    
    add al, '0'
    mov bl, al
    
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
    
    mov ah, 02h
    mov dl, bl
    int 21h

    ;line break
    mov ah, 02h
    mov dl, 0ah
    int 21h
    mov ah, 02h
    mov dl, 0dh
    int 21h    
    
    lea dx, again
    mov ah, 09h
    int 21h
    
    ;checking to reset or not
    mov ah, 01h
    int 21h
    mov bl, al
    
    ;line break
    mov ah, 02h
    mov dl, 0ah
    int 21h
    mov ah, 02h
    mov dl, 0dh
    int 21h
        
    cmp bl, '1'
    jz reset    

    
    jmp end            
             

division:
    ;line break
    mov ah, 02h
    mov dl, 0ah
    int 21h
    mov ah, 02h
    mov dl, 0dh
    int 21h    

        
    lea dx, msg
    mov ah, 09h
    int 21h
    xor cx, cx
    ;taking num1
    mov ah, 01h
    int 21h
    
    mov bl, al;num1 = bl
    sub bl, '0';converting to numerical value from ascii
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
    
    xor ax, ax
    
    ;taking num2
    mov ah, 01h
    int 21h
    sub al, '0';converting to numerical
    mov cl, al ; cl = num2
    
     
    xor ax, ax
    ;division
    mov al, bl
    div cl ; quotientin al, remainder in ah
    mov bl, al
    
              
    
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
    
    add bl, '0';converting to ascii
    mov dl, bl
    mov ah, 02h
    int 21h


    ;line break
    mov ah, 02h
    mov dl, 0ah
    int 21h
    mov ah, 02h
    mov dl, 0dh
    int 21h    
    
    lea dx, again
    mov ah, 09h
    int 21h
    
    ;checking to reset or not
    mov ah, 01h
    int 21h
    mov bl, al
    
    ;line break
    mov ah, 02h
    mov dl, 0ah
    int 21h
    mov ah, 02h
    mov dl, 0dh
    int 21h
        
    cmp bl, '1'
    jz reset    

    
    jmp end                 
    
         
     
end:     
    ;ending
    mov ah, 4ch
    int 21h
    
    main ENDP
end main
        
   
