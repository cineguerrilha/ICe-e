# -*- coding: utf-8 -*-
"""
Created on Tue May 28 22:03:48 2019

@author: richardson
"""
import cv2
import time
import numpy
from matplotlib import pyplot as plt

cv2.namedWindow("preview")

# Chhose the camera
vc = cv2.VideoCapture(1)
LogImages = False
DetectionThreshold = 200
MinMouseSize = 1000
DetectFlag=0

OutDir="c:\out"

if vc.isOpened(): # try to get the first frame
    rval, frame = vc.read()
    frame = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
    hist = cv2.calcHist([frame],[0],None,[256],[0,256])
    print("Camera open")
    TimeStampFile = open("TimeStamp.dat","w") 
    TimeStampFile.write("Frame;TimeStamp;Detect\n")
else:
    rval = False
    
ret = False

W = int(vc.get(3))
H = int(vc.get(4))
fourcc=cv2.VideoWriter.fourcc('X','V','I','D') 
out = cv2.VideoWriter('c:\out\output.avi', fourcc, 20, (W,H), False)
DT = time.time()
FrameCount = 1

ret, frame = vc.read()
frame = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
#    ret=vc.grab();
NoROI=1

r = cv2.selectROI('Select Region',frame)
cv2.destroyWindow('Select Region')
imCrop = frame[int(r[1]):int(r[1]+r[3]), int(r[0]):int(r[0]+r[2])]

hist = cv2.calcHist([cv2.bitwise_not(imCrop)],[0],None,[256],[0,256])
plt.hist(imCrop.ravel(),256,[0,256])
plt.title('Histogram for region of interest')
plt.show()
RectColot = (0,0,0)

while rval:
    
    ret, frame = vc.read()
#    ret=vc.grab();
    frame = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
    frameRect=frame
    imCropOnline = cv2.bitwise_not(frame[int(r[1]):int(r[1]+r[3]), int(r[0]):int(r[0]+r[2])])
#    subImage=cv2.subtract(imCropOnline,imCrop)
    
    ret2, bw = cv2.threshold(imCropOnline, DetectionThreshold, 255, cv2.THRESH_BINARY)
    cv2.imshow("Threshold Area",bw)    
    connectivity = 8
    nb_components, output, stats, centroids = cv2.connectedComponentsWithStats(bw, connectivity, cv2.CV_32S)
    sizes = stats[1:, -1]; nb_components = nb_components - 1
    if sizes.size:
        MaxConnected=numpy.amax(sizes)
    # Here you do something when something is detected
        if MaxConnected>MinMouseSize:
            #print("Object detected")
            RectColot = (255,255,255)
            DetectFlag=1
        else:
            RectColot = (0,0,0)
            DetectFlag=0
    else:
        RectColot = (0,0,0)
        DetectFlag=0
        
    cv2.rectangle(frameRect,(r[0],r[1]),(r[0]+r[2],r[1]+r[3]),RectColot,1)
    cv2.imshow("preview", frameRect)
    
    if ret == True:
        if LogImages == True:
 #           frame = vc.retrieve()
            out.write(frame)
        currentDT = time.time()-DT
        TimeStampFile.write(str(FrameCount)+';'+str(currentDT)+';'+str(DetectFlag)+"\n")
        FrameCount=FrameCount+1
        
        key = cv2.waitKey(1)
        if key == 27: # exit on ESC
            break
        if key == 'h':
            hist = cv2.calcHist([frame],[0],None,[256],[0,256])

vc.release()
out.release()
TimeStampFile.close()
cv2.destroyAllWindows()