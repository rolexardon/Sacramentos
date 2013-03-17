CREATE DATABASE  IF NOT EXISTS `bd_iglesia` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `bd_iglesia`;
-- MySQL dump 10.13  Distrib 5.5.16, for Win32 (x86)
--
-- Host: localhost    Database: bd_iglesia
-- ------------------------------------------------------
-- Server version	5.5.27-log

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
-- Table structure for table `padrinos_bautizo`
--

DROP TABLE IF EXISTS `padrinos_bautizo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `padrinos_bautizo` (
  `codigo` int(11) NOT NULL AUTO_INCREMENT,
  `codigo_bau` int(11) NOT NULL,
  `codigo_per` int(11) NOT NULL,
  PRIMARY KEY (`codigo`),
  KEY `bautizo_padbaufk_idx` (`codigo_bau`),
  KEY `persona_padbaufk_idx` (`codigo_per`),
  CONSTRAINT `bautizo_padbaufk` FOREIGN KEY (`codigo_bau`) REFERENCES `bautizos` (`codigo`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `persona_padbaufk` FOREIGN KEY (`codigo_per`) REFERENCES `personas` (`codigo`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `padrinos_bautizo`
--

LOCK TABLES `padrinos_bautizo` WRITE;
/*!40000 ALTER TABLE `padrinos_bautizo` DISABLE KEYS */;
/*!40000 ALTER TABLE `padrinos_bautizo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `testigos`
--

DROP TABLE IF EXISTS `testigos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `testigos` (
  `codigo` int(11) NOT NULL AUTO_INCREMENT,
  `codigo_per` int(11) NOT NULL,
  `codigo_mat` int(11) NOT NULL,
  PRIMARY KEY (`codigo`),
  KEY `testigo_idx` (`codigo_per`),
  KEY `codigo_fk_idx` (`codigo_mat`),
  CONSTRAINT `matrimonio_fk` FOREIGN KEY (`codigo_mat`) REFERENCES `matrimonios` (`codigo`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `persona_fk` FOREIGN KEY (`codigo_per`) REFERENCES `personas` (`codigo`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `testigos`
--

LOCK TABLES `testigos` WRITE;
/*!40000 ALTER TABLE `testigos` DISABLE KEYS */;
/*!40000 ALTER TABLE `testigos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `padrinos_confirma`
--

