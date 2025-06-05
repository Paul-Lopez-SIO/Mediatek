-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : jeu. 05 juin 2025 à 17:41
-- Version du serveur : 9.1.0
-- Version de PHP : 8.3.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `mediatek`
--
CREATE DATABASE IF NOT EXISTS `mediatek` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `mediatek`;

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `idpersonnel` int NOT NULL,
  `datedebut` datetime NOT NULL,
  `datefin` datetime DEFAULT NULL,
  `idmotif` int NOT NULL,
  PRIMARY KEY (`idpersonnel`,`datedebut`),
  KEY `idmotif` (`idmotif`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`idpersonnel`, `datedebut`, `datefin`, `idmotif`) VALUES
(8, '2028-04-19 00:00:00', '2021-12-20 00:00:00', 1),
(5, '2028-04-22 00:00:00', '2028-08-16 00:00:00', 1),
(1, '2026-11-16 00:00:00', '2019-07-16 00:00:00', 1),
(0, '2006-12-19 00:00:00', '2029-03-21 00:00:00', 3),
(1, '2017-10-19 00:00:00', '2014-07-24 00:00:00', 2),
(7, '2025-05-15 00:00:00', '2025-05-31 00:00:00', 1),
(4, '2025-02-04 00:00:00', '2025-02-07 00:00:00', 1),
(1, '2025-11-15 00:00:00', '2006-07-15 00:00:00', 1),
(8, '2022-01-21 00:00:00', '2006-01-23 00:00:00', 2),
(2, '2014-02-19 00:00:00', '2028-05-20 00:00:00', 1),
(7, '2020-01-21 00:00:00', '2009-08-17 00:00:00', 1),
(7, '2009-09-20 00:00:00', '2021-12-23 00:00:00', 1),
(6, '2017-10-16 00:00:00', '2028-05-19 00:00:00', 2),
(9, '2025-03-11 00:00:00', '2025-06-05 00:00:00', 4),
(1, '2025-06-10 00:00:00', '2025-06-13 00:00:00', 1),
(3, '2006-01-18 00:00:00', '2014-12-22 00:00:00', 4),
(9, '2025-04-01 00:00:00', '2025-04-02 00:00:00', 2),
(0, '2003-09-19 00:00:00', '2025-12-23 00:00:00', 1),
(2, '2027-06-20 00:00:00', '2022-10-16 00:00:00', 4),
(4, '2001-08-16 00:00:00', '2001-08-24 00:00:00', 1),
(9, '2028-05-23 00:00:00', '2007-03-22 00:00:00', 3),
(7, '2023-07-23 00:00:00', '2026-11-22 00:00:00', 1),
(3, '2031-10-23 00:00:00', '2023-08-15 00:00:00', 4),
(7, '2031-03-20 00:00:00', '2011-07-17 00:00:00', 2),
(8, '2022-01-20 00:00:00', '2019-09-15 00:00:00', 4),
(5, '2027-01-22 00:00:00', '2001-09-20 00:00:00', 4),
(3, '2006-01-19 00:00:00', '2030-06-22 00:00:00', 1),
(3, '2030-01-24 00:00:00', '2008-09-17 00:00:00', 4),
(2, '2026-10-24 00:00:00', '2003-06-21 00:00:00', 4),
(5, '2003-03-19 00:00:00', '2020-05-15 00:00:00', 1),
(4, '2018-02-19 00:00:00', '2006-06-20 00:00:00', 3),
(6, '2022-11-22 00:00:00', '2011-01-20 00:00:00', 2),
(4, '2025-02-24 00:00:00', '2011-01-25 00:00:00', 1),
(7, '2009-04-18 00:00:00', '2024-09-21 00:00:00', 2),
(8, '2007-07-23 00:00:00', '2015-02-25 00:00:00', 3),
(6, '2029-07-16 00:00:00', '2017-06-22 00:00:00', 2),
(3, '2007-01-25 00:00:00', '2014-04-24 00:00:00', 1),
(6, '2014-10-15 00:00:00', '2017-05-25 00:00:00', 4),
(4, '2018-04-18 00:00:00', '2002-10-19 00:00:00', 1),
(2, '2025-08-24 00:00:00', '2021-09-21 00:00:00', 1),
(1, '2001-12-20 00:00:00', '2027-04-16 00:00:00', 2),
(7, '2005-10-21 00:00:00', '2004-06-24 00:00:00', 1),
(0, '2022-08-15 00:00:00', '2030-08-20 00:00:00', 2),
(2, '2019-01-20 00:00:00', '2009-10-21 00:00:00', 3),
(0, '2004-09-24 00:00:00', '2031-08-20 00:00:00', 1),
(4, '2001-02-25 00:00:00', '2012-05-25 00:00:00', 2),
(10, '2011-03-17 00:00:00', '2024-10-24 00:00:00', 1),
(9, '2029-03-23 00:00:00', '2029-07-15 00:00:00', 3),
(0, '2025-06-03 17:44:01', '2025-06-04 17:44:01', 2),
(9, '2025-06-02 17:45:33', '2025-06-03 17:45:33', 1),
(4, '2025-06-02 17:48:13', '2025-06-03 17:48:13', 1),
(4, '2025-06-05 17:49:26', '2025-06-05 17:49:26', 1),
(4, '2025-06-03 00:00:00', '2025-06-05 00:00:00', 1),
(4, '2025-06-02 00:00:00', '2025-06-03 00:00:00', 2),
(5, '2025-01-06 00:00:00', '2024-12-11 00:00:00', 1),
(1, '2025-06-05 00:00:00', '2025-06-06 00:00:00', 1);

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `idmotif` int NOT NULL AUTO_INCREMENT,
  `libelle` varchar(128) COLLATE utf8mb4_general_ci DEFAULT NULL,
  PRIMARY KEY (`idmotif`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`idmotif`, `libelle`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `idpersonnel` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `prenom` varchar(50) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `tel` varchar(15) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `mail` varchar(128) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `idservice` int NOT NULL,
  PRIMARY KEY (`idpersonnel`),
  KEY `idservice` (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`idpersonnel`, `nom`, `prenom`, `tel`, `mail`, `idservice`) VALUES
(1, 'Mcgowan', 'Nathaniel', '06 35 19 87 21', 'aliquam@protonmail.edu', 1),
(2, 'Mcintyre', 'Knox', '08 91 07 18 24', 'diam.lorem@icloud.com', 2),
(3, 'Alford', 'Raja', '07 38 94 74 24', 'tellus@icloud.org', 2),
(4, 'Hardin', 'Rajah', '07 97 14 49 75', 'adipiscing@icloud.edu', 2),
(5, 'Newman', 'Sophia', '04 62 82 43 32', 'sit.amet@outlook.com', 3),
(6, 'Wiley', 'Leroy', '04 93 67 58 72', 'neque.vitae@aol.net', 2),
(7, 'Saunders', 'Silas', '08 44 83 73 73', 'vitae.diam.proin@yahoo.couk', 3),
(8, 'Black', 'Sydnee', '05 51 28 92 63', 'ornare.tortor@outlook.edu', 1),
(9, 'Chavez', 'Colt', '04 36 08 68 33', 'gravida.mauris@hotmail.org', 2),
(10, 'Moody', 'Yuli', '03 72 38 38 21', 'quam@protonmail.couk', 1);

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(15) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `pwd` varchar(256) COLLATE utf8mb4_general_ci DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('admin', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `idservice` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(50) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `administratif` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`idservice`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`idservice`, `nom`, `administratif`) VALUES
(1, 'administratif', ''),
(2, 'médiation culturelle', ''),
(3, 'prêt', '');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
