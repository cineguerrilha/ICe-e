#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <unistd.h>
#include "ftd2xx.h"

#define BUF_SIZE 96

#define MAX_DEVICES 2

int main()
{
	unsigned char 	cBufWrite[BUF_SIZE];
	unsigned char * pcBufRead = NULL;
	char * 	pcBufLD[MAX_DEVICES + 1];
	char 	cBufLD[MAX_DEVICES][64];
	DWORD	dwRxSize = 0;
	DWORD 	dwBytesWritten, dwBytesRead;
	FT_STATUS	ftStatus;
	FT_HANDLE	ftHandle[MAX_DEVICES];
	int	iNumDevs = 0;
	int	i, j, k;
	int	iDevicesOpen;		
			
	i=0;
	iDevicesOpen=i;
	
	for(i = 0; i < MAX_DEVICES; i++) {
		pcBufLD[i] = cBufLD[i];
	}
	
	i=0;
	pcBufLD[MAX_DEVICES] = NULL;
	
	ftStatus = FT_ListDevices(pcBufLD, &iNumDevs, FT_LIST_ALL | FT_OPEN_BY_SERIAL_NUMBER);
	
	if(ftStatus != FT_OK) {
		printf("Error: FT_ListDevices(%d)\n", (int)ftStatus);
		return 1;
	}

		printf("Device %d Serial Number - %s\n", i, cBufLD[i]);

		
		if((ftStatus = FT_OpenEx(cBufLD[i], FT_OPEN_BY_SERIAL_NUMBER, &ftHandle[i])) != FT_OK){
			/* 
				This can fail if the ftdi_sio driver is loaded
		 		use lsmod to check this and rmmod ftdi_sio to remove
				also rmmod usbserial
		 	*/
			printf("Error FT_OpenEx(%d), device %d\n", (int)ftStatus, i);
			printf("Use lsmod to check if ftdi_sio (and usbserial) are present.\n");
			printf("If so, unload them using rmmod, as they conflict with ftd2xx.\n");
			return 1;
		}
	
		printf("Opened device %s\n", cBufLD[i]);

		iDevicesOpen++;
		
		if((ftStatus = FT_SetBaudRate(ftHandle[i], 115200)) != FT_OK) {
			printf("Error FT_SetBaudRate(%d), cBufLD[i] = %s\n", (int)ftStatus, cBufLD[i]);
		}

		//Start getting data from the amps = 83
		k=83;
		ftStatus = FT_Write(ftHandle[i], &k, 1, &dwBytesWritten);
		if (ftStatus != FT_OK) {
			printf("Error FT_Write(%d)\n", (int)ftStatus);
		}
		//Stop getting data from the amps = 115
		
		dwRxSize = 0;			
		while ((dwRxSize < BUF_SIZE) && (ftStatus == FT_OK)) {
			ftStatus = FT_GetQueueStatus(ftHandle[i], &dwRxSize);
		}
		if(ftStatus == FT_OK) {
			pcBufRead = realloc(pcBufRead, dwRxSize);
			memset(pcBufRead, 0xFF, dwRxSize);
			printf("Calling FT_Read with this read-buffer:\n");
			
			ftStatus = FT_Read(ftHandle[i], pcBufRead, dwRxSize, &dwBytesRead);
			if (ftStatus != FT_OK) {
				printf("Error FT_Read(%d)\n", (int)ftStatus);
			}
			if (dwBytesRead != dwRxSize) {
				printf("FT_Read only read %d (of %d) bytes\n",
				       (int)dwBytesRead,
				       (int)dwRxSize);
			}
			printf("FT_Read read %d bytes.  Read-buffer is now:\n",
			       (int)dwBytesRead);
			
			printf("%s test passed.\n", cBufLD[i]);
		}
		else {
			printf("Error FT_GetQueueStatus(%d)\n", (int)ftStatus);	
		}
	
		int TTLval, channelVal, index;

		int ch=-1;
		float v;
		
		FILE *file;
	file = fopen("file.txt","w");

	/*
    for (index = 0; index < (int)dwBytesRead; index += 3) { 
           
          ++ch;
           printf("%d \n",ch);
       v = ((pcBufRead[index] & 127) + 
                     ((pcBufRead[index+1] & 127) << 7) + 
                     ((pcBufRead[index+2] & 3) << 14)) * 0.1907f - 6175.0f;
		     
	fprintf(file,"%f \n",v);
	
        // these samples should now be in microvolts!

         // bit volt calculation:
         // 2.5 V range / 2^16 = 38.14 uV
         // 38.14 uV / 200x gain = 0.1907
         // also need to account for 1.235 V offset (where does this come from?)
         //    1.235 / 200 * 1e6 = 6175 uV 

         // before accounting for bit volts:
         // thisSample[ch%16+n*16] = float((buffer[index] & 127) + 
         //             ((buffer[index+1] & 127) << 7) + 
         //             ((buffer[index+2] & 3) << 14) - 32768)/32768;

         //}

         if (ch > 0 && ch < 7) // event channels
        {
            TTLval = (pcBufRead[index+2] & 4) >> 2; // extract TTL value (bit 3)
        }

         channelVal = pcBufRead[index+2] & 60;   // extract channel value

         if (channelVal == 60) {
            // reset values
         	ch = -1;
         }

    }*/
    
	
	for(j=0;j<(int)dwBytesRead;j++) fprintf(file,"%d \n",pcBufRead[j]);
	fclose(file);
	//ftdi_usb_close(&ftHandle[i]);
        //ftdi_deinit(&ftHandle[i]);
        FT_Close(ftHandle[i]);
		return 0;
		
}