
--DELETE FROM RentalTransaction;
--DELETE FROM VehicleReturns;
--DELETE FROM Booking;
--DELETE FROM Vehicle;
--DELETE FROM Customer;
--DELETE FROM Users;
--DELETE FROM FuelTypes ;
--DELETE FROM VehicleCategories;
--DELETE FROM People;

--DBCC CHECKIDENT ('RentalTransaction', RESEED, 1);
--DBCC CHECKIDENT ('VehicleReturns', RESEED, 0);
--DBCC CHECKIDENT ('Booking', RESEED, 0);
--DBCC CHECKIDENT ('Vehicle', RESEED, 0);
--DBCC CHECKIDENT ('Customer', RESEED, 0);
--DBCC CHECKIDENT ('Users', RESEED, 0);
--DBCC CHECKIDENT ('FuelTypes', RESEED, 0);
--DBCC CHECKIDENT ('VehicleCategories', RESEED, 0);
--DBCC CHECKIDENT ('People', RESEED, 0);


INSERT INTO People (FirstName, SecondName, LastName, DateOfBirth, Gender, Phone, Email, ImagePath) VALUES
('John', 'Michael', 'Smith', '1985-06-15', 1, '+9647701112233', 'john.smith@gmail.com', 'images/people/john.jpg'),
('Sarah', 'Jane', 'Connor', '1990-09-22', 0, '+9647702223344', 'sarah.connor@gmail.com', 'images/people/sarah.jpg'),
('David', 'Robert', 'Johnson', '1988-12-05', 1, '+9647703334455', 'david.johnson@gmail.com', 'images/people/david.jpg'),
('Emily', 'Grace', 'Davis', '1995-03-18', 0, '+9647704445566', 'emily.davis@gmail.com', 'images/people/emily.jpg'),
('Michael', 'Anthony', 'Brown', '1982-11-30', 1, '+9647705556677', 'michael.brown@gmail.com', 'images/people/michael.jpg'),
('Jessica', 'Marie', 'Wilson', '1992-07-12', 0, '+9647706667788', 'jessica.wilson@gmail.com', 'images/people/jessica.jpg'),
('James', 'William', 'Taylor', '1980-05-25', 1, '+9647707778899', 'james.taylor@gmail.com', 'images/people/james.jpg'),
('Amanda', 'Nicole', 'Anderson', '1993-10-08', 0, '+9647708889900', 'amanda.anderson@gmail.com', 'images/people/amanda.jpg'),
('Robert', 'Thomas', 'Thomas', '1987-01-19', 1, '+9647709990011', 'robert.thomas@gmail.com', 'images/people/robert.jpg'),
('Linda', 'Elizabeth', 'Jackson', '1991-04-14', 0, '+9647701010122', 'linda.jackson@gmail.com', 'images/people/linda.jpg'),
('William', 'Joseph', 'White', '1984-08-03', 1, '+9647702020233', 'william.white@gmail.com', 'images/people/william.jpg'),
('Elizabeth', 'Ann', 'Harris', '1996-02-27', 0, '+9647703030344', 'elizabeth.harris@gmail.com', 'images/people/elizabeth.jpg'),
('Richard', 'Charles', 'Martin', '1979-09-10', 1, '+9647704040455', 'richard.martin@gmail.com', 'images/people/richard.jpg'),
('Barbara', 'Jean', 'Lee', '1994-06-21', 0, '+9647705050566', 'barbara.lee@gmail.com', 'images/people/barbara.jpg'),
('Charles', 'Henry', 'Perez', '1986-12-11', 1, '+9647706060677', 'charles.perez@gmail.com', 'images/people/charles.jpg');








INSERT INTO VehicleCategories(CategoryName) VALUES
('Sedan'),
('SUV'),
('Hatchback'),
('Luxury'),
('Truck');

INSERT INTO FuelTypes(FuelType) VALUES
('Gasoline'),
('Diesel'),
('Electric'),
('Hybrid');