DROP TABLE IF EXISTS `padrinos_confirma`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `padrinos_confirma` (
  `codigo` int(11) NOT NULL AUTO_INCREMENT,
  `codigo_conf` int(11) NOT NULL,
  `codigo_per` int(11) NOT NULL,
  PRIMARY KEY (`codigo`),
  KEY `confima_padconffk_idx` (`codigo_conf`),
  KEY `persona_padconffk_idx` (`codigo_per`),
  CONSTRAINT `confima_padconffk` FOREIGN KEY (`codigo_conf`) REFERENCES `confirmas` (`codigo`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `persona_padconffk` FOREIGN KEY (`codigo_per`) REFERENCES `personas` (`codigo`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `padrinos_confirma`
--

LOCK TABLES `padrinos_confirma` WRITE;
/*!40000 ALTER TABLE `padrinos_confirma` DISABLE KEYS */;
/*!40000 ALTER TABLE `padrinos_confirma` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `matrimonios`
--

DROP TABLE IF EXISTS `matrimonios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `matrimonios` (
  `codigo` int(11) NOT NULL AUTO_INCREMENT,
  `parroquia` int(11) NOT NULL,
  `sacerdote` int(11) NOT NULL,
  `esposo` int(11) NOT NULL,
  `esposa` int(11) NOT NULL,
  `fecha` datetime NOT NULL,
  PRIMARY KEY (`codigo`),
  KEY `parroquia_idx` (`parroquia`),
  KEY `esposo_idx` (`esposo`),
  KEY `esposa_idx` (`esposa`),
  KEY `sacerdote_fk_idx` (`sacerdote`),
  CONSTRAINT `esposa` FOREIGN KEY (`esposa`) REFERENCES `personas` (`codigo`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `esposo` FOREIGN KEY (`esposo`) REFERENCES `personas` (`codigo`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `parroquia_fk` FOREIGN KEY (`parroquia`) REFERENCES `parroquias` (`codigo`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `sacerdote_fk1` FOREIGN KEY (`sacerdote`) REFERENCES `sacerdotes` (`codigo`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `matrimonios`
--

LOCK TABLES `matrimonios` WRITE;
/*!40000 ALTER TABLE `matrimonios` DISABLE KEYS */;
/*!40000 ALTER TABLE `matrimonios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sacerdotes`
--

DROP TABLE IF EXISTS `sacerdotes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sacerdotes` (
  `codigo` int(11) NOT NULL AUTO_INCREMENT,
  `id` varchar(20) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `nacimiento` datetime NOT NULL,
  `telefono` int(11) DEFAULT NULL,
  `correo` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sacerdotes`
--

LOCK TABLES `sacerdotes` WRITE;
/*!40000 ALTER TABLE `sacerdotes` DISABLE KEYS */;
/*!40000 ALTER TABLE `sacerdotes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `personas`
--

DROP TABLE IF EXISTS `personas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `personas` (
  `codigo` int(11) NOT NULL AUTO_INCREMENT,
  `id` varchar(20) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `nacimiento` datetime NOT NULL,
  `lugar_nac` varchar(100) NOT NULL,
  `telefono` int(11) DEFAULT NULL,
  `correo` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `personas`
--

LOCK TABLES `personas` WRITE;
/*!40000 ALTER TABLE `personas` DISABLE KEYS */;
INSERT INTO `personas` VALUES (1,'080119823478','Carlos Giron','2013-01-15 00:00:00','Valle',44444,'g@g.com'),(2,'44e5','gbdgb','2013-01-10 00:00:00','df',54564,'fgbdfgb'),(3,'44e5','gbdgb','2013-01-10 00:00:00','df',54564,'fgbdfgb'),(4,'44e5','gbdgb','2013-01-10 00:00:00','df',54564,'fgbdfgb'),(5,'sgbfdgb','fdgbdfgb','2013-01-25 00:00:00','dfgbdfgb',456456,'r@r.com');
/*!40000 ALTER TABLE `personas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `confirmas`
--

DROP TABLE IF EXISTS `confirmas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `confirmas` (
  `codigo` int(11) NOT NULL AUTO_INCREMENT,
  `fecha_confi` datetime NOT NULL,
  `parroquia` int(11) NOT NULL,
  `sacerdote` int(11) NOT NULL,
  `confirmado` int(11) NOT NULL,
  `padre` int(11) DEFAULT NULL,
  `madre` int(11) DEFAULT NULL,
  `observacion` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`codigo`),
  KEY `sacerdote_fk_idx` (`sacerdote`),
  KEY `confirmado_idx` (`confirmado`),
  KEY `parroquia_idx` (`parroquia`),
  KEY `padre_idx` (`padre`),
  KEY `madre_con_idx` (`madre`),
  CONSTRAINT `confirmado_confk` FOREIGN KEY (`confirmado`) REFERENCES `personas` (`codigo`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `madre_confk` FOREIGN KEY (`madre`) REFERENCES `personas` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `padre_confk` FOREIGN KEY (`padre`) REFERENCES `personas` (`codigo`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `parroquia_confk` FOREIGN KEY (`parroquia`) REFERENCES `parroquias` (`codigo`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `sacerdote_confk` FOREIGN KEY (`sacerdote`) REFERENCES `sacerdotes` (`codigo`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `confirmas`
--

LOCK TABLES `confirmas` WRITE;
/*!40000 ALTER TABLE `confirmas` DISABLE KEYS */;
/*!40000 ALTER TABLE `confirmas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bautizos`
--

DROP TABLE IF EXISTS `bautizos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `bautizos` (
  `codigo` int(11) NOT NULL AUTO_INCREMENT,
  `fecha_bau` datetime NOT NULL,
  `parroquia` int(11) NOT NULL,
  `sacerdote` int(11) NOT NULL,
  `bautizado` int(11) NOT NULL,
  `padre` int(11) DEFAULT NULL,
  `madre` int(11) DEFAULT NULL,
  `observacion` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`codigo`),
  KEY `parroquia_baufk_idx` (`parroquia`),
  KEY `sacerdote_baufk_idx` (`sacerdote`),
  KEY `bautizado_baufk_idx` (`bautizado`),
  KEY `padre_baufk_idx` (`padre`),
  KEY `madre_baufk_idx` (`madre`),
  CONSTRAINT `bautizado_baufk` FOREIGN KEY (`bautizado`) REFERENCES `personas` (`codigo`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `madre_baufk` FOREIGN KEY (`madre`) REFERENCES `personas` (`codigo`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `padre_baufk` FOREIGN KEY (`padre`) REFERENCES `personas` (`codigo`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `parroquia_baufk` FOREIGN KEY (`parroquia`) REFERENCES `parroquias` (`codigo`) ON DELETE NO ACTION ON UPDATE CASCADE,
  CONSTRAINT `sacerdote_baufk` FOREIGN KEY (`sacerdote`) REFERENCES `sacerdotes` (`codigo`) ON DELETE NO ACTION ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bautizos`
--

LOCK TABLES `bautizos` WRITE;
/*!40000 ALTER TABLE `bautizos` DISABLE KEYS */;
/*!40000 ALTER TABLE `bautizos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `parroquias`
--

DROP TABLE IF EXISTS `parroquias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `parroquias` (
  `codigo` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) NOT NULL,
  `direccion` varchar(150) NOT NULL,
  `telefono` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `parroquias`
--

LOCK TABLES `parroquias` WRITE;
/*!40000 ALTER TABLE `parroquias` DISABLE KEYS */;
/*!40000 ALTER TABLE `parroquias` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2013-02-07 15:34:31
