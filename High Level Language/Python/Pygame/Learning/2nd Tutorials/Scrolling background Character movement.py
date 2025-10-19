import random
import pygame
from pygame.locals import *
import os
import sys
import math

pygame.init()

W, H = 800, 447
win = pygame.display.set_mode((W,H))
pygame.display.set_caption("Raka's practice number 2")
bg = pygame.image.load("Side-Scroller-Game-master/images/bg.png")
bgX = 0 
bgX2 = bg.get_width() #width of the background.

clock = pygame.time.Clock()

class player(object):
    run = [pygame.image.load("Side-Scroller-Game-master/images/" + str(x) + ".png") for x in range(8, 16)]
#the above pythonic code can be written as 
#   run = []
#    for x in range(8, 16):
#        run.append(pygame.image.load("Side-Scroller-Game-master/images/" + str(x) + ".png"))
    jump = [pygame.image.load("Side-Scroller-Game-master/images/" + str(x) + ".png") for x in range(1, 8)]
    slide = [pygame.image.load("Side-Scroller-Game-master/images/S1.png"),        
        pygame.image.load("Side-Scroller-Game-master/images/S2.png"),
        pygame.image.load("Side-Scroller-Game-master/images/S2.png"),
        pygame.image.load("Side-Scroller-Game-master/images/S2.png"),
        pygame.image.load("Side-Scroller-Game-master/images/S2.png"),
        pygame.image.load("Side-Scroller-Game-master/images/S2.png"),
        pygame.image.load("Side-Scroller-Game-master/images/S2.png"),
        pygame.image.load("Side-Scroller-Game-master/images/S2.png"),        
        pygame.image.load("Side-Scroller-Game-master/images/S3.png"),
        pygame.image.load("Side-Scroller-Game-master/images/S4.png"),
        pygame.image.load("Side-Scroller-Game-master/images/S5.png")
        ]
    jumpList = [1,1,1,1,1,1,2,2,2,2,2,2,2,2,2,2,2,2,3,3,3,3,3,3,3,3,3,3,3,3,4,4,4,4,4,4,4,4,4,4,4,4,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,-1,-1,-1,-1,-1,-1,-2,-2,-2,-2,-2,-2,-2,-2,-2,-2,-2,-2,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-3,-4,-4,-4,-4,-4,-4,-4,-4,-4,-4,-4,-4]
    fall = [pygame.image.load("Side-Scroller-Game-master/images/0.png")]
    def __init__(self, x, y, width, height):
        self.x = x
        self.y = y
        self.width = width
        self.height = height
        self.jumping = False
        self.sliding = False
        self.slideCount = 0
        self.jumpCount = 0
        self.runCount = 0
        self.base_y = self.y
        
    def draw (self, win):
        if self.jumping:
            self.y -= self.jumpList[self.jumpCount] * 1.2
            win.blit(self.jump[self.jumpCount//18], (self.x, self.y))
            self.jumpCount += 1
            if self.jumpCount > 108:
                self.jumpCount = 0
                self.jumping = False
                self.runCount = 0
        elif self.sliding:
            if self.slideCount<20:
                self.y += 1
            elif self.slideCount == 70:
                self.y += 1
            if self.slideCount >= 100:
                self.slideCount = 0
                self.sliding = False
                self.runCount = 0
                self.y = self.base_y
            win.blit(self.slide[self.slideCount//10], (self.x , self.y))
            self.slideCount += 1
        else:
            if self.runCount > 42:
                self.runCount = 0
            win.blit(self.run[self.runCount//6], (self.x, self.y))
            self.runCount += 1

def redrawWindow():
    win.blit(bg, (bgX, 0)) #paramters = surface on which the image onna be, coordinates of where the image gonna be.
    win.blit(bg, (bgX2, 0))
    runner.draw(win)
    for object in objects:
        object.draw(win)
    pygame.display.update()
    
class saw (object):
    img = [pygame.image.load("Side-Scroller-Game-master/images/SAW0.png") ,pygame.image.load("Side-Scroller-Game-master/images/SAW1.png"), pygame.image.load("Side-Scroller-Game-master/images/SAW2.png"), pygame.image.load("Side-Scroller-Game-master/images/SAW3.png")]
    def __init__(self, x, y, width, height):
        self.x = x
        self.y = y
        self.width = width
        self.height = height
        self.hitbox = (x, y, width, height)
        self.count = 0
        
    def draw (self, win):
        self.hitbox = (self.x + 5, self.y + 5, self.width - 10, self.height)
        if self.count >= 8:
            self.count = 0
        win.blit(pygame.transform.scale(self.img[self.count//2], (64, 64)), (self.x, self.y))
        self.count += 1
        pygame.draw.rect(win, (255, 0, 0), self.hitbox, 2)
            
class spike(saw):
    img = pygame.image.load("Side-Scroller-Game-master/images/spike.png")
    def draw(self, win):
        self.hitbox = (self.x + 10, self.y, 28, 315)
        win.blit(self.img, (self.x, self.y))
        pygame.draw.rect(win, (255, 0, 0), self.hitbox, 2)
        
runner = player(200, 313, 64,64)
pygame.time.set_timer(USEREVENT + 1, 500) #this event will trigget every 500 milisecond.
pygame.time.set_timer(USEREVENT + 2, random.randrange(3000, 5000))
BGspeed = 30
run = True  
objects = [] 
while run:
    redrawWindow()
    
    for objectt in objects:
        objectt.x -= 1.4
        if objectt.x < objectt.width * - 1:
            objects.remove(objectt)
    bgX -= 1.4
    bgX2 -= 1.4
    if bgX < bg.get_width() * - 1:
        bgX = bg.get_width()
    if bgX2 < bg.get_width() * - 1:
        bgX2 = bg.get_width()
    


    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            run = False
            pygame.quit()
            quit()  
        if event.type == USEREVENT + 1:
            BGspeed += 1
        if event.type == USEREVENT + 2:
            r = random.randrange(0, 2)
            if r == 0:
                objects.append(saw(810, 310, 64, 64))
            else:
                objects.append(spike(810, 0, 48, 320))
            
    keys = pygame.key.get_pressed()
    #ensures only jump or slides once, per click. 
    if keys[pygame.K_SPACE] or keys[pygame.K_UP]:
        if not runner.jumping:
            runner.jumping = True
    if keys[pygame.K_DOWN]:
        if not(runner.sliding):
            runner.sliding = True
    
    clock.tick(BGspeed)