INSERT INTO Users (PersonID, UserName, Password, Salt, Iterations, IsActive) VALUES
(1, 'AdminMohamed', 0x24326124313024564B536D487635586A707A4864433858713735394175, 0x48656C6C6F576F726C6453616C743132, 10000, 1),
(2, 'SarahStaff', 0x24326124313024564B536D487635586A707A4864433858713735394175, 0x48656C6C6F576F726C6453616C743133, 10000, 1),
(3, 'DavidManager', 0x24326124313024564B536D487635586A707A4864433858713735394175, 0x48656C6C6F576F726C6453616C743134, 10000, 1);



INSERT INTO Customer(PersonID, DriverLicenseNumber) VALUES
(4, 'DL-9081234'),
(5, 'DL-8872341'),
(6, 'DL-7763452'),
(7, 'DL-6654563'),
(8, 'DL-5545674'),
(9, 'DL-4436785'),
(10, 'DL-3327896'),
(11, 'DL-2218907');


INSERT INTO Vehicle (Make, Model, VehicleYear, Mileage, FuelTypeID, PlateNumber, CarCategoryID, RentalPricePerDay, IsAvailableForRent) VALUES
('Toyota', 'Camry', 2023, 15000, 1, 'BAG-1001', 1, 45.00, 1),
('Hyundai', 'Tucson', 2022, 28000, 1, 'BAG-1002', 2, 60.00, 1),
('Kia', 'Cerato', 2024, 5000, 1, 'BAG-1003', 1, 40.00, 1),
('Ford', 'Explorer', 2021, 45000, 1, 'BAG-1004', 2, 85.00, 0),
('Tesla', 'Model 3', 2023, 10000, 3, 'BAG-1005', 4, 110.00, 1),
('Toyota', 'Prius', 2022, 22000, 4, 'BAG-1006', 3, 50.00, 1),
('Chevrolet', 'Tahoe', 2020, 60000, 1, 'BAG-1007', 2, 120.00, 0),
('Nissan', 'Sunny', 2023, 12000, 1, 'BAG-1008', 1, 35.00, 1);

INSERT INTO Booking(CustomerID, VehicleID, RentalStartDate, RentalEndDate, PickupLocation, DropoffLocation, InitialRentalDays, RentalPricePerDay, InitialTotalDueAmount, InitialCheckNotes) VALUES
(1, 4, '2026-05-01', '2026-05-08', 'Baghdad Airport', 'Baghdad Al-Karrada', 7, 85.00, 595.00, 'Car in good condition, minor scratch on front bumper.'),
(2, 7, '2026-05-05', '2026-05-12', 'Main Branch', 'Main Branch', 7, 120.00, 840.00, 'Clean interior, full fuel tank.'),
(3, 1, '2026-05-10', '2026-05-15', 'Al-Mansour Office', 'Al-Mansour Office', 5, 45.00, 225.00, 'Brand new condition.');

INSERT INTO VehicleReturns(ActualReturnDate, ActualRentalDays, Mileage, ConsumedMileage, FinalCheckNotes, AdditionalCharges, ActualTotalDueAmount, BookingID) VALUES
('2026-05-08 14:30:00', 7, 45500, 500, 'Returned on time, no new damages.', 0.00, 595.00, 1),
('2026-05-13 10:15:00', 8, 61200, 1200, 'Late return by 1 day, extra cleaning needed.', 50.00, 940.00, 2);

INSERT INTO RentalTransaction(BookingID, ReturnID, PaymentDetails, PaidInitialTotalDueAmount, ActualTotalDueAmount, TotalRemaining, TotalRefundedAmount, TransactionDate, UpdatedTransactionDate) VALUES
(1, 1, 'Paid via Visa Card ending in 4021', 595.00, 595.00, 0.00, 0.00, '2026-05-01 10:00:00', '2026-05-08 14:35:00'),
(2, 2, 'Paid via Cash', 840.00, 940.00, 100.00, 0.00, '2026-05-05 11:30:00', '2026-05-13 10:20:00'),
(3, NULL, 'Paid via MasterCard', 225.00, 225.00, 0.00, 0.00, '2026-05-10 09:15:00', '2026-05-10 09:15:00');