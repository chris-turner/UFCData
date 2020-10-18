# UFCData
 UFC Web scraper, database, and API
 
 Scrapes statistics from http://ufcstats.com into an MSSQL database
 
 # About
 As most mainstream sports are fully embracing analytics, UFC seems to lag behind. One reason for this could be the lack of public tools that allow you to easily pull data. The UFC API provides a clean UFC dataset in a friendly JSON format.

# API Methods

# Fight Cards
GET<br/>
/fightcards
<br/>
Returns all fight cards and IDs

/fightcards/{fightCardID}<br/>
Returns fight card(s) for supplied ID(s)<br/>
Multiple IDs can be separated by commas
<br/>
/fightcards/fights/{fightCardID}<br/>
Returns fights for card for supplied ID<br/>

# Fight
GET<br/>
/fights<br/>

Returns all fights and IDs<br/>

GET<br/>
/fights/{fightID}<br/>
Returns fight info for supplied ID(s)<br/>
Multiple IDs can be separated by commas<br/>


# FightStats
GET<br/>
/fightstats/{fightID}<br/>

Returns fight stats for the supplied ID<br/>
