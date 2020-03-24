-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: 18-Abr-2019 às 16:46
-- Versão do servidor: 5.7.19
-- PHP Version: 7.1.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";

--
-- Database: `aspnetcore_api`
--
CREATE DATABASE IF NOT EXISTS `aspnetcore_api` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `aspnetcore_api`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `person`
--

DROP TABLE IF EXISTS `person`;
CREATE TABLE IF NOT EXISTS `person` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `guid` varchar(36) NOT NULL,
  `name` varchar(100) NOT NULL,
  `address` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `person`
--

INSERT INTO `person` (`id`, `guid`, `name`, `address`) VALUES
(1, '78db7c58-5cb0-4004-b0f6-1cc7c8ffaaec', 'First Person', 'First Address'),
(2, 'e6afd4b9-ed00-4529-a3a8-ab56557ed16d', 'Second Person', 'Second Address'),
(3, '6238994c-ed18-49e8-85e2-2625b2c749f5', 'Third Person', 'Third Address');
COMMIT;
