import pygame
pygame.init() #must initial pygame.

win = pygame.display.set_mode((500, 500)) #initializes a window with two parameter indicating the width and height
pygame.display.set_caption("Clement's Pygame tutorial 1")
#we gonna put a character on the screen to move
#for a character to move, we must specify its location, the velocity at which its gonna move. 

#locating at which the character will be. These are basically (x , y) coordinates
a = 50
b = 50
#measurements of the character
width = 40
height = 60
#velocity at which the character will move
velocity = 8

##MAIN LOOP
#loop to make the program going on and on
run = True
while run:
    pygame.time.delay(100)
    
    #events are whatever the user does on the screen. clicking something or whatever. or mouse movement too.
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            run = False
            
    keys = pygame.key.get_pressed()#returns bool values of states of keys pressed. (useful when keys are pressed continuously/hold)
    #move right add, mov left subtract, mov up subtract, mov down add.
    if keys[pygame.K_a]:
        a -= velocity
    if keys[pygame.K_d]:
        a += velocity
    if keys[pygame.K_w]:
        b -= velocity
    if keys[pygame.K_s]:
        b += velocity
    
    #filling the screen with emptiness.
    win.fill((0, 0, 0))
    
    
    #drawing the character which is a rectangle in this case.
    pygame.draw.rect(win, (255, 0, 0), (a, b, width, height)) #the parameters are, (on which surface the character is gonna be on, color, coordinates of the character & height width alongside.)
    #to make the character show up on the screen, there must be a refresh on the screen
    pygame.display.update()



pygame.quit() 