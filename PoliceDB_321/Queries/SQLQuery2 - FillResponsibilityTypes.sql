USE PoliceDB_321
GO

INSERT INTO ResponsibilityTypes
		([type_id], [type_name])
VALUES
		(1, N'Предупреждение'),
		(2, N'Выговор'),
		(3, N'Штраф'),
		(4, N'Лишение водительских прав'),
		(5, N'Изъятие транспортного средства'),
		(6, N'Лишение свободы')