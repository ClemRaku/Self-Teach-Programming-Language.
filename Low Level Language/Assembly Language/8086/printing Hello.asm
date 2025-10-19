.model small
.stack 100h
.data

msg db 'hello$'     ;declare a variable, msg,  with the value 'hello'

.code    ;code start
main proc
    mov ax, @data
    mov ds, ax
    
    lea dx, msg
    mov ah, 09h
    int 21h
    
    
    mov ah, 4ch
    int 21h
    
    main endp
end main
    