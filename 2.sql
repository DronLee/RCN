SELECT R.Number 'Номер маршрута'
	, CAST(S.ArrivalTime AS CHAR(5)) 'Время прибытия на остановку'
	, (SELECT TOP 1 ST.Name FROM dbo.Station ST WHERE ST.Id = RP.StationId) 'Наименование остановки'
	FROM dbo.Schedule S
		INNER JOIN dbo.Trip T ON T.Id = S.TripId
		INNER JOIN dbo.Bus B ON B.Id = T.BusId
		INNER JOIN dbo.[Route] R ON R.Id = T.RouteId
		INNER JOIN dbo.RoutePoint RP ON RP.Id = S.RoutePointId
		INNER JOIN dbo.BusTypesOnBus BTB ON BTB.BusId = B.Id
		INNER JOIN dbo.BusType BT ON BT.Id = BTB.BusTypeId
	WHERE BT.Name = 'Междугородний' AND MONTH(T.[Day]) = MONTH(GETDATE()) AND DATEPART(WEEKDAY, T.[Day]) IN (6, 7)
	ORDER BY S.TripId, RP.StationIndex