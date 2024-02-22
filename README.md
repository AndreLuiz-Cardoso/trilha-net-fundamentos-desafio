# DIO - Trilha .NET - Fundamentos
www.dio.me

## Project Challenge
For this challenge, I needed to use my basic knowledge acquired in the fundamentals module of the .NET track at DIO.

## Context
You have been hired to build a system for a parking lot, which will be used to manage parked vehicles and perform operations such as adding a vehicle, removing a vehicle (and displaying the charged amount during the period), and listing the vehicles.

## Proposal
The class contains three variables, namely:

**initialPrice:** Decimal type. It is the price charged to leave your vehicle parked.

**hourlyPrice:** Decimal type. It is the price per hour that the vehicle remains parked.

**vehicles:** It is a list of strings, representing a collection of parked vehicles. It contains only the vehicle's license plate.

The class contains three methods, namely:

**AddVehicle:** Method responsible for receiving a license plate entered by the user and storing it in the vehicles variable.

**RemoveVehicle:** Method responsible for checking if a certain vehicle is parked, and if so, it will ask for the number of hours it stayed in the parking lot. After that, it performs the following calculation: **initialPrice** + (**hourlyPrice** * hours), displaying it to the user.

**ListVehicles:** Lists all vehicles currently present in the parking lot. If there are none, display the message "There are no parked vehicles."

Finally, an interactive menu should be implemented with the following actions:

1. Register vehicle
2. Remove vehicle
3. List vehicles
4. Exit
