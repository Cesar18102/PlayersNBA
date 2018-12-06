CREATE TABLE TEAM(
	id NUMBER(10) PRIMARY KEY,
	name NVARCHAR2(100),
	year_start DATE,
	country NVARCHAR2(100),
	city NVARCHAR2(100),
	conf NVARCHAR2(100),
	arena NVARCHAR2(100),
	colors NVARCHAR2(512)
);

CREATE TABLE COACH(
	id NUMBER(10) PRIMARY KEY,
	surname NVARCHAR2(100),
	name NVARCHAR2(100),
	fathername NVARCHAR2(100),
	birth DATE,
	citizenship NVARCHAR2(100),
	team_id NUMBER(10),
	CONSTRAINT fk_team_id FOREIGN KEY(team_id) REFERENCES TEAM(id) ON DELETE CASCADE
);

CREATE TABLE PLAYER(
	id NUMBER(10) PRIMARY KEY,
	surname NVARCHAR2(100),
	name NVARCHAR2(100),
	fathername NVARCHAR2(100),
	birth DATE,
	citizenship NVARCHAR2(100),
	height NUMBER(10),
	weight NUMBER(10),
	role NVARCHAR2(50),
	num NUMBER(10),
	team_id NUMBER(10),
	FOREIGN KEY(team_id) REFERENCES TEAM(id) ON DELETE CASCADE
);

CREATE TABLE EX_PLAYER(
	player_id NUMBER(10),
	team_id NUMBER(10),
	date_start DATE,
	date_finish DATE,
	FOREIGN KEY(player_id) REFERENCES PLAYER(id),
	FOREIGN KEY(team_id) REFERENCES TEAM(id)
);

CREATE TABLE EX_COACH(
	coach_id NUMBER(10),
	team_id NUMBER(10),
	date_start DATE,
	date_finish DATE,
	FOREIGN KEY(coach_id) REFERENCES COACH(id),
	FOREIGN KEY(team_id) REFERENCES TEAM(id)
);

CREATE TABLE GAME(
	id NUMBER(10) PRIMARY KEY,
	owner_team_id NUMBER(10),
	guest_team_id NUMBER(10),
	place NVARCHAR2(100),
	game_date DATE,
	game_time TIMESTAMP,
	scores NVARCHAR2(20),
	FOREIGN KEY(owner_team_id) REFERENCES TEAM(id),
	FOREIGN KEY(guest_team_id) REFERENCES TEAM(id)
);

CREATE TABLE PLAYER_GAME(
	player_id NUMBER(10),
	game_id NUMBER(10),
	throws NUMBER(10),
	points NUMBER(10),
	passes NUMBER(10),
	pickups NUMBER(10),
	blockshots NUMBER(10),
	intercepts NUMBER(10),
	faults NUMBER(10),
	misses NUMBER(10),
	FOREIGN KEY(player_id) REFERENCES PLAYER(id),
	FOREIGN KEY(game_id) REFERENCES GAME(id)
);