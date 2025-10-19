.model small
.stack 100
.code

main proc
    
    ; int 21h, with AH , 1   is used to read inputs
    mov ah  , 1
    int 21h ; reads input from user, stores it into AH
    mov bl, al
    
    mov ah, 1
    int 21h
    mov bh, al
    
    
    
    ; ah, 2 with dl, with int 21h      is used to print or display an output from 'dl'
    mov ah, 2
    mov dl, bl
    int 21h
    
    mov ah, 2
    mov dl, bh
    int 21h                                          
    
    
   
   
   ; ah, 4ch with int 21h      is used to terminate the program 
    exit:
    mov ah, 4ch
       int 21h
       main endp    
end main                                                       





; main endp end main are used to end the program