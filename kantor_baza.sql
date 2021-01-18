-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Czas generowania: 12 Gru 2020, 18:01
-- Wersja serwera: 10.4.17-MariaDB
-- Wersja PHP: 8.0.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: `kantor_baza`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `tranzakcje`
--

CREATE TABLE `tranzakcje` (
  `ID` int(11) NOT NULL,
  `Data` date NOT NULL,
  `Godzina` time NOT NULL,
  `Typ_operacji` int(11) NOT NULL,
  `Ilosc_jednostek_wym` double NOT NULL,
  `ilosc_jednostek_po_wymianie` double NOT NULL,
  `ID_uzytkownika` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `tranzakcje`
--

INSERT INTO `tranzakcje` (`ID`, `Data`, `Godzina`, `Typ_operacji`, `Ilosc_jednostek_wym`, `ilosc_jednostek_po_wymianie`, `ID_uzytkownika`) VALUES
(1, '2020-12-10', '16:08:49', 1, 100, 27.02, 1),
(3, '2020-12-11', '08:12:42', 5, 123.45, 469.11, 2);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `typy`
--

CREATE TABLE `typy` (
  `ID` int(11) NOT NULL,
  `Symbol` varchar(40) COLLATE utf8_polish_ci NOT NULL,
  `Opis` text COLLATE utf8_polish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `typy`
--

INSERT INTO `typy` (`ID`, `Symbol`, `Opis`) VALUES
(1, 'PLN->USD', 'Zamiana PLN na USD'),
(2, 'PLN->EUR', 'Zamiana  PLN na EURO'),
(3, 'PLN->GBP', 'Zamiana  PLN na GBP'),
(4, 'PLN->CHF', 'Zamiana  PLN na  CHF'),
(5, 'USD->PLN', 'Zamiana  USD na PLN'),
(6, 'EUR->PLN', 'Zamiana EURO na PLN'),
(7, 'GBP->PLN', 'Zamiana GBP->PLN');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `uprawnienia`
--

CREATE TABLE `uprawnienia` (
  `ID` int(11) NOT NULL,
  `Rodzaj` varchar(40) COLLATE utf8_polish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `uprawnienia`
--

INSERT INTO `uprawnienia` (`ID`, `Rodzaj`) VALUES
(0, 'Admin'),
(1, 'Pracownik');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `uzytkownicy`
--

CREATE TABLE `uzytkownicy` (
  `ID` int(11) NOT NULL,
  `Imie` varchar(30) COLLATE utf8_polish_ci NOT NULL,
  `Nazwisko` varchar(30) COLLATE utf8_polish_ci NOT NULL,
  `login` varchar(40) COLLATE utf8_polish_ci DEFAULT NULL,
  `Haslo` varchar(40) COLLATE utf8_polish_ci NOT NULL,
  `Uprawnienia` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `uzytkownicy`
--

INSERT INTO `uzytkownicy` (`ID`, `Imie`, `Nazwisko`, `login`, `Haslo`, `Uprawnienia`) VALUES
(1, 'Kuba', 'Kowal', 'kubaKowal', '81dc9bdb52d04dc20036dbd8313ed055', 0),
(2, 'Krzysztof', 'Nowak', 'krzysztofNowak', 'd8578edf8458ce06fbc5bb76a58c5ca4', 1);

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `tranzakcje`
--
ALTER TABLE `tranzakcje`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `ID_uzytkownika` (`ID_uzytkownika`),
  ADD KEY `Typ_operacji` (`Typ_operacji`);

--
-- Indeksy dla tabeli `typy`
--
ALTER TABLE `typy`
  ADD PRIMARY KEY (`ID`);

--
-- Indeksy dla tabeli `uprawnienia`
--
ALTER TABLE `uprawnienia`
  ADD PRIMARY KEY (`ID`);

--
-- Indeksy dla tabeli `uzytkownicy`
--
ALTER TABLE `uzytkownicy`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Uprawnienia` (`Uprawnienia`);

--
-- AUTO_INCREMENT dla zrzuconych tabel
--

--
-- AUTO_INCREMENT dla tabeli `tranzakcje`
--
ALTER TABLE `tranzakcje`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT dla tabeli `typy`
--
ALTER TABLE `typy`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT dla tabeli `uprawnienia`
--
ALTER TABLE `uprawnienia`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT dla tabeli `uzytkownicy`
--
ALTER TABLE `uzytkownicy`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Ograniczenia dla zrzutów tabel
--

--
-- Ograniczenia dla tabeli `tranzakcje`
--
ALTER TABLE `tranzakcje`
  ADD CONSTRAINT `tranzakcje_ibfk_1` FOREIGN KEY (`ID_uzytkownika`) REFERENCES `uzytkownicy` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tranzakcje_ibfk_2` FOREIGN KEY (`Typ_operacji`) REFERENCES `typy` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ograniczenia dla tabeli `uzytkownicy`
--
ALTER TABLE `uzytkownicy`
  ADD CONSTRAINT `uzytkownicy_ibfk_1` FOREIGN KEY (`Uprawnienia`) REFERENCES `uprawnienia` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
