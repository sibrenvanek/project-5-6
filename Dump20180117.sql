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
INSERT INTO `product` VALUES (1,50,'~/images/ram/ram1.jpg',69,'Kingston','testsupplier','Kingston ValueRAM',31),(2,220,'~/images/ram/ram2.png',61,'Kingston','testsupplier','Kingston HyperX Fury 10',40),(3,120,'~/images/ram/ram3.png',95,'Kingston','testsupplier','Kingston 8GB DDR3',6),(4,180,'~/images/ram/ram4.png',96,'Kingston','testsupplier','Kingston HyperX Impact',5),(5,300,'~/images/ram/ram5.png',91,'Corsair','testsupplier','Corsair Vengeance LPX',10),(6,95,'~/images/ram/ram6.png',96,'Corsair','testsupplier','Corsair Vengeance LPX 8 GB',5),(7,70,'~/images/ram/ram7.png',94,'Corsair','testsupplier','Corsair 8 GB SODIMM DDR3',7),(8,89,'~/images/ram/ram8.png',93,'Crucial','testsupplier','Crucial 8 GB SODIMM DDR4',8),(9,110,'~/images/ram/ram9.png',99,'Crucial','testsupplier','Crucial Ballistix Sport LT',2),(10,235,'~/images/ram/ram10.png',95,'Crucial','testsupplier','Crucial Standard 16 GB SODIMM DDR3L',6);
/*!40000 ALTER TABLE `product` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `purchasehistory`
--

DROP TABLE IF EXISTS `purchasehistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `purchasehistory` (
  `ProductID` int(11) NOT NULL,
  `UserID` varchar(45) NOT NULL,
  `PurchaseDate` datetime NOT NULL,
  `Quantity` int(11) DEFAULT NULL,
  `ProductName` varchar(45) DEFAULT NULL,
  `imagepath` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ProductID`,`UserID`,`PurchaseDate`),
  CONSTRAINT `Products_Purchasehistory_ID` FOREIGN KEY (`ProductID`) REFERENCES `product` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `purchasehistory`
--

LOCK TABLES `purchasehistory` WRITE;
/*!40000 ALTER TABLE `purchasehistory` DISABLE KEYS */;
INSERT INTO `purchasehistory` VALUES (1,'0','2018-01-17 12:25:39',1,'Kingston ValueRAM','~/images/ram/ram1.jpg'),(1,'0','2018-01-17 14:08:32',1,'Kingston ValueRAM','~/images/ram/ram1.jpg'),(1,'0','2018-01-17 14:43:02',1,'Kingston ValueRAM','~/images/ram/ram1.jpg'),(1,'0','2018-01-17 15:36:20',1,'Kingston ValueRAM','~/images/ram/ram1.jpg'),(1,'14f0fb9a-8502-4339-8693-54aaf002b267','2018-01-17 13:35:52',1,'Kingston ValueRAM','~/images/ram/ram1.jpg'),(1,'5216cca2-62a7-465e-ba5f-5c96fd73c964','2018-01-17 13:47:07',1,'Kingston ValueRAM','~/images/ram/ram1.jpg'),(1,'5216cca2-62a7-465e-ba5f-5c96fd73c964','2018-01-17 13:48:58',5,'Kingston ValueRAM','~/images/ram/ram1.jpg'),(1,'d4308ef9-8966-4b33-bd8e-177e52fb2ef4','2018-01-15 15:01:56',3,'Kingston ValueRAM','~/images/ram/ram1.jpg'),(1,'d4308ef9-8966-4b33-bd8e-177e52fb2ef4','2018-01-15 15:02:57',1,'Kingston ValueRAM','~/images/ram/ram1.jpg'),(1,'d4308ef9-8966-4b33-bd8e-177e52fb2ef4','2018-01-16 13:20:45',1,'Kingston ValueRAM','~/images/ram/ram1.jpg'),(2,'0','2018-01-16 13:13:44',1,'Kingston HyperX Fury 10','~/images/ram/ram2.png'),(2,'0','2018-01-16 13:15:46',1,'Kingston HyperX Fury 10','~/images/ram/ram2.png'),(2,'0','2018-01-17 15:36:20',1,'Kingston HyperX Fury 10','~/images/ram/ram2.png'),(2,'5216cca2-62a7-465e-ba5f-5c96fd73c964','2018-01-17 13:48:58',15,'Kingston HyperX Fury 10','~/images/ram/ram2.png'),(2,'5216cca2-62a7-465e-ba5f-5c96fd73c964','2018-01-17 13:49:51',14,'Kingston HyperX Fury 10','~/images/ram/ram2.png'),(2,'86b06f10-82de-4a2c-9581-772a0836a1e9','2018-01-16 15:45:55',1,'Kingston HyperX Fury 10','~/images/ram/ram2.png'),(2,'ad7c3958-25ab-4e99-ac80-d93e55b0acd2','2018-01-16 12:36:28',1,'Kingston HyperX Fury 10','~/images/ram/ram2.png'),(2,'d015aeb6-bc8a-42c1-820b-b441a765358c','2018-01-16 11:25:30',1,'Kingston HyperX Fury 10','~/images/ram/ram2.png'),(2,'d015aeb6-bc8a-42c1-820b-b441a765358c','2018-01-16 13:23:27',1,'Kingston HyperX Fury 10','~/images/ram/ram2.png'),(2,'d015aeb6-bc8a-42c1-820b-b441a765358c','2018-01-17 14:54:31',1,'Kingston HyperX Fury 10','~/images/ram/ram2.png'),(2,'d4308ef9-8966-4b33-bd8e-177e52fb2ef4','2018-01-15 15:01:56',1,'Kingston HyperX Fury 10','~/images/ram/ram2.png'),(3,'0','2018-01-17 11:47:55',1,'Kingston 8GB DDR3','~/images/ram/ram3.png'),(3,'0','2018-01-17 11:56:48',1,'Kingston 8GB DDR3','~/images/ram/ram3.png'),(3,'0','2018-01-17 12:25:40',1,'Kingston 8GB DDR3','~/images/ram/ram3.png'),(3,'0','2018-01-17 13:33:54',1,'Kingston 8GB DDR3','~/images/ram/ram3.png'),(3,'5216cca2-62a7-465e-ba5f-5c96fd73c964','2018-01-17 13:49:51',1,'Kingston 8GB DDR3','~/images/ram/ram3.png'),(4,'0','2018-01-17 15:36:20',1,'Kingston HyperX Impact','~/images/ram/ram4.png'),(4,'2b4ee1cc-9f89-415c-bf86-43d9b44ed7af','2018-01-17 15:33:16',1,'Kingston HyperX Impact','~/images/ram/ram4.png'),(4,'5216cca2-62a7-465e-ba5f-5c96fd73c964','2018-01-17 13:47:07',1,'Kingston HyperX Impact','~/images/ram/ram4.png'),(4,'fbd4502d-2e38-4c75-b4c1-aebae0673b17','2018-01-17 14:41:54',1,'Kingston HyperX Impact','~/images/ram/ram4.png'),(5,'0','2018-01-17 14:08:32',2,'Corsair Vengeance LPX','~/images/ram/ram5.png'),(5,'0','2018-01-17 14:43:02',1,'Corsair Vengeance LPX','~/images/ram/ram5.png'),(5,'72c6f763-4842-4b40-800f-72ed05cda04c','2018-01-17 14:09:33',1,'Corsair Vengeance LPX','~/images/ram/ram5.png'),(6,'0a55e941-32b1-4d22-8638-4156b4e7ffe7','2018-01-17 11:57:50',1,'Corsair Vengeance LPX 8 GB','~/images/ram/ram6.png'),(6,'a8d83b58-718b-4d3a-9e76-3afb754a1fcc','2018-01-17 11:49:03',2,'Corsair Vengeance LPX 8 GB','~/images/ram/ram6.png'),(8,'0','2018-01-17 14:08:33',1,'Crucial 8 GB SODIMM DDR4','~/images/ram/ram8.png'),(9,'0','2018-01-17 13:44:01',1,'Crucial Ballistix Sport LT','~/images/ram/ram9.png'),(10,'0','2018-01-17 15:36:20',1,'Crucial Standard 16 GB SODIMM DDR3L','~/images/ram/ram10.png');
/*!40000 ALTER TABLE `purchasehistory` ENABLE KEYS */;
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
  `minprice` int(11) DEFAULT NULL,
  `maxprice` int(11) DEFAULT NULL,
  `minsize` int(11) DEFAULT NULL,
  `maxsize` int(11) DEFAULT NULL,
  `ramtype` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ID`),
  CONSTRAINT `Product_Ram_ID` FOREIGN KEY (`ID`) REFERENCES `product` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ram`
