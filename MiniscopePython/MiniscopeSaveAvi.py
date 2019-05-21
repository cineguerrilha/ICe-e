# -*- coding: utf-8 -*-
"""
Created on Mon May 20 23:17:54 2019

@author: richardson

Miniscope recording program
Record 1000 frames and name the files msXXX.avi 
Create a timestamp.dat file

For reference:

RecordStart = 0x01
RecordEnd = 0x02

FPS5 = 0x11
FPS10 = 0x12
FPS15 = 0x13
FPS20 = 0x14
FPS30 = 0x15
FPS60 = 0x16

Things to add about the camera:
msCam.set(CV_CAP_PROP_SATURATION, SET_CMOS_SETTINGS);
msCam.set(CV_CAP_PROP_SATURATION,RECORD_START);

Things to add about the Frame:
cv::cvtColor(self->msFrame[self->msWritePos%BUFFERLENGTH],frame,CV_BGR2GRAY);//added to correct green color stream
cv::minMaxLoc(frame,&self->mMinFluor,&self->mMaxFluor);
"""
import cv2
import time

aviNo = 2   #number of AVI files (each file has 1000 frames - about 30s)

DT = time.time()
cv2.namedWindow("Miniscope Recording")
vc = cv2.VideoCapture(0)
vc.set(15, 255) #relative exposure
vc.set(14, 64) # sensor gain
vc.set(13,0) #led brightness
vc.set(5,0x15) #frame rate
