use cs3380;

CREATE TABLE City(
CityId VARCHAR(30) PRIMARY KEY,
CityName VARCHAR(30) NOT NULL,
State VARCHAR(2),
ZipCode VARCHAR(10)
);

CREATE TABLE Resident(
ResidentId INT PRIMARY KEY,
FirstName VARCHAR(30),
LastName VARCHAR(30),
StreetAddress VARCHAR(200),
Phone VARCHAR(15),
CityId VARCHAR(30) NOT NULL,
CONSTRAINT fk_Resident_CityId FOREIGN KEY(CityId)
REFERENCES City(CityId)
ON UPDATE CASCADE
);

CREATE TABLE Customer(
CustomerId INT NOT NULL,
Country VARCHAR(10),
PRIMARY KEY(CustomerId),
CONSTRAINT fk_custoner_CustomerId FOREIGN KEY(CustomerId)
REFERENCES  Resident(ResidentId)
ON UPDATE CASCADE
);

CREATE TABLE Employee(
EmployeeId INT NOT NULL,
HireDate DATE,
ManagerId INT,
SSN VARCHAR(15) NOT NULL,
EmailAddress VARCHAR(30) NOT NULL,
Salary INT,
PRIMARY KEY(EmployeeId),
CONSTRAINT fk_employee_EmployeeId FOREIGN KEY(EmployeeId)
REFERENCES Resident(ResidentId)
ON UPDATE CASCADE
);

CREATE TABLE Manufacturer(
ManufacturerId INT NOT NULL PRIMARY KEY,
ManufacturerName VARCHAR(30) NOT NULL,
Address1 VARCHAR(200),
Address2 VARCHAR(200),
Phone VARCHAR(20),
Fax VARCHAR(20),
Contact VARCHAR(30),
Url VARCHAR(200),
CityId VARCHAR(30),
CONSTRAINT FK_Manufacturer_CityId FOREIGN KEY(CityId)
REFERENCES City(CityId)
ON UPDATE CASCADE
);

CREATE TABLE Product(
ProductId INT NOT NULL PRIMARY KEY,
ProductName VARCHAR(100),
Composition VARCHAR(100),
ListPrice NUMERIC(8,2),
Gender CHAR(1),
Category VARCHAR(30),
Color VARCHAR(30),
Description VARCHAR(1000),
ManufacturerId INT,
CONSTRAINT FK_Product_ManufacturerId FOREIGN KEY(ManufacturerId)
REFERENCES Manufacturer(ManufacturerId)
ON UPDATE CASCADE
);

CREATE TABLE InventoryItem(
ItemSize NUMERIC(8,2) NOT NULL,
QtyOnHand INT NOT NULL,
ProductId INT,
PRIMARY KEY(ProductId, ItemSize),
CONSTRAINT FK_InventoryItem_ProductId FOREIGN KEY(ProductId)
REFERENCES Product(ProductId)
ON UPDATE CASCADE
);

CREATE TABLE Purchase(
PurchaseId INT PRIMARY KEY,
PurchaseDate DATE,
ExpectedDeliveryDate DATE,
Shipping NUMERIC(8,2),
EmployeeId INT NOT NULL,
CONSTRAINT FK_Purchase_EmployeeId FOREIGN KEY(EmployeeId)
REFERENCES Employee(EmployeeId)
ON UPDATE CASCADE
);

DROP TABLE PurchaseItem;
CREATE TABLE PurchaseItem(
PurchaseItemId INT PRIMARY KEY,
ItemSize NUMERIC(8,2),
Quantity INT NOT NULL,
PurchasePrice NUMERIC(8,2),
ProductId INT NOT NULL,
PurchaseId INT NOT NULL,
CONSTRAINT FK_PurchaseItem_PurchaseId FOREIGN KEY(PurchaseId)
REFERENCES Purchase(PurchaseId),
CONSTRAINT FK_PurchaseItem_ProductId FOREIGN KEY(ProductId)
REFERENCES Product(ProductId)
);

CREATE TABLE Sale(
SaleId INT PRIMARY KEY,
SaleDate DATE,
Tax NUMERIC(8,2),
Shipping NUMERIC(8,2),
CustomerId INT,
CONSTRAINT FK_Sale_CustomerId FOREIGN KEY(CustomerId)
REFERENCES Customer(CustomerId)
ON UPDATE CASCADE
);

CREATE TABLE SaleItem(
SaleItemId INT PRIMARY KEY,
Quantity INT,
SalePrice NUMERIC(8,2) NOT NULL,
ItemSize NUMERIC(8,2),
SaleId INT NOT NULL,
ProductId INT NOT NULL,
CONSTRAINT FK_SaleItem_SaleId FOREIGN KEY(SaleId)
REFERENCES Sale(SaleId)
ON UPDATE CASCADE,
CONSTRAINT FK_SaleItem_ProcutId FOREIGN KEY(ProductId)
REFERENCES Product(ProductId)
);