
select 
	TS.Id, T.[Name], C.[Name], TS.Years
from TeamStatistics TS
	join Teams T on T.Id=TS.TeamId
	join Championships C on C.Id=TS.ChampionshipId
order by T.Id