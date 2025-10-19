import pygame
pygame.init() #must initial pygame.
window_width, window_height = 500, 480
win = pygame.display.set_mode((window_width, window_height)) #initializes a window with two parameter indicating the width and height
pygame.display.set_caption("Clement's Pygame tutorial 1")
#we gonna put a character on the screen to move

#Loading the images
walkRight = [pygame.image.load('Sprites/Tutorial/R1.png'), pygame.image.load('Sprites/Tutorial/R2.png'), pygame.image.load('Sprites/Tutorial/R3.png'), pygame.image.load('Sprites/Tutorial/R4.png'), pygame.image.load('Sprites/Tutorial/R5.png'), pygame.image.load('Sprites/Tutorial/R6.png'), pygame.image.load('Sprites/Tutorial/R7.png'), pygame.image.load('Sprites/Tutorial/R8.png'), pygame.image.load('Sprites/Tutorial/R9.png')]
walkLeft = [pygame.image.load('Sprites/Tutorial/L1.png'), pygame.image.load('Sprites/Tutorial/L2.png'), pygame.image.load('Sprites/Tutorial/L3.png'), pygame.image.load('Sprites/Tutorial/L4.png'), pygame.image.load('Sprites/Tutorial/L5.png'), pygame.image.load('Sprites/Tutorial/L6.png'), pygame.image.load('Sprites/Tutorial/L7.png'), pygame.image.load('Sprites/Tutorial/L8.png'), pygame.image.load('Sprites/Tutorial/L9.png')]
bg = pygame.image.load('Sprites/Tutorial/bg.jpg')
char = pygame.image.load('Sprites/Tutorial/standing.png')

#clock
clock = pygame.time.Clock()

class player(object):
    def __init__(self, a, b, width, height):
        self.a = a
        self.b = b
        self.width = width
        self.height = height
        self.velocity = 5
        self.isJump = False
        self.jumpCount = 10
        self.left = False
        self.right = False
        self.walkCount = 0
        self.standing = True
        
    def draw(self, win):
        # filling the screen with a background.        
        # drawing the character which is an asset in this case.
        if self.walkCount + 1 >= 27:  # there's 9 sprites. 9 sprites gonna be present on screen for 3 frames.
            self.walkCount = 0

        if not self.standing:
            if self.left:
                win.blit(walkLeft[self.walkCount // 3], (self.a, self.b))
                self.walkCount += 1
            elif self.right:
                win.blit(walkRight[self.walkCount // 3], (self.a, self.b))
                self.walkCount += 1
        else:
            if self.right:
                win.blit(walkRight[0], (self.a, self.b))
            else:
                win.blit(walkLeft[0], (self.a, self.b))

class projectile(object):
    def __init__(self, a, b, radius, color, facing):
        self.a = a
        self.b = b
        self.radius = radius
        self.color = color
        self.facing = facing
        self.velocity = 8 * facing
        
    def draw(self, win):
        pygame.draw.circle(win, self.color, (self.a, self.b), self.radius)

#drawing function
def redrawGameWindow():
    #global variable is basically changing the Global Variable, instead of making a local variable in this function.

    
    #filling the screen with a background.
    win.blit(bg, (0,0))
    Raka.draw(win)
    
    for bullet in bullets:
        bullet.draw(win)
    #to make the character show up on the screen, there must be a refresh on the screen
    pygame.display.update()
    


Raka = player(300, 410, 64, 64)
##MAIN LOOP
#loop to make the program going on and on
run = True
bullets = []
while run:
    clock.tick(27)
        
    #events are whatever the user does on the screen. clicking something or whatever. or mouse movement too.
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            run = False
    
    for bullet in bullets:
        if bullet.a < 500 and bullet.a > 0:
            bullet.a += bullet.velocity
        else:
            bullets.remove(bullet)
    
    keys = pygame.key.get_pressed()#returns bool values of states of keys pressed. (useful when keys are pressed continuously/hold)
    
    if keys[pygame.K_SPACE]:
        if Raka.left:
            facing = -1
        else:
            facing = 1
        
        if len(bullets) < 5:
            bullets.append(projectile(round(Raka.a + Raka.width //2), round(Raka.b + Raka.height//2), 6,(255,0,0), facing))
    
    #move right add, mov left subtract, mov up subtract, mov down add.
    if keys[pygame.K_a] and Raka.a > Raka.velocity:#moving left
        Raka.a -= Raka.velocity
        Raka.left, Raka.right = True, False
        Raka.standing = False
    elif keys[pygame.K_d] and Raka.a < (window_width - Raka.width - Raka.velocity):#moving right
        Raka.a += Raka.velocity
        Raka.left, Raka.right = False, True
        Raka.standing = False
    else:
        Raka.standing = True
        Raka.walkCount = 0
    if not Raka.isJump:
        if keys[pygame.K_w]:
            Raka.isJump = True
            Raka.right, Raka.left = False, False
            Raka.walkCount = 0
    else:
        if Raka.jumpCount >= -10:
            neg = 1
            if Raka.jumpCount < 0:
                neg = -1
            Raka.b -= (Raka.jumpCount ** 2) * 0.5 * neg
            Raka.jumpCount -= 1
        else:
            Raka.isJump = False
            Raka.jumpCount = 10
    
    
    redrawGameWindow()
    



pygame.quit() 


