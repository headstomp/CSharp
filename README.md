# Tournament Tracker

## Requirments

1. Track games played and their outcome (who won).<br>
2. Multiple compentitors play in topurnament.<br>
3. Create tournament plan (who plays in what order).<br>
4. Schedule games.<br>
5. A single loss eliminates a player.<br>
6. The last player standing is the winner.<br>

## Questions

1. How mnay players will the touranment handle? Is it variable.<br>
   - variable number of players 
2. If a touranment has less than a full complement of players, how do we handle it?.<br>
   - If less than perfect number of players add random byes.
3. Should the order of who plays each other be random or ordered by input order?.<br>
   - Random
4. Should we schedule the game or are they just played whenever?.<br>
   - whatever order and whenever the players want to play them.
5. If the games are scheduled, how does the system know when to schedule games for?.<br>
   - not scheduled.
6. If the games are played whenever, can a game from the second round be played before the first round is complete?<br>
   - NO
7. Does the system need to store a score of some kind or just who won?<br>
   - Storing a score would be nice. Just a number for each player.
8. What type of front-end should the system have?<br>
   - Desktop for now, but doen the road we might want to turn it into an app or a website.
9. Where will the data be stored?<br>
   - Ideally, the data should be stored in a SQL database but please put in an option to store in a text file.
10. Will this system handle entry fees, prozes, or other payouts?<br>
    - Yes, Should be able to charge an entry fee, Prizes should be an option where the admin chooses how much money to award a variable number of places. The total cash amount should not exceed the income from the tournament. A percentage based system would be nice.
11. What type of reporting is needed?<br>
    - Simple report showing outcome of games per round as well a report that specifies who won and how much thjey one. Reports can be a form or they can be emailed to players.
12. Who can fill out the results of a game?<br>
    - Anyone using the application.
13. Are there varying levels of access?<br>
    - No, The only method of varied access is if the competitors are not allowed into the application and instead, they do everything via email.
14. Should the system contact users about upcoming games?<br>
    - Yes, the system should email users that they are due to play a round as well who they are scheduled to play.
15. Is each player on their own or can teams use this tracker?<br>
    - The tracker should be able to handle the addition of other members. All members should be treated as equals in that they all get touranment emails. Teams should also be able to name their team.
        
## Big Picture Design

**Structure:** Windows Forms application and Class Library<br>
**Data:**      SQL and/or Text File<br>
**Users:**     One at a time on one application<br>

## Key Concepts

- Email
- SQL
- Custom Events
- Error Handling
- Interfaces
- Random Ordering

## Data Design

**Team**<br>
   - TeamMembers (List<Person>)
   - TeamName (string)
   
**Person**<br>
   - FirstName (string)
   - LastName (string)
   - EmailAdress (string)
   
**Tournament**<br>
   - TournamentName (string)
   - EntryFee (decimal)
   - EnteredTeams (List<Team>)
   - Prizes (List<Prize>)
   - Rounds (List<List<Matchup>>)
   
**Prize**<br>
   - PlaceNumber (int)
   - PlaceName (string)
   - PrizeAmount (decimal)
   - PrizePercentage (double)
   
**Matchup**<br>
   - Entries (List<MatchupEntry>)
   - Winner (Team)
   - MatchupRound (int)
   
**MatchupEntry**<br>
   - TeamCompeting (Team)
   - Score (double)
   - ParentMatchup (Matchup)
   
## UI Design
![GitHub Logo](/images/Dashboard.png)
![GitHub Logo](/images/Tournamnet.png)
![GitHub Logo](/images/CreateTournament.png)
![GitHub Logo](/images/CreateTeam.png)
![GitHub Logo](/images/CreatePrize.png)
