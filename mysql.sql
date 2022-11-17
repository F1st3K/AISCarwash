CREATE DATABASE  IF NOT EXISTS `carwah_shema` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `carwah_shema`;
-- MySQL dump 10.13  Distrib 8.0.30, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: carwah_shema
-- ------------------------------------------------------
-- Server version	5.7.38

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `listclients`
--

DROP TABLE IF EXISTS `listclients`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `listclients` (
  `idClient` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(15) NOT NULL,
  `Surname` varchar(15) NOT NULL,
  `Patronymic` varchar(15) DEFAULT NULL,
  `ModelCar` varchar(25) NOT NULL,
  PRIMARY KEY (`idClient`)
) ENGINE=InnoDB AUTO_INCREMENT=85 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `listclients`
--

LOCK TABLES `listclients` WRITE;
/*!40000 ALTER TABLE `listclients` DISABLE KEYS */;
INSERT INTO `listclients` VALUES (25,'Андреева','Полина','Ильинична','Tesla'),(26,'Фомина','Татьяна','Николаевна','Tesla'),(27,'Тимофеев','Максим','Степанович','Tesla'),(28,'Устинова','Ксения','Вячеславовна','Tesla'),(29,'Головин','Роман','Артёмович','Tesla'),(30,'Смирнова','Алина','Давидовна','Tesla'),(31,'Винокуров','Арсений','Михайлович','Tesla'),(32,'Зайцева','София','Данииловна','Tesla'),(33,'Тарасов','Александр','Каримович','Tesla'),(34,'Данилова','Алиса','Ильинична','Tesla'),(35,'Гришин','Артём','Романович','Tesla'),(36,'Демидов','Дмитрий','Львович','Tesla'),(37,'Овчинникова','Виктория','Андреевна','Tesla'),(38,'Абрамова','Александра','Степановна','Tesla'),(39,'Михайлов','Иван','Максимович','Tesla');
/*!40000 ALTER TABLE `listclients` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `listservices`
--

DROP TABLE IF EXISTS `listservices`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `listservices` (
  `idService` int(11) NOT NULL AUTO_INCREMENT,
  `ServiceName` varchar(45) NOT NULL,
  `ServicePrice` int(11) NOT NULL,
  PRIMARY KEY (`idService`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `listservices`
--

LOCK TABLES `listservices` WRITE;
/*!40000 ALTER TABLE `listservices` DISABLE KEYS */;
INSERT INTO `listservices` VALUES (1,'Техническая мойка',860),(2,'Стандартная мойка',1340),(3,'Полная мойка',700),(4,'Мойка моторного отсека',950),(5,'Багажник мойка',800),(6,'Чистка стекол',1460),(7,'Полировка пластика',570),(8,'Полировка кожи',700);
/*!40000 ALTER TABLE `listservices` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `listwashers`
--

DROP TABLE IF EXISTS `listwashers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `listwashers` (
  `idWasher` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(15) NOT NULL,
  `Surname` varchar(15) NOT NULL,
  `Patronymic` varchar(15) DEFAULT NULL,
  `DateOB` date NOT NULL,
  PRIMARY KEY (`idWasher`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `listwashers`
--

LOCK TABLES `listwashers` WRITE;
/*!40000 ALTER TABLE `listwashers` DISABLE KEYS */;
INSERT INTO `listwashers` VALUES (1,'Шестаков','Андрей','Богданович','2018-08-20'),(2,'Морозов','Тимур','Кириллович','2005-01-20'),(3,'Шестаков','Андрей','Богданович','2012-12-20'),(4,'Высоцкий','Борис','Давидович','1971-03-17'),(5,'Комиссаров','Михаил','Александрович','1977-07-14'),(6,'Круглов','Макар','Александрович','1984-01-10'),(7,'Кондрашов','Лев','Дмитриевич','1994-08-14'),(8,'Романов','Владислав','Максимович','1975-09-27'),(9,'Борисов','Савва','Иванович','1970-07-24'),(10,'Корнев','Георгий','Вадимович','1989-07-30'),(11,'Щеглов','Михаил','Григорьевич','1983-08-19'),(12,'Виноградов','Артём','Владимирович','2003-12-13'),(13,'Константинов','Тимофей','Леонидович','1970-01-13'),(14,'Волков','Михаил','Кириллович','1994-03-13'),(15,'Архипов','Александр','Алексеевич','2005-01-16');
/*!40000 ALTER TABLE `listwashers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `idUsers` int(11) NOT NULL AUTO_INCREMENT,
  `FullName` varchar(45) NOT NULL,
  `login` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  PRIMARY KEY (`idUsers`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'Иванов И.А.','admin','admin'),(2,'Костин Н.К.','niki','niki');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-11-17 18:34:58
