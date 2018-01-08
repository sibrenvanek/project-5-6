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
INSERT INTO `ram` (`ID`, `Brand`, `CompositionOfMemory`, `MemoryType`, `Clockspeed`, `CASlatency`, `Voltage`, `MemoryModuleConnection`, `MemorySuitableFor`, `ImagePath`, `Name`, `Price`, `Ramsize`) VALUES (1,'Kingston','1x','DDR3',2133,15,1.2,1,'Desktop','~/images/ram/ram1.jpg','Kingston ValueRAM',50,4),(2,'Kingston','2x','DDR3',2350,15,1.5,1,'Desktop','~/images/ram/ram2.png','Kingston HyperX Fury 10',220,16),(3,'Kingston','1x','DDR3',2200,15,1.2,1,'Desktop','~/images/ram/ram3.png','Kingston 8GB DDR3',80,8),(4,'Kingston','2x','DDR3',2180,15,1.25,1,'Desktop','~/images/ram/ram4.png','Kingston HyperX Impact',180,16),(5,'Corsair','2x','DDR4',2230,15,1.4,1,'Desktop','~/images/ram/ram5.png','Corsair Vengeance LPX',300,16),(6,'Corsair','2x','DDR3',2300,15,1.5,1,'Desktop','~/images/ram/ram6.png','Corsair Vengeance LPX 8 GB',95,8),(7,'Corsair','2x','DDR3',2250,15,1.2,1,'Desktop','~/images/ram/ram7.png','Corsair 8 GB SODIMM DDR3',70,8),(8,'Crucial','1x','DDR4',1900,15,1.35,1,'Laptop','~/images/ram/ram8.png','Crucial 8 GB SODIMM DDR4',89,8),(9,'Crucial','2x','DDR4',2190,15,1.2,1,'Desktop','~/images/ram/ram9.png','Crucial Ballistix Sport LT',140,8),(10,'Crucial','2x','DDR3',1600,15,1.2,1,'Desktop','~/images/ram/ram10.png','Crucial Standard 16 GB SODIMM DDR3L',235,16);
/*!40000 ALTER TABLE `ram` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-01-08 14:01:15
