# -*- coding: utf-8 -*-
"""
Spyder Editor

This is a temporary script file.
led power:
CV_CAP_PROP_HUE
"""

import cv2
import time

LogImages = True   #Log images to c:\out\output.avi

RecordStart = 0x01
RecordEnd = 0x02
# set saturation (property 12)
DT = time.time()
cv2.namedWindow("preview")

vc = cv2.VideoCapture(1)
    
vc.set(12,0x03) #saturation: start the CMOS sensor
vc.set(15, 255) #relative exposure
vc.set(14, 64) # sensor gain
vc.set(13,50) #led brightness
vc.set(5,0x15) #frame rate

if vc.isOpened(): # try to get the first frame
    rval, frame = vc.read()
    frame = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
    print("miniscope open")
    
else:
    rval = False
    
ret = False

W = int(vc.get(3))
H = int(vc.get(4))

#fourcc = cv2.VideoWriter.fourcc('D', 'I', 'B', ' ')
#fourcc=cv2.VideoWriter_fourcc(*'DVIX')
fourcc=cv2.VideoWriter.fourcc('X','V','I','D') 
out = cv2.VideoWriter('c:\out\output.avi', fourcc, 20, (W,H), False)

#capture.QueryFrame();

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
        print (str(currentDT))
        key = cv2.waitKey(20)
        if key == 27: # exit on ESC
            break

#vc.set(12,0x02) #saturation: start the CMOS sensor    
vc.set(13,0) #led brightness    
vc.release()
out.release()
cv2.destroyAllWindows()