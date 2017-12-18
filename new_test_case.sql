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
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-12-18 14:48:46
