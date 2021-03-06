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
INSERT INTO `product` (`ID`, `price`, `imagepath`, `stock`, `Brand`, `Supplier`, `ProductName`, `PurchasedQuantity`) VALUES (1,80,'~/images/ram/ram1.jpg',95,'Kingston','testsupplier','Kingston ValueRAM',5),(2,220,'~/images/ram/ram2.png',99,'Kingston','testsupplier','Kingston HyperX Fury 10',2),(3,120,'~/images/ram/ram3.png',100,'Kingston','testsupplier','Kingston 8GB DDR3',NULL),(4,180,'~/images/ram/ram4.png',100,'Kingston','testsupplier','Kingston HyperX Impact',NULL),(5,300,'~/images/ram/ram5.png',100,'Corsair','testsupplier','Corsair Vengeance LPX',NULL),(6,95,'~/images/ram/ram6.png',99,'Corsair','testsupplier','Corsair Vengeance LPX 8 GB',2),(7,70,'~/images/ram/ram7.png',100,'Corsair','testsupplier','Corsair 8 GB SODIMM DDR3',NULL),(8,89,'~/images/ram/ram8.png',100,'Crucial','testsupplier','Crucial 8 GB SODIMM DDR4',NULL),(9,110,'~/images/ram/ram9.png',100,'Crucial','testsupplier','Crucial Ballistix Sport LT',NULL),(10,235,'~/images/ram/ram10.png',100,'Crucial','testsupplier','Crucial Standard 16 GB SODIMM DDR3L',NULL);
/*!40000 ALTER TABLE `product` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-01-08 14:01:13
