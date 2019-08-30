from picamera.array import PiRGBArray
from picamera import PiCamera
import time
import cv2
import RPi.GPIO as GPIO

GPIO.setmode(GPIO.BCM)
GPIO.setup(23, GPIO.IN, pull_up_down = GPIO.PUD_UP)
GPIO.setup(24, GPIO.IN, pull_up_down = GPIO.PUD_DOWN)

# initialize the camera and grab a reference to the raw camera capture
W = 640 # image height
H = 480 # image width

fps=30
camera = PiCamera()
camera.resolution = (W,H)
camera.framerate = fps
camera.brightness = 60
camera.exposure_mode='fixedfps'
camera.color_effects = (128,128)

rawCapture = PiRGBArray(camera, size=(W, H))
stream = camera.capture_continuous(rawCapture,
            format="bgr", use_video_port=True)
frame = None
# allow the camera to warmup
time.sleep(0.2)

fourcc=cv2.VideoWriter.fourcc('G','R','E','Y')
out = cv2.VideoWriter(('Behav_'+FNameBase+'.avi'), fourcc, fps, (W,H), False)

MaxFrames = 100
cnt = 0
print("Camera opened")
# capture frames from the camera
DT = time.time()
RealFrameRate = 0
print("Wait for pulse")

FNameBase = time.strftime("%H_%M_%S")
TimeStampFile = open(("Behav_"+FNameBase+".dat"),"w") 
TimeStampFile.write("Frame;TimeStamp;Detect\n")

while True:
    #print (GPIO.input(24))
    if(GPIO.input(24)==0):
        break

for frame in camera.capture_continuous(rawCapture, format="bgr", use_video_port=True):

    image = frame.array
    image = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY)
    out.write(image)

    # show the frame
    # cv2.imshow("Frame", image)
    # key = cv2.waitKey(1) & 0xFF
    # key = cv2.waitKey(5)

    # clear the stream in preparation for the next frame
    rawCapture.truncate(0)
            
    currentDT = time.time()-DT

    #print (str(1/(currentDT-RealFrameRate)))
    #print (currentDT)
    print (GPIO.input(24))
    RealFrameRate = currentDT
    TimeStampFile.write(str(cnt)+';'+str(time.time())"\n")
    cnt = cnt+1

    if cnt > MaxFrames: 
        break

out.release()
cv2.destroyAllWindows()
stream.close()
rawCapture.close()
camera.close
TimeStampFile.close()

# Here I will compress the video
#print("Converting")
#cap = cv2.VideoCapture('output.avi')
#FName="Behav_"+str(time.strftime("%H:%M", time.localtime(time.time())))+".avi"
#out = cv2.VideoWriter(FName,cv2.VideoWriter_fourcc('M','J','P','G'), fps, (W,H))
#
#if (cap.isOpened()== False):
#  print("Error opening video file")
#
#
#cnt=0
#while(cap.isOpened()):
#  # Capture frame-by-frame
#    ret, frame = cap.read()
#    if ret == True:
#        out.write(frame)
#    else:
#        break
#    cnt=cnt+1
#    print (cnt)
#
## When everything done, release the video capture object
#cap.release()
#out.release()
#