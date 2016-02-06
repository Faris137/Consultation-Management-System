-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Feb 01, 2016 at 05:48 AM
-- Server version: 10.1.10-MariaDB
-- PHP Version: 7.0.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `consultationdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `appointment`
--

CREATE TABLE `appointment` (
  `ID` int(11) NOT NULL,
  `stu_name` varchar(24) NOT NULL,
  `lect_name` varchar(24) NOT NULL,
  `Date` varchar(12) NOT NULL,
  `time` varchar(12) NOT NULL,
  `status` varchar(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `appointment`
--

INSERT INTO `appointment` (`ID`, `stu_name`, `lect_name`, `Date`, `time`, `status`) VALUES
(2, 'again', 'try', '30/3/2017', '023245', 'Rejected'),
(3, 'yes', 'way', '23/3/2016', '734', 'Accepted'),
(4, 'lect', 'lect', '27/2/2-10', '123456', 'Rejected'),
(8, 'fares', 'tan', '25/2/2016', '05:35', 'Accepted'),
(9, 'fares', 'siti fatimah', '5/6/2016', '10:15', 'Accepted');

-- --------------------------------------------------------

--
-- Table structure for table `lecturer`
--

CREATE TABLE `lecturer` (
  `ID` int(11) NOT NULL,
  `name` varchar(24) NOT NULL,
  `Faculty` varchar(4) NOT NULL,
  `phone` int(10) NOT NULL,
  `Email` varchar(24) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `lecturer`
--

INSERT INTO `lecturer` (`ID`, `name`, `Faculty`, `phone`, `Email`) VALUES
(1, 'tan', 'FSIT', 1234, 'tansc'),
(2, 'Yong', 'FOL', 11432, 'yong'),
(3, 'Siti Fatimah', 'FIST', 1256, 'siti');

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `user_name` varchar(12) NOT NULL,
  `password` varchar(12) NOT NULL,
  `type` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`user_name`, `password`, `type`) VALUES
('sumith', 'kumar', 'Admin'),
('fares', 'fares', 'Admin'),
('student', 'student', 'Student'),
('me', 'me', 'Lecturer'),
('tan', 'tan', 'lecturer');

-- --------------------------------------------------------

--
-- Table structure for table `post`
--

CREATE TABLE `post` (
  `post` varchar(300) NOT NULL,
  `time` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `post`
--

INSERT INTO `post` (`post`, `time`) VALUES
('Try this post and check', '00:07:36'),
('my announcement, all consultation sessions for this week cancelled.', '01:00:00'),
('New session open from next month', '12:00:00'),
('Submission date is delayed to 7th of February, presentations are on the week after', '12:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

CREATE TABLE `student` (
  `ID` int(11) NOT NULL,
  `name` varchar(24) NOT NULL,
  `Faculty` varchar(12) NOT NULL,
  `Year` varchar(12) NOT NULL,
  `PhoneNumber` int(12) NOT NULL,
  `Address` varchar(50) NOT NULL,
  `Email` varchar(24) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `student`
--

INSERT INTO `student` (`ID`, `name`, `Faculty`, `Year`, `PhoneNumber`, `Address`, `Email`) VALUES
(1, 'Fares', 'FIST', 'gama', 134552315, 'BBU', 'faresextra2016@yahoo.com'),
(2, 'Fares', 'FIST', 'gama', 134552315, 'BBU', 'faresextra2016@yahoo.com'),
(3, 'Fares', 'FIST', 'beta', 1234, 'B3', 'fares123456');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `appointment`
--
ALTER TABLE `appointment`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `lecturer`
--
ALTER TABLE `lecturer`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `student`
--
ALTER TABLE `student`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `appointment`
--
ALTER TABLE `appointment`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
--
-- AUTO_INCREMENT for table `lecturer`
--
ALTER TABLE `lecturer`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `student`
--
ALTER TABLE `student`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
