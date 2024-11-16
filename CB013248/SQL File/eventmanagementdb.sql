-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 30, 2024 at 08:25 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `eventmanagementdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `event_table`
--

CREATE TABLE `event_table` (
  `Event ID` int(20) NOT NULL,
  `Event Name` varchar(30) NOT NULL,
  `Event Date` date NOT NULL,
  `Venue` varchar(20) NOT NULL,
  `Maximum Participants` int(20) NOT NULL,
  `Event Created By` varchar(20) NOT NULL,
  `Status` varchar(20) NOT NULL,
  `Registered User Counts` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `event_table`
--

INSERT INTO `event_table` (`Event ID`, `Event Name`, `Event Date`, `Venue`, `Maximum Participants`, `Event Created By`, `Status`, `Registered User Counts`) VALUES
(43, 'checkevent1', '2024-09-28', 'cmb', 2, 'Organizer', 'Disapproved', 0);

-- --------------------------------------------------------

--
-- Table structure for table `participant_enrolled_event`
--

CREATE TABLE `participant_enrolled_event` (
  `Participant_Enrollment_Id` int(20) NOT NULL,
  `Participant Username` varchar(30) NOT NULL,
  `Event Name` varchar(30) NOT NULL,
  `Venue` varchar(20) NOT NULL,
  `Date` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `participant_enrolled_event`
--

INSERT INTO `participant_enrolled_event` (`Participant_Enrollment_Id`, `Participant Username`, `Event Name`, `Venue`, `Date`) VALUES
(22, 'testparticipant', 'Finaltest', 'cmb', '2024-09-30');

-- --------------------------------------------------------

--
-- Table structure for table `removed_users`
--

CREATE TABLE `removed_users` (
  `ID` int(20) NOT NULL,
  `Username` varchar(30) NOT NULL,
  `User_type` varchar(30) NOT NULL,
  `Removed_by` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `removed_users`
--

INSERT INTO `removed_users` (`ID`, `Username`, `User_type`, `Removed_by`) VALUES
(10, 'testpart', 'PARTICIPANT', 'organizer'),
(11, 'testpart2', 'PARTICIPANT', 'organizer'),
(12, 'hu', 'PARTICIPANT', 'admin'),
(13, 'new', 'Organizer', 'admin'),
(14, 'removepartici', 'PARTICIPANT', 'admin');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `ID` int(10) NOT NULL,
  `Username` varchar(20) DEFAULT NULL,
  `Password` varchar(20) DEFAULT NULL,
  `User Type` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`ID`, `Username`, `Password`, `User Type`) VALUES
(1, 'admin', 'admin123', 'ADMIN'),
(4, 'Organizer', 'Organizer123', 'ORGANIZER'),
(20, 'participant', 'participant123', 'PARTICIPANT'),
(21, 'testparticipant', 'testparticipant123', 'PARTICIPANT');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `event_table`
--
ALTER TABLE `event_table`
  ADD PRIMARY KEY (`Event ID`);

--
-- Indexes for table `participant_enrolled_event`
--
ALTER TABLE `participant_enrolled_event`
  ADD PRIMARY KEY (`Participant_Enrollment_Id`);

--
-- Indexes for table `removed_users`
--
ALTER TABLE `removed_users`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `event_table`
--
ALTER TABLE `event_table`
  MODIFY `Event ID` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=47;

--
-- AUTO_INCREMENT for table `participant_enrolled_event`
--
ALTER TABLE `participant_enrolled_event`
  MODIFY `Participant_Enrollment_Id` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT for table `removed_users`
--
ALTER TABLE `removed_users`
  MODIFY `ID` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `ID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
