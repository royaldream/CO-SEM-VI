-- phpMyAdmin SQL Dump
-- version 3.1.3.1
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Mar 13, 2019 at 07:56 AM
-- Server version: 5.1.33
-- PHP Version: 5.2.9-2

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `foodclub`
--

-- --------------------------------------------------------

--
-- Table structure for table `cart`
--

CREATE TABLE IF NOT EXISTS `cart` (
  `uid` int(10) NOT NULL,
  `fids` varchar(255) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `cart`
--


-- --------------------------------------------------------

--
-- Table structure for table `food`
--

CREATE TABLE IF NOT EXISTS `food` (
  `fid` int(10) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `ingredients` varchar(255) NOT NULL,
  `cost` varchar(255) NOT NULL,
  `url` varchar(255) NOT NULL,
  PRIMARY KEY (`fid`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `food`
--

INSERT INTO `food` (`fid`, `name`, `ingredients`, `cost`, `url`) VALUES
(1, 'Pizza', '1,2,3,3', '200', '1.jpg'),
(2, 'burger', 'veg', '200', '2.jpg'),
(3, 'sandwich', 'bkj', '100', '3.jpg'),
(4, 'Dosa', 'panir', '250', '4.jpeg');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE IF NOT EXISTS `user` (
  `uid` int(10) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `emailid` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  PRIMARY KEY (`uid`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=9 ;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`uid`, `name`, `emailid`, `password`) VALUES
(1, 'keval', '1', '2'),
(2, 'keval', '1', '2'),
(3, 'keval', '1', '2'),
(4, 'keval', '1', '2'),
(5, 'keval', '1', '2'),
(6, 'keval', '1', '2'),
(7, 't', 't', 't'),
(8, 'keval', 'kevalnavadiya39@gmail.com', '123');
