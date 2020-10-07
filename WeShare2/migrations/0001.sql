create table app_user (
	id serial primary key,
	name text,
	email text
);

create table trip_request (
	id serial primary key,
	user_id int,
	pickup_address text,
	destination_address text,
	pickup_time timestamp
);



create table trip_plan (
	id serial primary key,
	user_id int,
	pickup_address text,
	destination_address text,
	pickup_time timestamp,
	available_seat int
);