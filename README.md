# SerialPortFramesSender

## Introduction
Ce projet a été réaliser dans le cadre de tests sur des signaux d'autoroute.Je devais en comprendre le fonctionnement et le système d'envoie et de reception de trame.

## Instalation
Il vous suffit de cloner le répertoire
```
git clone https://github.com/Fullann/SerialPortFramesSender.git
 ```
Puis de double cliquer sur le .sln en ayant fais attention au paravant d'avoir visual studio d'installer sur votre machine.Et le tour est jouer ;)

## Configuration
Toute la configurationdu port série est dans SerialPortFramesSender/TestSerialCom/SerialSender.cs.
```
PortName = port,        // Port pour la communication
BaudRate = 9600,        // Set Baud rate = 9600
DataBits = 8,           // Number of data bits = 8
Parity = Parity.Even,   // No parity
StopBits = StopBits.One,// One stop bit
ReadTimeout = 500,       // Time for read 
WriteTimeout = 500       //Time to write 
```
Ces constantes ont étées utiliser car c'était les indications que le fournisseur nous avais communiquer

