# easj-sem3
Preparation for 3rd semester exam. EASJ, Computer Science. 

### What is?!
Throughout our 3rd semester at EASJ, CS, we've been studying web-services (like SOAP and REST) and socket communication (like TCP and UDP). For my programming exam, knowing that we will be handled one of these subjects, I've taken the liberty to prepare a few very basic, simple and scraped setups to quickly get me started at the exam itself. 

#### Included
These are some of the tools I expect to further build upon at my programming exam. These tools will probably not cover all subjects, but they are the beginning of projects for several of the subjects that we've studied throughout the semester so I am certain that at least one of these tools will come in handy on the exam day. 

##### PHP
We've mainly been using PHP to build simple web-applications (websites) to communicate with our web-services via Curl. The included PHP folder includes a ready to use web-application for the browser, using the MVC design pattern and including a Curl model to quickly build a view and communicate with our web-service (if any). The setup also includes the Twig package, which is also something we've been training this semester.

##### REST
A ready to use REST interface. It includes commented out examples of CRUD methods to communicate with the database, which is something I highly suspect will be included. A client (console application) is also included with likewise examples of communication to the REST interface. 

##### SOAP
As the REST interface, the SOAP interface also includes commented out examples of all the CRUD methods. A client (console application) is included as well. 

##### TCP
Simple, working and ready to expand server and client setup for socket communication with the TCP protocol.

##### UDP Broadcaster
Ready to use UDP broadcaster and receiver. This example is very scraped and broadcasts the current time over the network (with a sleep-timer) while there's a receiver to pick up those broadcasts. 

##### UDP Server
Direct UDP communication between server and client. This example will only reply with the exact same message that you send to the server. Quickly to expand upon though. 