--

LOCK TABLES `ram` WRITE;
/*!40000 ALTER TABLE `ram` DISABLE KEYS */;
INSERT INTO `ram` VALUES (1,'Kingston','1x','DDR3',2133,15,12,1,'Desktop','~/images/ram/ram1.jpg','Kingston ValueRAM',50,4,NULL,NULL,NULL,NULL,NULL),(2,'Kingston','2x','DDR3',2350,15,1.5,1,'Desktop','~/images/ram/ram2.png','Kingston HyperX Fury 10',220,16,NULL,NULL,NULL,NULL,NULL),(3,'Kingston','1x','DDR3',2200,15,1.2,1,'Desktop','~/images/ram/ram3.png','Kingston 8GB DDR3',80,8,NULL,NULL,NULL,NULL,NULL),(4,'Kingston','2x','DDR3',2180,15,1.25,1,'Desktop','~/images/ram/ram4.png','Kingston HyperX Impact',180,16,NULL,NULL,NULL,NULL,NULL),(5,'Corsair','2x','DDR4',2230,15,1.4,1,'Desktop','~/images/ram/ram5.png','Corsair Vengeance LPX',300,16,NULL,NULL,NULL,NULL,NULL),(6,'Corsair','2x','DDR3',2300,15,1.5,1,'Desktop','~/images/ram/ram6.png','Corsair Vengeance LPX 8 GB',95,8,NULL,NULL,NULL,NULL,NULL),(7,'Corsair','2x','DDR3',2250,15,1.2,1,'Desktop','~/images/ram/ram7.png','Corsair 8 GB SODIMM DDR3',70,8,NULL,NULL,NULL,NULL,NULL),(8,'Crucial','1x','DDR4',1900,15,1.35,1,'Laptop','~/images/ram/ram8.png','Crucial 8 GB SODIMM DDR4',89,8,NULL,NULL,NULL,NULL,NULL),(9,'Crucial','2x','DDR4',2190,15,1.2,1,'Desktop','~/images/ram/ram9.png','Crucial Ballistix Sport LT',140,8,NULL,NULL,NULL,NULL,NULL),(10,'Crucial','2x','DDR3',1600,15,1.2,1,'Desktop','~/images/ram/ram10.png','Crucial Standard 16 GB SODIMM DDR3L',235,16,NULL,NULL,NULL,NULL,NULL);
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
  `UserId` varchar(45) NOT NULL,
  `Quantity` int(11) DEFAULT NULL,
  `Price` decimal(10,0) DEFAULT NULL,
  `ProductName` varchar(45) DEFAULT NULL,
  `Imagepath` longtext,
  `email` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ProductId`,`UserId`),
  CONSTRAINT `Product_Shoppingcart_ID` FOREIGN KEY (`ProductId`) REFERENCES `product` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `shoppingcart`
--

LOCK TABLES `shoppingcart` WRITE;
/*!40000 ALTER TABLE `shoppingcart` DISABLE KEYS */;
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
  `UserId` varchar(45) NOT NULL,
  `Quantity` int(11) DEFAULT NULL,
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
INSERT INTO `wishlist` VALUES (2,'d015aeb6-bc8a-42c1-820b-b441a765358c',1,220,'Kingston HyperX Fury 10','~/images/ram/ram2.png'),(4,'2b4ee1cc-9f89-415c-bf86-43d9b44ed7af',1,180,'Kingston HyperX Impact','~/images/ram/ram4.png');
/*!40000 ALTER TABLE `wishlist` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'new_test'
--

--
-- Dumping routines for database 'new_test'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-01-17 18:34:21
