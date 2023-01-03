# Minesweeper

  In this project, two applications were developed, in different execution environments, that allow the user to play “Minesweeper” in solitary mode (anonymous or 
authenticated on the network). Microsoft Visual Studio 2019 and two application templates were used: 
      • Windows Forms App (.NET Framework); 
      • Universal Windows Platform (UWP); any of them with the C# language. 
  The two applications are implemented in order to take advantage of the use of the Model-View-Controller pattern by enhancing the reuse of Model and Controller 
components between applications.

Functional Description: 
   The developed platform incorporates the following features: 
      • It features two levels of difficulty that vary the size of the field and the corresponding number of mines: 
            o Easy – 9x9 field with 10 mines 
            o Medium – 16x16 field with 40 mines 
      • Registers the time with which the player discovers all the mines (wins the game); 
      • Indicates the number of mines that remain to be identified; • Works in standalone or network mode.

Standalone: 
    • The mines on the fields are randomly placed in each game; 
    • At the end of each won game, it saves in the file system, in XML format, the name of the player, the map level and the map resolution time. The file only saves the 
      information of the fastest to solve in each difficulty level; 
    • The name of the player who ends the game is requested when he wins; 
    • Allows you to consult the name of the fastest player and respective time for each difficulty level;

Network: 
    • The application connects to a server in order to function (address to be provided) 
    • For each new game, the application requests a new field from the server, with the appropriate size for the indicated level; 
    • When the game ends, the application asks the server to register the player, the result and, in case of victory, the time; 
    • Only those who are authenticated on the server can play over the network; 
    • In order to authenticate, it is necessary to proceed with prior registration on the server. Registration is done through the application itself and is based on a 
      profile with the following information: 
          o Short name 
          o Username 
          o Password 
          o Email 
          o Photo o Country; 
    • The remaining data will be saved on the server to complete each player's profile: 
          o Number of games won/lost 
          o Personal best time in each level 
    • The application allows you to consult the TOP 10 of the fastest to solve each difficulty level. In this TOP it is possible to consult for each player the name, 
      photo, country, number of games won and lost and times.
  
 Network communication protocol: 
    Communication with the server will be done through a Web Services API (to be provided) with data formatted in XML.

Requirements of the developed project: 
    Features in each of the applications: 
        • Consult TOP10 (online) 
        • Consult the profile of any player on the list (online) 
        • Consult TOP1 (offline) 
        • Register user (online) 
        • Authenticate user (online) 
        • Start game and generate the map (offline) 
        • Start the game and request the map from the server (online) 
        • Display the game information (time, mines and matrix) 
        • Implementation of the game logic 
        • Mark flags 
        • Show neighborhood numbers 
        • Finish the game if you “step on” a mine – lost game 
        • Finish the game if you mark all the mines correctly – game won 
        • When you open a house with neighborhood 0, automatically all neighboring and unmarked houses are opened (clicked). The action is repeated for all houses in 
          the neighborhood with a value of 0. 
        • In case of victory, save the result if you have the best time (offline)
        • Save the result on the server – victory or defeat (online) 
      General features: 
        • Data model same in both implemented projects 
        • Application logic code (controller) with common parts
