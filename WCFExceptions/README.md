# WCF serializes exceptions to SOAP faults before reporting to client

# SOAP faults are in XML format and platform independant
#### A typical SOAP fault contains:
- FaultCode
- Fault Reason
- Detail element etc.
## ----------------------------------------------------
- The Detail element can be used to include any custom xml
- SOAP faults are formatted based n SOAP 1.1 or SOAP 1.2 specifications, depends on the binding
- BasicHttpBinding uses SOAP 1.1
- Built in WCF bindings use SOAP 1.2 (wsHttpBinding, security mode="None") - for xml messages

## Unhandled Exceptions
- Will cause the communication channel to fault and the session will be lost
- Once in a faulted state we cannot use the same instance of the proxy class anymore
- BasicHttpBinding does not have sessions, it only faults the server channel. The client proxy is still ok
- wsHttpBindings have secure sessions, it faults the server channel and the existing client proxy is useless> once faulted the channel is torn down and the session with it.

## Throwing Fault Exceptions From WCF Service
- A WCF service should be throwing a FaultException or FaultException<T> instead of .Net exceptions
- An unhandled .net exception will cause the channel between the clienty and server to fault
- As .net exceptions are platform specific, they can only be understood by a vlient that is also .net
- FaultException<T> allows strongly typed SOAP faults

## Strongly Typed SOAP Faults
- Create a class that represents the SOAP fault.
- Decorate the class with DataContract attribute and the properties with DataMember attribute

## Centralized Exception Handling
- In ASP.NET web apps we can use Application_Error() event handler method in Gloabla,asax to log all exceptions and redirect user to custom error page
- In WCF, to centralize exception handling and return a general fault reason we implement IErrorHandler interface

1. Implement IErrorhandler interface (class)
- ProvideFault() - Gets called automatically on unhandled exception or fault. Here we can write code to convert to generic fault to return to client
- HandleError() - Gets called asynchronously after ProvideFault() is called and message returned to client. (Log exceptions here without blocking client call)

2. Creaste a custom Service Behavior Attribute (class)
- to let WCF know we want to use the GlobalErrorHandler class whenever an unhandled exception occurs

3. Decorate Service class in service.cs
- With GlobalErrorHandlerBehaviourAttribute
