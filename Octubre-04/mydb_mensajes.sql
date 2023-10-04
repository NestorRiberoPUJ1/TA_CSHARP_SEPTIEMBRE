-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: mydb
-- ------------------------------------------------------
-- Server version	8.0.30

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
-- Table structure for table `mensajes`
--

DROP TABLE IF EXISTS `mensajes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mensajes` (
  `id` int NOT NULL AUTO_INCREMENT,
  `tipo` enum('texto','voz') NOT NULL,
  `contenido` text NOT NULL,
  `multimedio` varchar(128) NOT NULL,
  `created_at` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `remitente_id` int NOT NULL,
  `destinatario_usuario_id` int DEFAULT NULL,
  `destinatario_grupo_id` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_mensajes_usuarios_idx` (`remitente_id`),
  KEY `fk_mensajes_usuarios1_idx` (`destinatario_usuario_id`),
  KEY `fk_mensajes_grupos1_idx` (`destinatario_grupo_id`),
  CONSTRAINT `fk_mensajes_grupos1` FOREIGN KEY (`destinatario_grupo_id`) REFERENCES `grupos` (`id`),
  CONSTRAINT `fk_mensajes_usuarios` FOREIGN KEY (`remitente_id`) REFERENCES `usuarios` (`id`),
  CONSTRAINT `fk_mensajes_usuarios1` FOREIGN KEY (`destinatario_usuario_id`) REFERENCES `usuarios` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mensajes`
--

LOCK TABLES `mensajes` WRITE;
/*!40000 ALTER TABLE `mensajes` DISABLE KEYS */;
INSERT INTO `mensajes` VALUES (1,'texto','hola sergio','mt.algo','2023-10-04 11:16:26','2023-10-04 11:16:26',5,6,NULL),(2,'voz','todo bien','mv.wav','2023-10-04 11:17:05','2023-10-04 11:17:05',6,5,NULL),(3,'voz','Qué tal la carrera?','mt.al','2023-10-04 11:18:33','2023-10-04 11:18:33',5,6,NULL),(4,'texto','Hola todos','dwa','2023-10-04 11:49:13','2023-10-04 11:49:13',1,NULL,1),(5,'texto','Hola Nestor','adw','2023-10-04 11:49:13','2023-10-04 11:49:13',5,NULL,1),(6,'texto','Practicando para qatar','dawdw','2023-10-04 11:49:13','2023-10-04 11:49:13',6,NULL,1),(7,'voz','hola tim','123ad','2023-10-04 11:51:22','2023-10-04 11:51:22',6,7,NULL),(8,'voz','bien sergio y tu?','132','2023-10-04 11:51:22','2023-10-04 11:51:22',7,6,NULL),(9,'voz','muy bien, viendo como mejorar mis tiempos','fiaw','2023-10-04 11:51:22','2023-10-04 11:51:22',6,7,NULL),(10,'voz','que genial, ya quiero ver la carrera','faio','2023-10-04 11:51:22','2023-10-04 11:51:22',7,6,NULL);
/*!40000 ALTER TABLE `mensajes` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-10-04 11:53:14
