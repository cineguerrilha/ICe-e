# -*- coding: utf-8 -*-
"""
Spyder Editor

This is a temporary script file.
led power:
CV_CAP_PROP_HUE
"""

import cv2
import time

DT = time.time()
cv2.namedWindow("preview")
vc = cv2.VideoCapture(0)

fourcc = cv2.VideoWriter_fourcc(*'XVID')
out = cv2.VideoWriter('/out/output.avi',fourcc, 30.0, (640,480))

if vc.isOpened(): # try to get the first frame
    rval, frame = vc.read()
    frame = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
else:
    rval = False

while rval:
    cv2.imshow("preview", frame)
    ret, frame = vc.read()
    if ret == True:
        out.write(frame)
        currentDT = time.time()-DT
        print (str(currentDT))
        key = cv2.waitKey(20)
        if key == 27: # exit on ESC
            break
vc.release()
out.release()
cv2.destroyWindow("preview")