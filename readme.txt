https://github.com/dcarlson661/ahoymatey.git

https://github.com/dcarlson661/Ahoy-Matey.git

server has the official development unity project
client has a separate repos folder with a network copy of the server project

remembering that we ignore certain unity generated folders when we github the project
Temp/ 
Obj/ 
UnityGenerated/ 
Library/ 
Assets/AssetStoreTools* 

I copied to the client the whole unity folder then deleted the folders Temp and Library on the client
I opened the unity project on the client and it rebuild the library and temp just as a github project does.
Extra:
I'm using visual studio 15 as my editor so the vs sln and proj files were copied from the 
 server to the client as well.  But when I tried to open a script in vs on the client
 it failed.  I suspect the paths are different between the server and client.  I manually
 opened the sln in vs15 on the client and it worked and compiled.
 Now I know that Ben said the client is only for testing and that no actual coding 
  is to be done on the client copy,  but I wanted to play with this myself.

Back on the server I created the second cube object, and saved the scene and project.
I then copied JUST the assets directory from the server to the client 
 using a windows to windows remote desktop and opened two file explorers on the client
 one folder the local c:\repos\unity\Ahoy-Matey and server \\machine\c:\repos\Ahoy-Matey

Unity on the client recognized the changes and re-loaded just as in Ben's video.








