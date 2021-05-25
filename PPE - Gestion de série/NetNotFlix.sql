-- phpMyAdmin SQL Dump
-- version 4.6.6deb4
-- https://www.phpmyadmin.net/
--
-- Client :  localhost:3306
-- Généré le :  Mer 05 Mai 2021 à 14:57
-- Version du serveur :  10.1.41-MariaDB-0+deb9u1
-- Version de PHP :  7.0.33-0+deb9u6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `NetNotFlix`
--

-- --------------------------------------------------------

--
-- Structure de la table `Episode`
--

CREATE TABLE `Episode` (
  `idEpisode` int(11) NOT NULL,
  `numEpisode` varchar(10) NOT NULL,
  `titreEpisode` varchar(50) NOT NULL,
  `idSaison` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `Episode`
--

INSERT INTO `Episode` (`idEpisode`, `numEpisode`, `titreEpisode`, `idSaison`) VALUES
(1, '01', 'AKA Ladies Night', 1),
(2, '02', 'AKA Crush Syndrome', 1),
(3, '03', 'AKA It\'s Called Whiskey', 1),
(4, '01', 'AKA Start at the Beginning', 3),
(5, '02', 'AKA Freak Accident', 3),
(6, '03', 'AKA Sole Survivor', 3),
(7, '01', 'Snow Gives Way', 2),
(8, '02', 'Shadow Hawk Takes Flight', 2),
(9, '03', 'Rolling Thunder Cannon Punch', 2),
(10, '04', 'Eight Diagram Dragon Palm', 2),
(11, '05', 'Under Leaf Pluck Lotus', 2),
(12, '06', 'Immortal Emerges From Cave', 2),
(13, '07', 'Felling With Tree Routes', 2),
(14, '08', 'The Blessing Of Many Fractures', 2),
(15, '09', 'The Mistress Of All Agonies', 2),
(16, '10', 'Black Tiger Steals Heart', 2),
(17, '11', 'Lead Horse Back To Stable', 2),
(18, '12', 'Bar the Big Boss', 2),
(19, '13', 'Dragon Plays With Fire', 2),
(20, '01', 'The Fury of Iron Fist', 4),
(21, '02', 'The City\'s Not for Burning', 4),
(22, '03', 'This Deadly Secret', 4),
(23, '04', 'Target : Iron Fist', 4),
(24, '05', 'Heart of the Dragon', 4),
(25, '06', 'The Dragon Dies at Dawn', 4),
(26, '07', 'Morning of the Mindstorm', 4),
(27, '08', 'Citadel on the Edge of Vengeance', 4),
(28, '09', 'War Without End', 4),
(29, '10', 'A Duel of Iron', 4),
(30, '01', 'On Leather Wings', 5),
(31, '02', 'Christmas with the Joker', 5),
(32, '03', 'Nothing to Fear', 5),
(33, '04', 'The Last Laugh', 5),
(34, '05', 'Pretty Poison', 5),
(35, '06', 'The Underdwellers', 5),
(36, '07', 'P.O.V.', 5),
(37, '08', 'The Forgotten', 5),
(38, '09', 'Be a Clown', 5),
(39, '10', 'Two-Face: Part 1', 5),
(40, '11', 'Two-Face: Part 2', 5),
(41, '12', 'It\'s Never Too Late', 5),
(42, '13', 'I\'ve Got Batman in My Basement', 5),
(43, '14', 'Heart of Ice', 5),
(44, '15', 'The Cat and the Claw: Part 1', 5),
(45, '16', 'The Cat and the Claw: Part 2', 5),
(46, '17', 'See No Evil', 5),
(47, '18', 'Beware the Gray Ghost', 5),
(48, '19', 'Prophecy of Doom', 5),
(49, '20', 'Feat of Clay: Part 1', 5),
(50, '21', 'Feat of Clay: Part 2', 5),
(51, '22', 'Joker\'s Favor', 5),
(52, '23', 'Vendetta', 5),
(53, '24', 'Fear of Victory', 5),
(54, '25', 'The Clock King', 5),
(55, '26', 'Appointment in Crime Alley', 5),
(56, '27', 'Mad as a Hatter', 5),
(57, '28', 'Dreams in Darkness', 5),
(58, '29', 'Eternal Youth', 5),
(59, '30', 'Perchance to Dream', 5),
(60, '31', 'The Cape and Cowl Conspiracy', 5),
(61, '32', 'Robin\'s Reckoning: Part 1', 5),
(62, '33', 'Robin\'s Reckoning: Part 2', 5),
(63, '34', 'The Laughing Fish', 5),
(64, '35', 'Night of the Ninja', 5),
(65, '36', 'Cat Scratch Fever', 5),
(66, '37', 'The Strange Secret of Bruce Wayne', 5),
(67, '38', 'Heart of Steel: Part 1', 5),
(68, '39', 'Heart of Steel: Part 2', 5),
(69, '40', 'If You\'re So Smart, Why Aren\'t You Rich?', 5),
(70, '41', 'Joker\'s Wild', 5),
(71, '42', 'Tyger Tyger', 5),
(72, '43', 'Moon of the Wolf', 5),
(73, '44', 'Day of the Samurai', 5),
(74, '45', 'Terror in the Sky', 5),
(75, '46', 'Almost Got \'Im', 5),
(76, '47', 'Birds of a Feather', 5),
(77, '48', 'What Is Reality?', 5),
(78, '49', 'I Am the Night', 5),
(79, '50', 'Off Balance', 5),
(80, '51', 'The Man Who Killed Batman', 5),
(81, '52', 'Mudslide', 5),
(82, '53', 'Paging the Crime Doctor', 5),
(83, '54', 'Zatanna', 5),
(84, '55', 'The Mechanic', 5),
(85, '56', 'Harley and Ivy', 5),
(86, '57', 'Shadow of the Bat: Part 1', 5),
(87, '58', 'Shadow of the Bat: Part 2', 5),
(88, '59', 'Blind as a Bat', 5),
(89, '60', 'The Demon\'s Quest: Part 1', 5),
(90, '61', 'The Demon\'s Quest: Part 2', 5),
(91, '62', 'His Silicon Soul', 5),
(92, '63', 'Fire from Olympus', 5),
(93, '64', 'Read My Lips', 5),
(94, '65', 'The Worry Men', 5),
(95, '01', 'Sideshow', 6),
(96, '02', 'A Bullet for Bullock', 6),
(97, '03', 'Trial', 6),
(98, '04', 'Avatar', 6),
(99, '05', 'House & Garden', 6),
(100, '06', 'The Terrible Trio', 6),
(101, '07', 'Harlequinade', 6),
(102, '08', 'Time Out of Joint', 6),
(103, '09', 'Catwalk', 6),
(104, '10', 'Bane', 6),
(105, '11', 'Baby-Doll', 6),
(106, '12', 'The Lion and the Unicorn', 6),
(107, '13', 'Showdown', 6),
(108, '14', 'Riddler\'s Reform', 6),
(109, '15', 'Second Chance', 6),
(110, '16', 'Harley\'s Holiday', 6),
(111, '17', 'Lock-Up', 6),
(112, '18', 'Make \'Em Laugh', 6),
(113, '19', 'Deep Freeze', 6),
(114, '20', 'Batgirl Returns', 6);

-- --------------------------------------------------------

--
-- Structure de la table `partager`
--

CREATE TABLE `partager` (
  `idUser` int(11) NOT NULL,
  `idUser_partager` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `partager`
--

INSERT INTO `partager` (`idUser`, `idUser_partager`) VALUES
(1, 2),
(2, 1);

-- --------------------------------------------------------

--
-- Structure de la table `regarder`
--

CREATE TABLE `regarder` (
  `idSerie` int(11) NOT NULL,
  `idUser` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `Saison`
--

CREATE TABLE `Saison` (
  `idSaison` int(11) NOT NULL,
  `numSaison` int(11) NOT NULL,
  `sortieSaison` int(11) DEFAULT NULL,
  `idSerie` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `Saison`
--

INSERT INTO `Saison` (`idSaison`, `numSaison`, `sortieSaison`, `idSerie`) VALUES
(1, 1, 2015, 1),
(2, 1, 2018, 2),
(3, 2, 2017, 1),
(4, 2, 2018, 2),
(5, 1, 1992, 3),
(6, 2, 1994, 3);

-- --------------------------------------------------------

--
-- Structure de la table `Serie`
--

CREATE TABLE `Serie` (
  `idSerie` int(11) NOT NULL,
  `titreSerie` varchar(50) NOT NULL,
  `illustrationSerie` varchar(500) NOT NULL,
  `descriptionSerie` varchar(250) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `Serie`
--

INSERT INTO `Serie` (`idSerie`, `titreSerie`, `illustrationSerie`, `descriptionSerie`) VALUES
(1, 'Jessica Jones', 'https://m.media-amazon.com/images/M/MV5BMTcwMzM3NTE5NF5BMl5BanBnXkFtZTgwNjUwNDkwNzE@._V1_.jpg', 'Following the tragic end of her brief superhero career, Jessica Jones tries to rebuild her life as a private investigator, dealing with cases involving people with remarkable abilities in New York City.'),
(2, 'Iron Fist', 'https://fr.web.img4.acsta.net/pictures/18/08/20/09/49/1532686.jpg', 'A young man is bestowed with incredible martial arts skills and a mystical force known as the Iron Fist.'),
(3, 'Batman The Animated Series', 'https://media.senscritique.com/media/000006473751/source_big/Batman.jpg\n', 'The Dark Knight battles crime in Gotham City with occasional help from Robin and Batgirl.');

-- --------------------------------------------------------

--
-- Structure de la table `User`
--

CREATE TABLE `User` (
  `idUser` int(11) NOT NULL,
  `pseudoUser` varchar(50) NOT NULL,
  `mdpUser` varchar(50) NOT NULL,
  `emailUser` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `User`
--

INSERT INTO `User` (`idUser`, `pseudoUser`, `mdpUser`, `emailUser`) VALUES
(1, 'Pidge', '12345', 'pidge@pidge.pidge'),
(2, 'Herotrix', 'grosFILSdepute2001', 'guillaume.mansutti10@outlook.fr'),
(3, 'lideroul', 'nullos', 'thomas@thomas.thomas');

-- --------------------------------------------------------

--
-- Structure de la table `visualisation`
--

CREATE TABLE `visualisation` (
  `idEpisode` int(11) NOT NULL,
  `idUser` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `visualisation`
--

INSERT INTO `visualisation` (`idEpisode`, `idUser`) VALUES
(1, 1),
(2, 1),
(7, 1),
(8, 1),
(24, 2),
(29, 2);

--
-- Index pour les tables exportées
--

--
-- Index pour la table `Episode`
--
ALTER TABLE `Episode`
  ADD PRIMARY KEY (`idEpisode`),
  ADD KEY `Episode_Saison_FK` (`idSaison`);

--
-- Index pour la table `partager`
--
ALTER TABLE `partager`
  ADD PRIMARY KEY (`idUser`,`idUser_partager`),
  ADD KEY `partager_User0_FK` (`idUser_partager`);

--
-- Index pour la table `regarder`
--
ALTER TABLE `regarder`
  ADD PRIMARY KEY (`idSerie`,`idUser`),
  ADD KEY `regarder_User0_FK` (`idUser`);

--
-- Index pour la table `Saison`
--
ALTER TABLE `Saison`
  ADD PRIMARY KEY (`idSaison`),
  ADD KEY `Saison_Serie_FK` (`idSerie`);

--
-- Index pour la table `Serie`
--
ALTER TABLE `Serie`
  ADD PRIMARY KEY (`idSerie`);

--
-- Index pour la table `User`
--
ALTER TABLE `User`
  ADD PRIMARY KEY (`idUser`);

--
-- Index pour la table `visualisation`
--
ALTER TABLE `visualisation`
  ADD PRIMARY KEY (`idEpisode`,`idUser`),
  ADD KEY `visualisation_User0_FK` (`idUser`);

--
-- AUTO_INCREMENT pour les tables exportées
--

--
-- AUTO_INCREMENT pour la table `Episode`
--
ALTER TABLE `Episode`
  MODIFY `idEpisode` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=128;
--
-- AUTO_INCREMENT pour la table `Saison`
--
ALTER TABLE `Saison`
  MODIFY `idSaison` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT pour la table `Serie`
--
ALTER TABLE `Serie`
  MODIFY `idSerie` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT pour la table `User`
--
ALTER TABLE `User`
  MODIFY `idUser` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `Episode`
--
ALTER TABLE `Episode`
  ADD CONSTRAINT `Episode_Saison_FK` FOREIGN KEY (`idSaison`) REFERENCES `Saison` (`idSaison`);

--
-- Contraintes pour la table `partager`
--
ALTER TABLE `partager`
  ADD CONSTRAINT `partager_User0_FK` FOREIGN KEY (`idUser_partager`) REFERENCES `User` (`idUser`),
  ADD CONSTRAINT `partager_User_FK` FOREIGN KEY (`idUser`) REFERENCES `User` (`idUser`);

--
-- Contraintes pour la table `regarder`
--
ALTER TABLE `regarder`
  ADD CONSTRAINT `regarder_Serie_FK` FOREIGN KEY (`idSerie`) REFERENCES `Serie` (`idSerie`),
  ADD CONSTRAINT `regarder_User0_FK` FOREIGN KEY (`idUser`) REFERENCES `User` (`idUser`);

--
-- Contraintes pour la table `Saison`
--
ALTER TABLE `Saison`
  ADD CONSTRAINT `Saison_Serie_FK` FOREIGN KEY (`idSerie`) REFERENCES `Serie` (`idSerie`);

--
-- Contraintes pour la table `visualisation`
--
ALTER TABLE `visualisation`
  ADD CONSTRAINT `visualisation_Episode_FK` FOREIGN KEY (`idEpisode`) REFERENCES `Episode` (`idEpisode`),
  ADD CONSTRAINT `visualisation_User0_FK` FOREIGN KEY (`idUser`) REFERENCES `User` (`idUser`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
