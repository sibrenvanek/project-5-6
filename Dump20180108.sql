-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: new_test
-- ------------------------------------------------------
-- Server version	5.6.38-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `aspnetroles`
--

DROP TABLE IF EXISTS `aspnetroles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aspnetroles` (
  `Id` varchar(128) NOT NULL,
  `Name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetroles`
--

LOCK TABLES `aspnetroles` WRITE;
/*!40000 ALTER TABLE `aspnetroles` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetroles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetuserclaims`
--

DROP TABLE IF EXISTS `aspnetuserclaims`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aspnetuserclaims` (
  `id` int(11) NOT NULL,
  `userid` varchar(128) DEFAULT NULL,
  `Claimtype` varchar(45) DEFAULT NULL,
  `Claimvalue` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `aspnetusers_aspnetuserclaims_id_idx` (`userid`),
  CONSTRAINT `aspnetusers_aspnetuserclaims_id` FOREIGN KEY (`userid`) REFERENCES `aspnetusers` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetuserclaims`
--

LOCK TABLES `aspnetuserclaims` WRITE;
/*!40000 ALTER TABLE `aspnetuserclaims` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetuserclaims` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetuserlogins`
--

DROP TABLE IF EXISTS `aspnetuserlogins`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aspnetuserlogins` (
  `LoginProvider` varchar(128) NOT NULL,
  `ProviderKey` varchar(128) NOT NULL,
  `UserId` varchar(128) NOT NULL,
  PRIMARY KEY (`UserId`),
  CONSTRAINT `aspnetusers_aspnetuserlogins_id` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetuserlogins`
--

LOCK TABLES `aspnetuserlogins` WRITE;
/*!40000 ALTER TABLE `aspnetuserlogins` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetuserlogins` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetuserroles`
--

DROP TABLE IF EXISTS `aspnetuserroles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aspnetuserroles` (
  `UserId` varchar(128) NOT NULL,
  `RoleId` varchar(128) NOT NULL,
  PRIMARY KEY (`RoleId`,`UserId`),
  KEY `Roles_Roles_ID_idx` (`RoleId`),
  KEY `aspnetusers_aspnetuserroles_id_idx` (`UserId`),
  CONSTRAINT `aspnetroles_aspnetuserroles_id` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `aspnetusers_aspnetuserroles_id` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetuserroles`
--

LOCK TABLES `aspnetuserroles` WRITE;
/*!40000 ALTER TABLE `aspnetuserroles` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetuserroles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aspnetusers`
--

DROP TABLE IF EXISTS `aspnetusers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aspnetusers` (
  `Id` varchar(128) NOT NULL,
  `Email` varchar(256) DEFAULT NULL,
  `EmailConfirmed` tinyint(4) NOT NULL,
  `PasswordHash` varchar(45) DEFAULT NULL,
  `SecurityStamp` varchar(45) DEFAULT NULL,
  `PhoneNumber` varchar(15) DEFAULT NULL,
  `PhoneNumberConfirmed` bit(1) NOT NULL,
  `TwoFactorEnabled` bit(1) NOT NULL,
  `LockoutEndDateUtc` datetime DEFAULT NULL,
  `LockoutEnabled` bit(1) NOT NULL,
  `AccessFailedCount` int(11) NOT NULL,
  `UserName` varchar(256) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aspnetusers`
--

LOCK TABLES `aspnetusers` WRITE;
/*!40000 ALTER TABLE `aspnetusers` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetusers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `case`
--

DROP TABLE IF EXISTS `case`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `case` (
  `ID` int(11) NOT NULL,
  `Brand` varchar(45) DEFAULT NULL,
  `ComputerHousing` varchar(45) DEFAULT NULL,
  `FormatMotherboard` varchar(45) DEFAULT NULL,
  `USB2` int(11) DEFAULT NULL,
  `USB3` int(11) DEFAULT NULL,
  `Bays35` int(11) DEFAULT NULL,
  `Bays25` int(11) DEFAULT NULL,
  `Bays525` int(11) DEFAULT NULL,
  `ExtensionLocks` int(11) DEFAULT NULL,
  `Max_Length_Videocard` int(11) DEFAULT NULL,
  `fanpositions` int(11) DEFAULT NULL,
  `FrontFan` int(11) DEFAULT NULL,
  `RearSideFan` int(11) DEFAULT NULL,
  `SideFan` int(11) DEFAULT NULL,
  `TopSideLock` int(11) DEFAULT NULL,
  `FanSupplied` int(11) DEFAULT NULL,
  `MaximumAltitutdeOricessir` int(11) DEFAULT NULL,
  `LocationPowerSupply` varchar(45) DEFAULT NULL,
  `PanelDoor` varchar(45) DEFAULT NULL,
  `NoiseReduction` varchar(45) DEFAULT NULL,
  `DustFilter` varchar(45) DEFAULT NULL,
  `FanController` varchar(45) DEFAULT NULL,
  `SoundProofingMats` varchar(45) DEFAULT NULL,
  `Weight` int(11) DEFAULT NULL,
  `Width` int(11) DEFAULT NULL,
  `Depth` int(11) DEFAULT NULL,
  `Height` int(11) DEFAULT NULL,
  `Color` varchar(45) DEFAULT NULL,
  `Material` varchar(45) DEFAULT NULL,
  `Price` decimal(10,0) DEFAULT NULL,
  `Name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  CONSTRAINT `Product_Case_ID` FOREIGN KEY (`ID`) REFERENCES `product` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `case`
--

LOCK TABLES `case` WRITE;
/*!40000 ALTER TABLE `case` DISABLE KEYS */;
/*!40000 ALTER TABLE `case` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `chat`
--

DROP TABLE IF EXISTS `chat`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `chat` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `content` varchar(45) DEFAULT NULL,
  `ChatStopped` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chat`
--

LOCK TABLES `chat` WRITE;
/*!40000 ALTER TABLE `chat` DISABLE KEYS */;
/*!40000 ALTER TABLE `chat` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cpucooler`
--

DROP TABLE IF EXISTS `cpucooler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cpucooler` (
  `ID` int(11) NOT NULL,
  `Brand` varchar(45) DEFAULT NULL,
  `FanConnections` int(11) DEFAULT NULL,
  `CoolingMethod` varchar(45) DEFAULT NULL,
  `Socket` varchar(45) DEFAULT NULL,
  `DiameterFan` int(11) DEFAULT NULL,
  `Min_RotationSpeed` int(11) DEFAULT NULL,
  `Max_RotationSpeed` int(11) DEFAULT NULL,
  `Min_SoundProduction` float DEFAULT NULL,
  `Max_SoundProduction` float DEFAULT NULL,
  `HeatPipes` int(11) DEFAULT NULL,
  `Weight` float DEFAULT NULL,
  `Width` float DEFAULT NULL,
  `Depth` float DEFAULT NULL,
  `Height` float DEFAULT NULL,
  `Price` decimal(10,0) DEFAULT NULL,
  `Name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  CONSTRAINT `Product_CPUcooler_ID` FOREIGN KEY (`ID`) REFERENCES `product` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cpucooler`
--

LOCK TABLES `cpucooler` WRITE;
/*!40000 ALTER TABLE `cpucooler` DISABLE KEYS */;
/*!40000 ALTER TABLE `cpucooler` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gpu`
--

DROP TABLE IF EXISTS `gpu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `gpu` (
  `ID` int(11) NOT NULL,
  `Brand` varchar(45) DEFAULT NULL,
  `BusType` varchar(45) DEFAULT NULL,
  `FreeLocksRequired` int(11) DEFAULT NULL,
  `LowProfile` tinyint(4) DEFAULT NULL,
  `Resolution` varchar(45) DEFAULT NULL,
  `Manufacturer` varchar(45) DEFAULT NULL,
  `TypeOfGPU` varchar(45) DEFAULT NULL,
  `Clockspeed` int(11) DEFAULT NULL,
  `Turbofrequency` int(11) DEFAULT NULL,
  `StreamProcessors` int(11) DEFAULT NULL,
  `CoolingMethod` varchar(45) DEFAULT NULL,
  `VideoMemory` int(11) DEFAULT NULL,
  `TypeOfMemory` varchar(45) DEFAULT NULL,
  `ClockspeedMemoryModule` int(11) DEFAULT NULL,
  `BandwithMemoryBus` int(11) DEFAULT NULL,
  `VGAport` int(11) DEFAULT NULL,
  `DVIOutputs` int(11) DEFAULT NULL,
  `HDMIOutputs` int(11) DEFAULT NULL,
  `DisplayPorts` int(11) DEFAULT NULL,
  `MaxPowerConsumption` int(11) DEFAULT NULL,
  `MinRequiredFeed` int(11) DEFAULT NULL,
  `PowerConnectors` varchar(45) DEFAULT NULL,
  `Directx` float DEFAULT NULL,
  `OpenGL` float DEFAULT NULL,
  `AMDCrossfireX` tinyint(4) DEFAULT NULL,
  `NVIDEASLI` tinyint(4) DEFAULT NULL,
  `HDCP` tinyint(4) DEFAULT NULL,
  `Width` float DEFAULT NULL,
  `Depth` float DEFAULT NULL,
  `Height` float DEFAULT NULL,
  `Price` decimal(10,0) DEFAULT NULL,
  `Name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  CONSTRAINT `Product_GPU_ID` FOREIGN KEY (`ID`) REFERENCES `product` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gpu`
--

LOCK TABLES `gpu` WRITE;
/*!40000 ALTER TABLE `gpu` DISABLE KEYS */;
/*!40000 ALTER TABLE `gpu` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `internalharddisk`
--

DROP TABLE IF EXISTS `internalharddisk`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `internalharddisk` (
  `ID` int(11) NOT NULL,
  `Brand` varchar(45) DEFAULT NULL,
  `HDDSpeed` int(11) DEFAULT NULL,
  `Cache` int(11) DEFAULT NULL,
  `HDDFormat` float DEFAULT NULL,
  `Height` float DEFAULT NULL,
  `InternalHDDDiskcol` varchar(45) DEFAULT NULL,
  `Name` varchar(45) DEFAULT NULL,
  `StorageCapacity` int(11) DEFAULT NULL,
  `Price` decimal(10,0) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  CONSTRAINT `Product_Internalharddisk_ID` FOREIGN KEY (`ID`) REFERENCES `product` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `internalharddisk`
--

LOCK TABLES `internalharddisk` WRITE;
/*!40000 ALTER TABLE `internalharddisk` DISABLE KEYS */;
/*!40000 ALTER TABLE `internalharddisk` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `motherboard`
--

DROP TABLE IF EXISTS `motherboard`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `motherboard` (
  `ID` int(11) NOT NULL,
  `Brand` varchar(45) DEFAULT NULL,
  `FormatMotherboard` varchar(45) DEFAULT NULL,
  `Socket` int(11) DEFAULT NULL,
  `Chipset` varchar(45) DEFAULT NULL,
  `ClockSpeedMemoryModule` int(11) DEFAULT NULL,
  `Max_AmountOfMemory` int(11) DEFAULT NULL,
  `MemoryLockedTotal` int(11) DEFAULT NULL,
  `Memory` varchar(45) DEFAULT NULL,
  `Width` float DEFAULT NULL,
  `Depth` float DEFAULT NULL,
  `Height` float DEFAULT NULL,
  `Price` decimal(10,0) DEFAULT NULL,
  `Name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  CONSTRAINT `Product_Motherboard_ID` FOREIGN KEY (`ID`) REFERENCES `product` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `motherboard`
--

LOCK TABLES `motherboard` WRITE;
/*!40000 ALTER TABLE `motherboard` DISABLE KEYS */;
/*!40000 ALTER TABLE `motherboard` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `powersupply`
--

DROP TABLE IF EXISTS `powersupply`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `powersupply` (
  `ID` int(11) NOT NULL,
  `Brand` varchar(45) DEFAULT NULL,
  `VersionFormFactor` varchar(45) DEFAULT NULL,
  `Modular` tinyint(4) DEFAULT NULL,
  `DiameterFan` float DEFAULT NULL,
  `Power` int(11) DEFAULT NULL,
  `Certification` varchar(45) DEFAULT NULL,
  `AverageLifespan` int(11) DEFAULT NULL,
  `Width` float DEFAULT NULL,
  `Depth` float DEFAULT NULL,
  `Height` float DEFAULT NULL,
  `Price` decimal(10,0) DEFAULT NULL,
  `Name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  CONSTRAINT `Product_Powersupply_ID` FOREIGN KEY (`ID`) REFERENCES `product` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `powersupply`
--

LOCK TABLES `powersupply` WRITE;
/*!40000 ALTER TABLE `powersupply` DISABLE KEYS */;
/*!40000 ALTER TABLE `powersupply` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `product`
--

DROP TABLE IF EXISTS `product`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `product` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `price` decimal(10,0) DEFAULT NULL,
  `imagepath` longtext,
  `stock` int(11) DEFAULT NULL,
  `Brand` varchar(45) DEFAULT NULL,
  `Supplier` varchar(45) DEFAULT NULL,
  `ProductName` varchar(45) DEFAULT NULL,
  `PurchasedQuantity` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product`
--

LOCK TABLES `product` WRITE;
/*!40000 ALTER TABLE `product` DISABLE KEYS */;
INSERT INTO `product` VALUES (1,80,'~/images/ram/ram1.jpg',95,'Kingston','testsupplier','Kingston ValueRAM',5),(2,220,'~/images/ram/ram2.png',99,'Kingston','testsupplier','Kingston HyperX Fury 10',2),(3,120,'~/images/ram/ram3.png',100,'Kingston','testsupplier','Kingston 8GB DDR3',NULL),(4,180,'~/images/ram/ram4.png',100,'Kingston','testsupplier','Kingston HyperX Impact',NULL),(5,300,'~/images/ram/ram5.png',100,'Corsair','testsupplier','Corsair Vengeance LPX',NULL),(6,95,'~/images/ram/ram6.png',99,'Corsair','testsupplier','Corsair Vengeance LPX 8 GB',2),(7,70,'~/images/ram/ram7.png',100,'Corsair','testsupplier','Corsair 8 GB SODIMM DDR3',NULL),(8,89,'~/images/ram/ram8.png',100,'Crucial','testsupplier','Crucial 8 GB SODIMM DDR4',NULL),(9,110,'~/images/ram/ram9.png',100,'Crucial','testsupplier','Crucial Ballistix Sport LT',NULL),(10,235,'~/images/ram/ram10.png',100,'Crucial','testsupplier','Crucial Standard 16 GB SODIMM DDR3L',NULL);
/*!40000 ALTER TABLE `product` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ram`
--

DROP TABLE IF EXISTS `ram`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ram` (
  `ID` int(11) NOT NULL,
  `Brand` varchar(45) DEFAULT NULL,
  `CompositionOfMemory` varchar(45) DEFAULT NULL,
  `MemoryType` varchar(45) DEFAULT NULL,
  `Clockspeed` int(11) DEFAULT NULL,
  `CASlatency` int(11) DEFAULT NULL,
  `Voltage` float DEFAULT NULL,
  `MemoryModuleConnection` int(11) DEFAULT NULL,
  `MemorySuitableFor` varchar(45) DEFAULT NULL,
  `ImagePath` longtext,
  `Name` varchar(45) DEFAULT NULL,
  `Price` decimal(10,0) DEFAULT NULL,
  `Ramsize` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  CONSTRAINT `Product_Ram_ID` FOREIGN KEY (`ID`) REFERENCES `product` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ram`
--

LOCK TABLES `ram` WRITE;
/*!40000 ALTER TABLE `ram` DISABLE KEYS */;
INSERT INTO `ram` VALUES (1,'Kingston','1x','DDR3',2133,15,1.2,1,'Desktop','~/images/ram/ram1.jpg','Kingston ValueRAM',50,4),(2,'Kingston','2x','DDR3',2350,15,1.5,1,'Desktop','~/images/ram/ram2.png','Kingston HyperX Fury 10',220,16),(3,'Kingston','1x','DDR3',2200,15,1.2,1,'Desktop','~/images/ram/ram3.png','Kingston 8GB DDR3',80,8),(4,'Kingston','2x','DDR3',2180,15,1.25,1,'Desktop','~/images/ram/ram4.png','Kingston HyperX Impact',180,16),(5,'Corsair','2x','DDR4',2230,15,1.4,1,'Desktop','~/images/ram/ram5.png','Corsair Vengeance LPX',300,16),(6,'Corsair','2x','DDR3',2300,15,1.5,1,'Desktop','~/images/ram/ram6.png','Corsair Vengeance LPX 8 GB',95,8),(7,'Corsair','2x','DDR3',2250,15,1.2,1,'Desktop','~/images/ram/ram7.png','Corsair 8 GB SODIMM DDR3',70,8),(8,'Crucial','1x','DDR4',1900,15,1.35,1,'Laptop','~/images/ram/ram8.png','Crucial 8 GB SODIMM DDR4',89,8),(9,'Crucial','2x','DDR4',2190,15,1.2,1,'Desktop','~/images/ram/ram9.png','Crucial Ballistix Sport LT',140,8),(10,'Crucial','2x','DDR3',1600,15,1.2,1,'Desktop','~/images/ram/ram10.png','Crucial Standard 16 GB SODIMM DDR3L',235,16);
/*!40000 ALTER TABLE `ram` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roles`
--

DROP TABLE IF EXISTS `roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `roles` (
  `Id` varchar(128) NOT NULL,
  `Name` varchar(256) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles`
--

LOCK TABLES `roles` WRITE;
/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
/*!40000 ALTER TABLE `roles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `shoppingcart`
--

DROP TABLE IF EXISTS `shoppingcart`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `shoppingcart` (
  `ProductId` int(11) NOT NULL,
  `Quantity` int(11) DEFAULT NULL,
  `UserId` int(11) DEFAULT NULL,
  `Price` decimal(10,0) DEFAULT NULL,
  `ProductName` varchar(45) DEFAULT NULL,
  `Imagepath` longtext,
  PRIMARY KEY (`ProductId`),
  CONSTRAINT `Product_Shoppingcart_ID` FOREIGN KEY (`ProductId`) REFERENCES `product` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `shoppingcart`
--

LOCK TABLES `shoppingcart` WRITE;
/*!40000 ALTER TABLE `shoppingcart` DISABLE KEYS */;
INSERT INTO `shoppingcart` VALUES (1,1,NULL,0,'Kingston ValueRAM','~/images/ram/ram1.jpg');
/*!40000 ALTER TABLE `shoppingcart` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ssd`
--

DROP TABLE IF EXISTS `ssd`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ssd` (
  `ID` int(11) NOT NULL,
  `Brand` varchar(45) DEFAULT NULL,
  `Connection` varchar(45) DEFAULT NULL,
  `StorageCapacity` int(11) DEFAULT NULL,
  `AverageTimeBetweenFailures` int(11) DEFAULT NULL,
  `TypeOfMemory` varchar(45) DEFAULT NULL,
  `SSDController` varchar(45) DEFAULT NULL,
  `HardDiskFormat` float DEFAULT NULL,
  `Max_ReadSpeed` int(11) DEFAULT NULL,
  `Min_ReadingSpeed` int(11) DEFAULT NULL,
  `Random_ReadingSpeed` int(11) DEFAULT NULL,
  `Random_WriteSpeed` int(11) DEFAULT NULL,
  `Width` float DEFAULT NULL,
  `Depth` float DEFAULT NULL,
  `Height` float DEFAULT NULL,
  `Color` varchar(45) DEFAULT NULL,
  `Price` decimal(10,0) DEFAULT NULL,
  `Name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  CONSTRAINT `Product_ssd_ID` FOREIGN KEY (`ID`) REFERENCES `product` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=cp850;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ssd`
--

LOCK TABLES `ssd` WRITE;
/*!40000 ALTER TABLE `ssd` DISABLE KEYS */;
/*!40000 ALTER TABLE `ssd` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `supplier`
--

DROP TABLE IF EXISTS `supplier`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `supplier` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) DEFAULT NULL,
  `City` varchar(45) DEFAULT NULL,
  `Street` varchar(45) DEFAULT NULL,
  `Housenumber` varchar(45) DEFAULT NULL,
  `KvKNumber` int(11) DEFAULT NULL,
  `ShippingTime` varchar(45) DEFAULT NULL,
  `Email` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `supplier`
--

LOCK TABLES `supplier` WRITE;
/*!40000 ALTER TABLE `supplier` DISABLE KEYS */;
/*!40000 ALTER TABLE `supplier` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `wishlist`
--

DROP TABLE IF EXISTS `wishlist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `wishlist` (
  `ProductId` int(11) NOT NULL,
  `Quantity` int(11) DEFAULT NULL,
  `UserId` int(11) NOT NULL,
  `Price` decimal(10,0) DEFAULT NULL,
  `ProductName` varchar(45) DEFAULT NULL,
  `Imagepath` longtext,
  PRIMARY KEY (`ProductId`,`UserId`),
  KEY `FK_ram_name_idx` (`ProductName`),
  KEY `Product_Wishlist_Price_idx` (`Price`),
  CONSTRAINT `Product_Wishlist_ID` FOREIGN KEY (`ProductId`) REFERENCES `product` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `wishlist`
--

LOCK TABLES `wishlist` WRITE;
/*!40000 ALTER TABLE `wishlist` DISABLE KEYS */;
INSERT INTO `wishlist` VALUES (1,4,0,0,'string','~/images/ram/ram1.jpg'),(5,1,0,0,'string','~/images/ram/ram5.png'),(6,1,0,0,'string','~/images/ram/ram6.png'),(9,1,0,0,'string','~/images/ram/ram9.png');
/*!40000 ALTER TABLE `wishlist` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-01-08 13:23:09
