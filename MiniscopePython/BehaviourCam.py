# -*- coding: utf-8 -*-
"""
Created on Tue May 28 22:03:48 2019

@author: richardson
"""


import cv2
import time

cv2.namedWindow("preview")
vc = cv2.VideoCapture(0)
LogImages = False

OutDir="c:\out"

if vc.isOpened(): # try to get the first frame
    rval, frame = vc.read()
    frame = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
    hist = cv2.calcHist([frame],[0],None,[256],[0,256])
    print("Camera open")
    TimeStampFile = open("TimeStamp.dat","w") 
    TimeStampFile.write("Frame;TimeStamp\n")
else:
    rval = False
    
ret = False

W = int(vc.get(3))
H = int(vc.get(4))
fourcc=cv2.VideoWriter.fourcc('X','V','I','D') 
out = cv2.VideoWriter('c:\out\output.avi', fourcc, 20, (W,H), False)
DT = time.time()
FrameCount = 1
while rval:
    
    ret, frame = vc.read()
#    ret=vc.grab();
    
    cv2.imshow("preview", frame)
    if ret == True:
        if LogImages == True:
 #           frame = vc.retrieve()
            frame = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
            out.write(frame)
        currentDT = time.time()-DT
        TimeStampFile.write(str(FrameCount)+';'+str(currentDT)+"\n")
        
        key = cv2.waitKey(1)
        if key == 27: # exit on ESC
            break
        if key == 'h':
            hist = cv2.calcHist([frame],[0],None,[256],[0,256])

vc.release()
out.release()
TimeStampFile.close()
cv2.destroyAllWindows()