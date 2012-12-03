TOPDIR  := $(shell cd ..; pwd)
include Rules.make

APP = IntanGetDataTest

all: $(APP)

$(APP): IntanGetDataTest.c	
	$(CC) IntanGetDataTest.c -o $(APP) $(CFLAGS)
	
clean:
	rm -f *.o ; rm $(APP)
