-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 19, 2026 at 05:12 PM
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
-- Database: `db_penjualan_hp`
--

-- --------------------------------------------------------

--
-- Table structure for table `tb_handphone`
--

CREATE TABLE `tb_handphone` (
  `id_hp` int(11) NOT NULL,
  `merk` varchar(50) NOT NULL,
  `tipe` varchar(100) NOT NULL,
  `harga` decimal(15,2) NOT NULL,
  `stok` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tb_handphone`
--

INSERT INTO `tb_handphone` (`id_hp`, `merk`, `tipe`, `harga`, `stok`) VALUES
(1, 'Apple', 'IPhone 17', 23000000.00, 13),
(2, 'Xiaomi', 'POCO X6 Pro', 5400000.00, 20);

-- --------------------------------------------------------

--
-- Table structure for table `tb_transaksi`
--

CREATE TABLE `tb_transaksi` (
  `id_transaksi` int(11) NOT NULL,
  `tanggal_transaksi` date NOT NULL,
  `nama_pembeli` varchar(100) NOT NULL,
  `id_hp` int(11) NOT NULL,
  `jumlah_beli` int(11) NOT NULL,
  `total_harga` decimal(15,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tb_transaksi`
--

INSERT INTO `tb_transaksi` (`id_transaksi`, `tanggal_transaksi`, `nama_pembeli`, `id_hp`, `jumlah_beli`, `total_harga`) VALUES
(1, '2026-04-19', 'Amba', 1, 2, 46000000.00);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_handphone`
--
ALTER TABLE `tb_handphone`
  ADD PRIMARY KEY (`id_hp`);

--
-- Indexes for table `tb_transaksi`
--
ALTER TABLE `tb_transaksi`
  ADD PRIMARY KEY (`id_transaksi`),
  ADD KEY `id_hp` (`id_hp`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tb_handphone`
--
ALTER TABLE `tb_handphone`
  MODIFY `id_hp` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `tb_transaksi`
--
ALTER TABLE `tb_transaksi`
  MODIFY `id_transaksi` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tb_transaksi`
--
ALTER TABLE `tb_transaksi`
  ADD CONSTRAINT `tb_transaksi_ibfk_1` FOREIGN KEY (`id_hp`) REFERENCES `tb_handphone` (`id_hp`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
