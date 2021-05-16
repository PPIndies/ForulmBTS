-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le : lun. 17 mai 2021 à 00:21
-- Version du serveur :  10.4.17-MariaDB
-- Version de PHP : 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `idea_box`
--

-- --------------------------------------------------------

--
-- Structure de la table `f_categories`
--

CREATE TABLE `f_categories` (
  `id` int(11) NOT NULL,
  `nom` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `f_categories`
--

INSERT INTO `f_categories` (`id`, `nom`) VALUES
(1, 'GESTAMP Ronchamp'),
(2, 'GESTAMP Le Theil');

-- --------------------------------------------------------

--
-- Structure de la table `f_messages`
--

CREATE TABLE `f_messages` (
  `id` int(11) NOT NULL,
  `id_topic` int(11) NOT NULL,
  `id_posteur` int(11) NOT NULL,
  `date_heure_post` datetime NOT NULL,
  `date_heure_edition` datetime NOT NULL,
  `meilleure_reponse` int(11) NOT NULL,
  `contenu` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `f_messages`
--

INSERT INTO `f_messages` (`id`, `id_topic`, `id_posteur`, `date_heure_post`, `date_heure_edition`, `meilleure_reponse`, `contenu`) VALUES
(1, 4, 4, '2021-04-24 15:47:46', '0000-00-00 00:00:00', 0, 'Lolilol pas daccord'),
(2, 4, 4, '2021-04-24 16:43:53', '0000-00-00 00:00:00', 0, 'Lolilol pas daccord'),
(3, 4, 4, '2021-04-24 16:43:59', '0000-00-00 00:00:00', 0, 'Bon '),
(4, 4, 4, '2021-04-24 16:44:04', '0000-00-00 00:00:00', 0, 'Bon '),
(5, 4, 4, '2021-04-24 16:44:07', '0000-00-00 00:00:00', 0, 'dsqdsq\r\nsdq\r\nsdq\r\nqsd'),
(6, 4, 4, '2021-04-24 16:44:09', '0000-00-00 00:00:00', 0, 'dsq'),
(7, 4, 4, '2021-04-24 16:44:32', '0000-00-00 00:00:00', 0, 'allors'),
(8, 4, 4, '2021-04-24 16:44:42', '0000-00-00 00:00:00', 0, 'du coup'),
(9, 5, 1, '2021-04-25 23:06:30', '0000-00-00 00:00:00', 0, 'vghjgvhjghj'),
(10, 6, 1, '2021-04-26 14:49:31', '0000-00-00 00:00:00', 0, 'dsqdqsdqs'),
(11, 6, 1, '2021-04-26 14:49:34', '0000-00-00 00:00:00', 0, 'dsqdsqdsqq'),
(12, 6, 1, '2021-04-26 14:49:35', '0000-00-00 00:00:00', 0, 'dsqdsqdqsdzaeaz'),
(13, 6, 1, '2021-04-26 14:49:38', '0000-00-00 00:00:00', 0, 'dsqdaeza'),
(14, 6, 1, '2021-04-27 23:41:59', '0000-00-00 00:00:00', 0, 'ouai daccord sa pue ca mere\r\n'),
(15, 6, 1, '2021-04-27 23:44:49', '0000-00-00 00:00:00', 0, 'azaeza\r\neza\r\n'),
(16, 6, 1, '2021-04-27 23:44:51', '0000-00-00 00:00:00', 0, 'ezaeza\r\n'),
(17, 4, 1, '2021-05-07 01:06:03', '0000-00-00 00:00:00', 0, 'nique ta mere'),
(18, 4, 1, '2021-05-07 01:39:32', '0000-00-00 00:00:00', 0, 'dsqdsqdqs');

-- --------------------------------------------------------

--
-- Structure de la table `f_souscategories`
--

CREATE TABLE `f_souscategories` (
  `id` int(11) NOT NULL,
  `id_categorie` int(11) NOT NULL,
  `nom` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `f_souscategories`
--

INSERT INTO `f_souscategories` (`id`, `id_categorie`, `nom`) VALUES
(1, 1, 'Qualité'),
(2, 1, 'Soudure'),
(3, 1, 'Emboutissage'),
(4, 1, 'Informatique'),
(5, 1, 'Maintenance'),
(6, 2, 'Qualité '),
(7, 2, 'Production');

-- --------------------------------------------------------

--
-- Structure de la table `f_suivis`
--

CREATE TABLE `f_suivis` (
  `id` int(11) NOT NULL,
  `id_user` int(11) NOT NULL,
  `id_topic` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Structure de la table `f_topics`
--

CREATE TABLE `f_topics` (
  `id` int(11) NOT NULL,
  `id_createur` int(11) NOT NULL,
  `sujet` text NOT NULL,
  `contenu` text NOT NULL,
  `date_heure_creation` datetime NOT NULL,
  `resolu` smallint(6) NOT NULL,
  `notif_createur` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `f_topics`
--

INSERT INTO `f_topics` (`id`, `id_createur`, `sujet`, `contenu`, `date_heure_creation`, `resolu`, `notif_createur`) VALUES
(1, 1, 'Test premiere Idee ', 'lolilol', '2021-04-24 06:02:00', 0, 1),
(2, 4, 'Yolo', 'fdgfdgfdgdf', '2021-04-24 12:12:52', 0, 1),
(3, 4, 'Oridnateur trop lent ', 'Il faudrait changer les ordinateur du poste PA400', '2021-04-24 12:49:15', 0, 0),
(4, 4, 'Test premiere Idee ', 'faut opas metre le bac la ', '2021-04-24 14:04:31', 0, 0),
(5, 1, 'vhjvhjv', 'nkj;nbk;,jn;,n;', '2021-04-25 23:06:18', 0, 1),
(6, 1, 'La presse la elle ma niquer', 'Faite attention faus changer ca ', '2021-04-26 14:49:24', 0, 0),
(7, 1, 'dqsdsq', 'sqdqsdqsdqsd', '2021-05-07 01:39:41', 0, 0);

-- --------------------------------------------------------

--
-- Structure de la table `f_topics_categories`
--

CREATE TABLE `f_topics_categories` (
  `id` int(11) NOT NULL,
  `id_topic` int(11) NOT NULL,
  `id_categorie` int(11) NOT NULL,
  `id_souscategorie` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `f_topics_categories`
--

INSERT INTO `f_topics_categories` (`id`, `id_topic`, `id_categorie`, `id_souscategorie`) VALUES
(1, 3, 1, 4),
(2, 4, 2, 7),
(3, 5, 1, 3),
(4, 6, 1, 3),
(5, 7, 1, 3);

-- --------------------------------------------------------

--
-- Structure de la table `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `mail` varchar(255) NOT NULL,
  `pseudo` varchar(255) NOT NULL,
  `motdepasse` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Déchargement des données de la table `user`
--

INSERT INTO `user` (`id`, `mail`, `pseudo`, `motdepasse`) VALUES
(1, 'pierre@gmail.com', 'Admin', '40bd001563085fc35165329ea1ff5c5ecbdbbeef'),
(2, 'thomas@gmail.com', 'User', '7c4a8d09ca3762af61e59520943dc26494f8941b'),
(3, 'matthieu@gmail.com', 'USer2', '7c4a8d09ca3762af61e59520943dc26494f8941b'),
(4, 'Doryan@gmail.com', 'Doryan', '7c4a8d09ca3762af61e59520943dc26494f8941b'),
(5, 'Adrien@gmail.com', 'Matthieu', '40bd001563085fc35165329ea1ff5c5ecbdbbeef');

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `f_categories`
--
ALTER TABLE `f_categories`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `f_messages`
--
ALTER TABLE `f_messages`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_topic` (`id_topic`),
  ADD KEY `id_posteur` (`id_posteur`);

--
-- Index pour la table `f_souscategories`
--
ALTER TABLE `f_souscategories`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_categorie` (`id_categorie`);

--
-- Index pour la table `f_suivis`
--
ALTER TABLE `f_suivis`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_user` (`id_user`),
  ADD KEY `id_topic` (`id_topic`);

--
-- Index pour la table `f_topics`
--
ALTER TABLE `f_topics`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_createur` (`id_createur`);

--
-- Index pour la table `f_topics_categories`
--
ALTER TABLE `f_topics_categories`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id_topic` (`id_topic`),
  ADD KEY `id_categorie` (`id_categorie`),
  ADD KEY `id_souscategorie` (`id_souscategorie`);

--
-- Index pour la table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `f_categories`
--
ALTER TABLE `f_categories`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT pour la table `f_messages`
--
ALTER TABLE `f_messages`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT pour la table `f_souscategories`
--
ALTER TABLE `f_souscategories`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT pour la table `f_suivis`
--
ALTER TABLE `f_suivis`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT pour la table `f_topics`
--
ALTER TABLE `f_topics`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT pour la table `f_topics_categories`
--
ALTER TABLE `f_topics_categories`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT pour la table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `f_messages`
--
ALTER TABLE `f_messages`
  ADD CONSTRAINT `f_messages_ibfk_1` FOREIGN KEY (`id_posteur`) REFERENCES `f_topics_categories` (`id`),
  ADD CONSTRAINT `f_messages_ibfk_2` FOREIGN KEY (`id_topic`) REFERENCES `f_topics` (`id`);

--
-- Contraintes pour la table `f_souscategories`
--
ALTER TABLE `f_souscategories`
  ADD CONSTRAINT `f_souscategories_ibfk_1` FOREIGN KEY (`id_categorie`) REFERENCES `f_categories` (`id`);

--
-- Contraintes pour la table `f_suivis`
--
ALTER TABLE `f_suivis`
  ADD CONSTRAINT `f_suivis_ibfk_1` FOREIGN KEY (`id_user`) REFERENCES `user` (`id`),
  ADD CONSTRAINT `f_suivis_ibfk_2` FOREIGN KEY (`id_topic`) REFERENCES `f_topics` (`id`);

--
-- Contraintes pour la table `f_topics`
--
ALTER TABLE `f_topics`
  ADD CONSTRAINT `f_topics_ibfk_1` FOREIGN KEY (`id_createur`) REFERENCES `user` (`id`);

--
-- Contraintes pour la table `f_topics_categories`
--
ALTER TABLE `f_topics_categories`
  ADD CONSTRAINT `f_topics_categories_ibfk_1` FOREIGN KEY (`id_categorie`) REFERENCES `f_categories` (`id`),
  ADD CONSTRAINT `f_topics_categories_ibfk_2` FOREIGN KEY (`id_souscategorie`) REFERENCES `f_souscategories` (`id`),
  ADD CONSTRAINT `f_topics_categories_ibfk_3` FOREIGN KEY (`id_topic`) REFERENCES `f_topics` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
