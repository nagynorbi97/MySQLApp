-- phpMyAdmin SQL Dump
-- version 4.8.2
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1:3307
-- Létrehozás ideje: 2019. Nov 22. 13:11
-- Kiszolgáló verziója: 10.1.34-MariaDB
-- PHP verzió: 7.2.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `filmdb`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `filmek`
--

CREATE TABLE `filmek` (
  `id` int(11) NOT NULL,
  `rendezo_id` int(11) NOT NULL,
  `cim` varchar(1000) COLLATE utf8_hungarian_ci NOT NULL,
  `kiadasi_nap` date NOT NULL,
  `hossz` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `filmek`
--

INSERT INTO `filmek` (`id`, `rendezo_id`, `cim`, `kiadasi_nap`, `hossz`) VALUES
(1, 2, 'Star Wars: Egy új remény', '1977-05-25', 121),
(2, 3, 'A sötét lovag', '2008-07-18', 152),
(3, 3, 'Batman: Kezdodik!', '2005-07-14', 141);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `rendezok`
--

CREATE TABLE `rendezok` (
  `id` int(11) NOT NULL,
  `nev` varchar(1000) COLLATE utf8_hungarian_ci NOT NULL,
  `szuletes` date NOT NULL,
  `szarmazas` varchar(1000) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `rendezok`
--

INSERT INTO `rendezok` (`id`, `nev`, `szuletes`, `szarmazas`) VALUES
(1, 'Steven Spielberg', '1946-12-18', 'USA'),
(2, 'George Lucas', '1944-05-14', 'USA'),
(3, 'Christopher Nolan', '1970-07-30', 'UK'),
(4, 'Quentin Tarantino', '1963-03-27', 'USA'),
(5, 'Michael Mann', '1943-02-05', 'USA'),
(6, 'Stanley Kubrick', '1928-07-26', 'USA'),
(7, 'Darren Aronofsky', '1969-02-12', 'USA'),
(8, 'Alfonso Cuarón', '1961-11-28', 'Mexikó'),
(9, 'Alejandro González Iñárritu', '1963-08-15', 'Mexikó'),
(10, 'Alfred Hitchcock', '1899-08-13', 'Anglia'),
(11, 'Clint Eastwood', '1930-05-31', 'USA'),
(12, 'Joel Coen', '1954-11-29', 'USA'),
(13, 'Ethan Coen', '1957-09-21', 'USA'),
(14, 'Francis Ford Coppola', '1939-04-07', 'USA'),
(15, 'Peter Jackson', '1961-10-31', 'Új-Zéland'),
(16, 'David Fincher', '1962-08-28', 'USA'),
(17, 'Tony Scott', '1944-06-21', 'UK'),
(18, 'Ridley Scott', '1937-11-30', 'UK'),
(19, 'James Cameron', '1954-08-16', 'Kanada'),
(20, 'Martin Scorsese', '1942-11-17', 'USA');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `filmek`
--
ALTER TABLE `filmek`
  ADD PRIMARY KEY (`id`),
  ADD KEY `rendezo_id` (`rendezo_id`);

--
-- A tábla indexei `rendezok`
--
ALTER TABLE `rendezok`
  ADD PRIMARY KEY (`id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `filmek`
--
ALTER TABLE `filmek`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT a táblához `rendezok`
--
ALTER TABLE `rendezok`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `filmek`
--
ALTER TABLE `filmek`
  ADD CONSTRAINT `filmek_ibfk_1` FOREIGN KEY (`rendezo_id`) REFERENCES `rendezok` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
