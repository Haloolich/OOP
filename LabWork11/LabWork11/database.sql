CREATE DATABASE RailwayStation;
USE RailwayStation;

CREATE TABLE Trains (
    TrainId INT PRIMARY KEY,
    TrainName VARCHAR(50),
    OriginCity VARCHAR(50),
    DestinationCity VARCHAR(50)
);
CREATE TABLE Passengers (
    PassengerId INT PRIMARY KEY,
    PassengerName VARCHAR(50),
    ContactInfo VARCHAR(50)
);
CREATE TABLE Tickets (
    TicketId INT PRIMARY KEY,
    PassengerId INT,
    TrainId INT,
    JourneyDate DATE,
    FOREIGN KEY (PassengerId) REFERENCES Passengers(PassengerId),
    FOREIGN KEY (TrainId) REFERENCES Trains(TrainId)
);