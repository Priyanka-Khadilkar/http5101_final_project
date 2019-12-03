-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 03, 2019 at 11:28 PM
-- Server version: 10.4.8-MariaDB
-- PHP Version: 7.3.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `cms`
--

-- --------------------------------------------------------

--
-- Table structure for table `content_pages`
--

CREATE TABLE `content_pages` (
  `page_id` int(10) UNSIGNED NOT NULL,
  `pagetitle` varchar(255) DEFAULT NULL,
  `pagebody` mediumtext DEFAULT NULL,
  `publishdate` datetime NOT NULL,
  `is_published` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `content_pages`
--

INSERT INTO `content_pages` (`page_id`, `pagetitle`, `pagebody`, `publishdate`, `is_published`) VALUES
(4, 'priyanka test', 'asfsafsafsafasf', '2019-11-28 17:48:30', 1),
(5, 'loream ipsums', 'safffffffffffffffffffffffffffffjsbdhjgfsjedbgsdbnhjbsdhjbsdjbhjsdbjsbsjnsdjb kjdsbjkbsdjgbjsd ksjsddgjkbsbdjgsdv sskdngjksddjgxccvg skdgjksdjkgb sdgbjsdbdgjb SDbgjksbdjdgbxc sjsjdbjksbdjgxc sjsdbjksbdgjbzcvskjbjb jsjdbjkgbsdjgbj sdjbgjksdbgj sdbgjksdbgjb sdbgjsdb sdgbjsb sdbgjbsjgb sdngbjsdbg sndbgjbsd sdbgjsbdgjb sndbgjbsd sdbgnjsbdgb sbdgnbsjdbg sdbgjbsdjgb', '2019-12-03 17:22:57', 1),
(6, 'date test', 'sdfdsgsdgsdg', '2019-11-28 17:48:30', 0),
(7, 'fsdfsdgf', 'dfsdfdsgsdg', '2019-11-28 17:48:30', 0),
(8, 'eet', 'ewtewtewt', '2019-11-28 17:48:30', 0),
(9, 'sfsdfdg', 'sgfsdgsdg', '2019-11-28 17:48:30', 0),
(11, 'dgagdg f', 'priyansfnangjghgfjasggvsdjghsd djkdghjshhjshj jhgsdjdgh bjgjhjsdg', '2019-11-28 07:44:01', 0),
(13, 'safsaf', 'safsafasf', '2019-11-28 00:00:00', 0),
(14, 'wqfrafas', 'fasfdfadf', '2019-11-28 00:00:00', 0),
(15, 'final test2', 'final test 234567', '2019-11-28 00:00:00', 0),
(16, 'jekjfwkjg', 'ewgwegnh', '2019-12-02 12:57:05', 0),
(17, 'final test3', 'hellp final test 3', '2019-12-03 17:22:28', 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `content_pages`
--
ALTER TABLE `content_pages`
  ADD PRIMARY KEY (`page_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `content_pages`
--
ALTER TABLE `content_pages`
  MODIFY `page_id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
