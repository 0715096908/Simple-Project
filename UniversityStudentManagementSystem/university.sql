-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 14, 2017 at 10:48 PM
-- Server version: 5.7.14
-- PHP Version: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `university`
--

-- --------------------------------------------------------

--
-- Table structure for table `addstudent`
--

CREATE TABLE `addstudent` (
  `number` int(8) NOT NULL,
  `firstname` varchar(60) NOT NULL,
  `othername` varchar(60) NOT NULL,
  `regno` varchar(60) NOT NULL,
  `idno` int(11) NOT NULL,
  `yearofstudy` varchar(60) NOT NULL,
  `course` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `phoneno` int(12) NOT NULL,
  `address` varchar(30) NOT NULL,
  `gender` varchar(10) NOT NULL,
  `date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `addstudent`
--

INSERT INTO `addstudent` (`number`, `firstname`, `othername`, `regno`, `idno`, `yearofstudy`, `course`, `email`, `phoneno`, `address`, `gender`, `date`) VALUES
(5, 'Tony', 'Blair', 'ct201/0029/14', 32417123, 'y3s2', 'Computer Science', 'blairman@gmail.com', 715096908, '45455-9946', 'Male', '2017-04-15 01:02:53'),
(6, 'Bornface ', 'Waithaka', 'ct201/0023/14', 324131211, 'y3s1', 'Computer Science', 'bornface@gmail.com', 712321131, '2222-0097', 'Male', '2017-04-15 01:04:02'),
(7, 'Joshua', 'Ariga', 'ct201/0024/14', 312321121, 'y3s2', 'Computer Science', 'joshua@gmail.com', 713221231, '6564-0097', 'Male', '2017-04-15 01:06:00'),
(8, 'Betty', 'Esterline', 'ct201/0026/14', 324132342, 'y3s2', 'Computer Science', 'esterline@gmail.com', 723232122, '664534-99443', 'Male', '2017-04-15 01:08:01'),
(10, 'Gideon', 'Mosoti', 'ct201/0027/14', 32212222, 'y3s2', 'Computer Science', 'mosoti@gmail.com', 712321321, '443342-0094', 'Male', '2017-04-15 01:09:28'),
(11, 'Alicia', 'Shasha', 'ct202/8825/16', 423122212, 'y2s1', 'Information Technology', 'alicia@gmail.com', 712121247, '645375-99678', 'Female', '2017-04-15 01:11:05');

-- --------------------------------------------------------

--
-- Table structure for table `adminlogin`
--

CREATE TABLE `adminlogin` (
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `Date` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `adminlogin`
--

INSERT INTO `adminlogin` (`username`, `password`, `Date`) VALUES
('admin', '21232f297a57a5a743894a0e4a801fc3', ''),
('admin', 'admin', '');

-- --------------------------------------------------------

--
-- Table structure for table `comment`
--

CREATE TABLE `comment` (
  `number` int(8) NOT NULL,
  `click` text NOT NULL,
  `name` varchar(100) NOT NULL,
  `phoneno` int(12) NOT NULL,
  `Date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `comment`
--

INSERT INTO `comment` (`number`, `click`, `name`, `phoneno`, `Date`) VALUES
(1, 'This is a great system that is user friendly and saves a lot of time.', 'TONYMANN', 734322311, '2017-04-15 01:37:26'),
(2, 'Hey, this is the best application i have ever interacted with. Thank you very much for this aplication.', 'Gideon', 723213214, '2017-04-15 01:38:34'),
(3, 'Hey Tony, i like this appliocation so much.', 'Shabrah', 432321534, '2017-04-15 01:39:52'),
(4, 'Hey Tony,  this application and some other aplication of yours in the intenet so great.Could you  send me the source code for this application for $200? ', 'Spinter Proof', 755433252, '2017-04-15 01:42:34');

-- --------------------------------------------------------

--
-- Table structure for table `studentregister`
--

CREATE TABLE `studentregister` (
  `number` int(8) NOT NULL,
  `firstname` varchar(60) NOT NULL,
  `othername` varchar(60) NOT NULL,
  `gender` varchar(10) NOT NULL,
  `idno` int(11) NOT NULL,
  `course` varchar(100) NOT NULL,
  `date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `userid` varchar(30) NOT NULL,
  `password` varchar(60) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `studentregister`
--

INSERT INTO `studentregister` (`number`, `firstname`, `othername`, `gender`, `idno`, `course`, `date`, `userid`, `password`) VALUES
(1, 'Blair', 'Man', 'Male', 32435434, 'COMPUTER SCIENCE', '2017-04-15 01:31:36', '6000', 'blair');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `addstudent`
--
ALTER TABLE `addstudent`
  ADD PRIMARY KEY (`number`),
  ADD UNIQUE KEY `regno` (`regno`);

--
-- Indexes for table `comment`
--
ALTER TABLE `comment`
  ADD PRIMARY KEY (`number`);

--
-- Indexes for table `studentregister`
--
ALTER TABLE `studentregister`
  ADD PRIMARY KEY (`number`),
  ADD UNIQUE KEY `userid` (`userid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `addstudent`
--
ALTER TABLE `addstudent`
  MODIFY `number` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
--
-- AUTO_INCREMENT for table `comment`
--
ALTER TABLE `comment`
  MODIFY `number` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `studentregister`
--
ALTER TABLE `studentregister`
  MODIFY `number` int(8) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
