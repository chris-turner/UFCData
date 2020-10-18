# UFCData
 UFC Web scraper, database, and API
 
 Scrapes statistics from http://ufcstats.com into an MSSQL database

# API Methods

# Fight Cards
GET
/fightcards

Returns all fight cards and IDs

/fightcards/{fightCardID}
Returns fight card(s) for supplied ID(s)
Multiple IDs can be separated by commas

/fightcards/fights/{fightCardID}
Returns fights for card for supplied ID

# Fight
GET
/fights

Returns all fights and IDs

GET
/fights/{fightID}
Returns fight info for supplied ID(s)
Multiple IDs can be separated by commas


# FightStats
GET
/fightstats/{fightID}

Returns fight stats for the supplied ID
