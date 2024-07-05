-- phpMyAdmin SQL Dump
-- version 3.4.5
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Feb 02, 2017 at 03:51 PM
-- Server version: 5.5.16
-- PHP Version: 5.3.8

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `db`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE IF NOT EXISTS `admin` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=54 ;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`id`, `username`, `password`) VALUES
(1, 'Admin', 'Admin');

-- --------------------------------------------------------

--
-- Table structure for table `faculty`
--

CREATE TABLE IF NOT EXISTS `faculty` (
  `employeenum` int(11) NOT NULL,
  `name` text NOT NULL,
  `email` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `faculty`
--

INSERT INTO `faculty` (`employeenum`, `name`, `email`) VALUES
(234343, 'Rizal, Pot Nam', 'rizal123@yahoo.com');

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

CREATE TABLE IF NOT EXISTS `student` (
  `studentno` int(11) NOT NULL,
  `name` text NOT NULL,
  `email` varchar(40) NOT NULL,
  `course` text NOT NULL,
  `year` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `student`
--

INSERT INTO `student` (`studentno`, `name`, `email`, `course`, `year`) VALUES
(2024565, 'Guevarra, Julius N.', 'yoyoyo@yahoo.com', 'BSIT', '1st Year'),
(123, 'Goryo, Jordan Haha', 'gordon@yahoo.com', 'BSIS', '1st Year'),
(0, 'Downey, Robert James', 'james@yahoo.com', 'BSIT', '1st Year'),
(555, 'Hampaslupa, Dimagiba Neverbroke', 'hampaslupa@yahoo.com', 'BSIS', '3rd Year');

-- --------------------------------------------------------

--
-- Table structure for table `subject`
--

CREATE TABLE IF NOT EXISTS `subject` (
  `studnum` int(11) NOT NULL,
  `studname` text NOT NULL,
  `course` text NOT NULL,
  `year` varchar(20) NOT NULL,
  `subjectcode` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `subject`
--

INSERT INTO `subject` (`studnum`, `studname`, `course`, `year`, `subjectcode`) VALUES
(2024565, 'Guevarra, Julius N.', 'BSIT', '1st Year', 'Math 115'),
(2024565, 'Guevarra, Julius N.', 'BSIT', '1st Year', 'CF 113'),
(2024565, 'Guevarra, Julius N.', 'BSIT', '1st Year', 'OP 113'),
(1, 'Zablan, Ryan Jay L.', 'BSIT', '1st Year', 'Math 115'),
(1, 'Zablan, Ryan Jay L.', 'BSIT', '1st Year', 'OP 113'),
(2024565, 'Guevarra, Julius N.', 'BSIT', '1st Year', 'Soc 213'),
(111, 'Maglasang, John Rowin A.', 'BSIS', '1st Year', 'Soc 213'),
(1, 'Zablan, Ryan Jay L.', 'BSIT', '1st Year', 'Soc 213'),
(12, 'Harley, Quinn M.', 'BSIS', '1st Year', 'Soc 213'),
(2024565, 'Guevarra, Julius N.', 'BSIT', '1st Year', 'Prog 113'),
(2024565, 'Guevarra, Julius N.', 'BSIT', '1st Year', 'English 113'),
(2024565, 'Guevarra, Julius N.', 'BSIT', '1st Year', 'Filipino 113c'),
(2024565, 'Guevarra, Julius N.', 'BSIT', '1st Year', 'Hum 113'),
(2024565, 'Guevarra, Julius N.', 'BSIT', '1st Year', 'PE 112'),
(2024565, 'Guevarra, Julius N.', 'BSIT', '1st Year', 'NSTP 1'),
(123, 'Goryo, Jordan Haha', 'BSIS', '1st Year', 'ISM 1'),
(123, 'Goryo, Jordan Haha', 'BSIS', '1st Year', 'ISM 2'),
(123, 'Goryo, Jordan Haha', 'BSIS', '1st Year', 'PerDev 113'),
(123, 'Goryo, Jordan Haha', 'BSIS', '1st Year', 'Math 115'),
(123, 'Goryo, Jordan Haha', 'BSIS', '1st Year', 'English 113'),
(123, 'Goryo, Jordan Haha', 'BSIS', '1st Year', 'Filipino 113c'),
(123, 'Goryo, Jordan Haha', 'BSIS', '1st Year', 'Hum 113'),
(123, 'Goryo, Jordan Haha', 'BSIS', '1st Year', 'PE 112'),
(123, 'Goryo, Jordan Haha', 'BSIS', '1st Year', 'NSTP 1'),
(2024565, 'Guevarra, Julius N.', 'BSIT', '1st Year', 'English 123'),
(2024565, 'Guevarra, Julius N.', 'BSIT', '1st Year', 'Prog 123'),
(2024565, 'Guevarra, Julius N.', 'BSIT', '1st Year', 'Filipino 123a'),
(2024565, 'Guevarra, Julius N.', 'BSIT', '1st Year', 'CHS 123'),
(2024565, 'Guevarra, Julius N.', 'BSIT', '1st Year', 'Chem 114'),
(2024565, 'Guevarra, Julius N.', 'BSIT', '1st Year', 'Soc Sci 323b'),
(0, 'Downey, Robert James', 'BSIT', '1st Year', 'Prog 113'),
(0, 'Downey, Robert James', 'BSIT', '1st Year', 'CF 113'),
(0, 'Downey, Robert James', 'BSIT', '1st Year', 'OP 113'),
(0, 'Downey, Robert James', 'BSIT', '1st Year', 'Math 115'),
(0, 'Downey, Robert James', 'BSIT', '1st Year', 'PE 112'),
(0, 'Downey, Robert James', 'BSIT', '1st Year', 'NSTP 1'),
(0, 'Downey, Robert James', 'BSIT', '1st Year', 'Soc 213'),
(0, 'Downey, Robert James', 'BSIT', '1st Year', 'Math 115a'),
(0, 'Downey, Robert James', 'BSIT', '1st Year', 'Prog 123'),
(0, 'Downey, Robert James', 'BSIT', '1st Year', 'Filipino 123a'),
(0, 'Downey, Robert James', 'BSIT', '1st Year', 'CHS 123'),
(0, 'Downey, Robert James', 'BSIT', '1st Year', 'Soc Sci 323b'),
(555, 'Hampaslupa, Dimagiba Neverbroke', 'BSIS', '3rd Year', 'CAPS 1'),
(555, 'Hampaslupa, Dimagiba Neverbroke', 'BSIS', '3rd Year', 'Elec 2'),
(555, 'Hampaslupa, Dimagiba Neverbroke', 'BSIS', '3rd Year', 'Soc Sci 323');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
