USE PoliceDB_321
GO

CREATE TABLE ResponsibilityTypes
(
	type_id		TINYINT NOT NULL PRIMARY KEY,
	type_name	NVARCHAR(256)
)
GO

CREATE TABLE Responsibilities
(
	responsibility_id			SMALLINT NOT NULL PRIMARY KEY,
	responsibility_type			TINYINT	 NOT NULL FOREIGN KEY REFERENCES ResponsibilityTypes([type_id]),
	responsibility_duration		DATE,
	penalty						SMALLMONEY
)
GO

CREATE TABLE Violations
(
	violation_id			SMALLINT NOT NULL PRIMARY KEY,
	violation_description	NVARCHAR(1024) NOT NULL,
	[violation_start_date]	DATE,
	--violation_penalty		SMALLMONEY
)
GO

CREATE TABLE ViolationsResponsibilitiesRelation
(
	violation		SMALLINT NOT NULL,
	responsibility	smallint NOT NULL,
	CONSTRAINT		PK_VRR PRIMARY KEY (violation, responsibility),
	CONSTRAINT		FK_VRR_Violations		FOREIGN KEY (violation)			REFERENCES Violations		(violation_id),
	CONSTRAINT		FK_VRR_Responsibilities FOREIGN KEY (responsibility)	REFERENCES Responsibilities (responsibility_id)
)
GO