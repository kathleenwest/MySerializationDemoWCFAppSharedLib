# MySerializationDemoWCFAppSharedLib

WCF “Adopt a Dog” Service Application & Shared Library with Custom Serialization & Client "Tester" Windows Form Application


Project Article here: https://portfolio.katiegirl.net/2019/09/28/wcf-adopt-a-dog-service-application-shared-library-with-custom-serialization-client-tester-windows-form-application/


About


This project presents a simple, but fun “Adopt a Dog” Service Application. The service provides a factory creational design pattern to create and return a single Dog object (complete with a cute photo). It is hosted using IIS Express to quickly demo and test the service with a client.
The service interface is defined not in the service application but in a Shared Library. The Shared Library also defines the Dog class object with custom serialization using the ISerializable interface implemented on the Dog class. This project is intended to demo custom serialization and a shared library concept between both the service and the client. With the Shared Library concept of both the service interface definition and the Dog class, there is no need to use SVCUTIL or the Service Wizard to create a tightly coupled service reference. Instead, the client uses a simple ChannelFactory concept to build a channel to the service knowing the interface details in the Shared Library. Also, it can understand and work with the Dog objects as specified in the Shared Library. 

A client “tester” windows form application tests the service and provides output to the user in a simple GUI.  
In addition, a short discussion and code demo of debugging service errors and activity using diagnostics and a trace listener pattern is included in this article. Some of my lessons learned in debugging service errors and custom serialization may help you on your next project. 


Architecture


The demo project consists of these component topics:

•	Adopt A Dog WCF Service Application Project “WcfServiceApplication”
o	AdoptADogService (Code that Implements the Service Interface)
o	Web.config (Configuration for Trace Diagnostics on Service)
o	Reference to the Shared Class Library


•	Shared Class Library Project “SharedLibrary”
o	IAdoptADogService (Interface for Service)
o	Dog class (defines a Dog object and Custom Serialization)
o	Photos of the Dogs 
o	Logs for Trace Diagnostics 


•	Client “Tester to Service” Windows Form Application Project “AdoptADogClient”
o	Reference to the Shared Class Library
o	Main Form GUI User Interface
o	Form Code – Processes GUI User Interface

 
