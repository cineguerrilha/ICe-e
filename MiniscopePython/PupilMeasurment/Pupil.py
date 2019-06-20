# -*- coding: utf-8 -*-
"""
Created on Sat Jun  8 01:35:41 2019

@author: richardson
"""
import cv2
import numpy as np
import time

cap = cv2.VideoCapture('test_vid.h264')

#th = cv2.adaptiveThreshold(grayscaled, 255, cv2.ADAPTIVE_THRESH_GAUSSIAN_C, cv2.THRESH_BINARY, 115, 1)

if (cap.isOpened()== False): 
  print("Error opening video stream or file")
 
frame_number = 1
# Read until video is completed
while(True):
  # Capture frame-by-frame
  cap.set(cv2.CAP_PROP_POS_FRAMES, frame_number)
  ret, frame = cap.read()
  if ret == True:
    frame = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)  
    #retval, th = cv2.threshold(~frame-255, 210, 255, cv2.THRESH_BINARY)
    # Display the resulting frame
    cv2.imshow('Frame',frame)
    time.sleep(0.1)
 
    # Press Q on keyboard to  exit
    if cv2.waitKey(25) & 0xFF == ord('q'):
      break
 
  # Break the loop
  else: 
    break
 
# When everything done, release the video capture object
cap.release()
fromCenter = False
r = cv2.selectROI('Frame',frame, fromCenter)
imCrop = frame[int(r[1]):int(r[1]+r[3]), int(r[0]):int(r[0]+r[2])]
# Closes all the frames
# cv2.destroyAllWindows()