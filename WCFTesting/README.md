# WCF Code Exmaples:

## ADO data access

## Data Contracts and Data Members
- Serialization is the process of converting an object into XML
- Deserialization is the reconstructing the object from XML
- By default WCF uses DataContractSerializer
- Complex types can be decorated with SerializableAttribute or DataContractAttribute

## KnownTypes
- KnownType attribute on base type (global, all service contracts and all operation contracts will respect known types)
- ServiceKnownType attribute on service contract (respected by all operation contracts within the service contract only)
- ServiceKnownType attribute on operation contracts (only the decorated operation contracts respect the known types)
- Specify KnownTypes in the configuration file (global, equivalent to applying KnowType attribute on base class)

## Tracing and Logging
- xxx.config => Edit WCF Configuration => Diagnostics (MessageLogging, Tracing)
- LogEntireMessage = true

## Message Contracts
- Include custom data in SOAP header (user credentials, license keys, session keys etc.)
- Change name of the wrapper elements in the SOAP message or remove it 

## Data Contracts vs Message Contracts
- DataContract gives limited control
- MessageContract gives full control

## Protection Level
- ProtectionLevel = System.Net.Security.ProtectionLevel.None
- ProtectionLevel = System.Net.Security.ProtectionLevel.Sign
- ProtectionLevel = System.Net.Security.ProtectionLevel.EncryptAndSign

## Backwards Compatible Changes
- WSDL docs should not be changes after deployment to prod (clients have generated proxy calsses)
- WCF contracts are version tolerent by default (DataContractSerializer allows missing, non-required data and ignores superfluous data for contracts)
https://msdn.microsoft.com/en-us/library/ff384251.aspx?f=255&MSPPError=-2147217396

## ExtensionDataObject
- preserving unknown data
- public ExtensionDataObject ExtensionData { get; set; }

#### Risks of implementing IExtensibleDataObject interface
- Denial of service attack (data is stored in memory - could send large amounts of unknown data)
- Can remove the implamentation of IExtensibleDataObject interface from all DataContracts
- Can be enabled/disabled using service behaviour configuration (<dataContractSerializer ignoreExtensionDataObject="true"/>)
- Can also be done proggramatically using ServiceBehaviourAttribute.SetIgnoreExtensionDataObject property to true
- When IExtensibleDataObject feature is turned off the deserializer will not populate the ExtensionData property

## Exception Handling

