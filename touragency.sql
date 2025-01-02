-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Время создания: Янв 02 2025 г., 14:23
-- Версия сервера: 10.4.27-MariaDB
-- Версия PHP: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `touragency`
--
CREATE DATABASE IF NOT EXISTS `touragency` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `touragency`;

-- --------------------------------------------------------

--
-- Структура таблицы `aspnetroleclaims`
--

CREATE TABLE `aspnetroleclaims` (
  `Id` int(11) NOT NULL,
  `RoleId` char(36) NOT NULL,
  `ClaimType` longtext DEFAULT NULL,
  `ClaimValue` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `aspnetroles`
--

CREATE TABLE `aspnetroles` (
  `Id` char(36) NOT NULL,
  `Name` varchar(256) DEFAULT NULL,
  `NormalizedName` varchar(256) DEFAULT NULL,
  `ConcurrencyStamp` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `aspnetuserclaims`
--

CREATE TABLE `aspnetuserclaims` (
  `Id` int(11) NOT NULL,
  `UserId` char(36) NOT NULL,
  `ClaimType` longtext DEFAULT NULL,
  `ClaimValue` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `aspnetuserlogins`
--

CREATE TABLE `aspnetuserlogins` (
  `LoginProvider` varchar(255) NOT NULL,
  `ProviderKey` varchar(255) NOT NULL,
  `ProviderDisplayName` longtext DEFAULT NULL,
  `UserId` char(36) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `aspnetuserroles`
--

CREATE TABLE `aspnetuserroles` (
  `UserId` char(36) NOT NULL,
  `RoleId` char(36) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `aspnetusers`
--

CREATE TABLE `aspnetusers` (
  `Id` char(36) NOT NULL,
  `UserName` varchar(256) DEFAULT NULL,
  `NormalizedUserName` varchar(256) DEFAULT NULL,
  `Email` varchar(256) DEFAULT NULL,
  `NormalizedEmail` varchar(256) DEFAULT NULL,
  `EmailConfirmed` tinyint(1) NOT NULL,
  `PasswordHash` longtext DEFAULT NULL,
  `SecurityStamp` longtext DEFAULT NULL,
  `ConcurrencyStamp` longtext DEFAULT NULL,
  `PhoneNumber` longtext DEFAULT NULL,
  `PhoneNumberConfirmed` tinyint(1) NOT NULL,
  `TwoFactorEnabled` tinyint(1) NOT NULL,
  `LockoutEnd` datetime DEFAULT NULL,
  `LockoutEnabled` tinyint(1) NOT NULL,
  `AccessFailedCount` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `aspnetusertokens`
--

CREATE TABLE `aspnetusertokens` (
  `UserId` char(36) NOT NULL,
  `LoginProvider` varchar(255) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `Value` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `assets`
--

CREATE TABLE `assets` (
  `id` char(36) NOT NULL,
  `fileName` varchar(260) NOT NULL,
  `original` varchar(260) NOT NULL,
  `mime` varchar(64) NOT NULL,
  `ext` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `banks`
--

CREATE TABLE `banks` (
  `id` char(36) NOT NULL,
  `name` varchar(128) NOT NULL,
  `mfo` int(10) UNSIGNED NOT NULL,
  `city` varchar(16) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `compaties`
--

CREATE TABLE `compaties` (
  `id` char(36) NOT NULL,
  `name` varchar(128) NOT NULL,
  `address` varchar(256) NOT NULL,
  `BankId` char(36) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `countries`
--

CREATE TABLE `countries` (
  `id` char(36) NOT NULL,
  `name` varchar(128) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `devicecodes`
--

CREATE TABLE `devicecodes` (
  `UserCode` varchar(200) NOT NULL,
  `DeviceCode` varchar(200) NOT NULL,
  `SubjectId` varchar(200) DEFAULT NULL,
  `SessionId` varchar(100) DEFAULT NULL,
  `ClientId` varchar(200) NOT NULL,
  `Description` varchar(200) DEFAULT NULL,
  `CreationTime` datetime(6) NOT NULL,
  `Expiration` datetime(6) NOT NULL,
  `Data` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `employees`
--

CREATE TABLE `employees` (
  `Id` char(36) NOT NULL,
  `firstName` varchar(128) NOT NULL,
  `lastName` varchar(128) NOT NULL,
  `middleName` varchar(128) DEFAULT NULL,
  `companyId` char(36) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `individualpeople`
--

CREATE TABLE `individualpeople` (
  `id` char(36) NOT NULL,
  `firstName` varchar(128) NOT NULL,
  `lastName` varchar(128) NOT NULL,
  `middleName` varchar(128) DEFAULT NULL,
  `passportSerial` varchar(16) DEFAULT NULL,
  `passportNumber` varchar(16) DEFAULT NULL,
  `passportDistributor` varchar(16) DEFAULT NULL,
  `passportMakeDate` datetime(6) NOT NULL,
  `passportExpiredDate` datetime(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `legalperson`
--

CREATE TABLE `legalperson` (
  `id` char(36) NOT NULL,
  `name` varchar(64) NOT NULL,
  `edrpou` varchar(64) NOT NULL,
  `bossName` varchar(128) NOT NULL,
  `bossFunction` varchar(128) NOT NULL,
  `paymentAccount` varchar(64) NOT NULL,
  `bankId` char(36) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `persistedgrants`
--

CREATE TABLE `persistedgrants` (
  `Key` varchar(200) NOT NULL,
  `Type` varchar(50) NOT NULL,
  `SubjectId` varchar(200) DEFAULT NULL,
  `SessionId` varchar(100) DEFAULT NULL,
  `ClientId` varchar(200) NOT NULL,
  `Description` varchar(200) DEFAULT NULL,
  `CreationTime` datetime(6) NOT NULL,
  `Expiration` datetime(6) DEFAULT NULL,
  `ConsumedTime` datetime(6) DEFAULT NULL,
  `Data` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `sales`
--

CREATE TABLE `sales` (
  `id` char(36) NOT NULL,
  `beginDate` datetime(6) NOT NULL,
  `duration` int(11) NOT NULL,
  `description` varchar(512) DEFAULT NULL,
  `touristId` char(36) NOT NULL,
  `agentId` char(36) NOT NULL,
  `tourId` char(36) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `socialnetworks`
--

CREATE TABLE `socialnetworks` (
  `id` char(36) NOT NULL,
  `Name` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `socialnetworks`
--

INSERT INTO `socialnetworks` (`id`, `Name`) VALUES
('2fa0ce9c-8b07-4b41-85a7-82a60517a10a', 'Viber'),
('b6e69357-1782-461d-b0b9-9d6efd52a7f4', 'Telegram');

-- --------------------------------------------------------

--
-- Структура таблицы `tags`
--

CREATE TABLE `tags` (
  `id` char(36) NOT NULL,
  `firstName` varchar(64) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `tags`
--

INSERT INTO `tags` (`id`, `firstName`) VALUES
('11de133d-9f34-441c-8c1a-6bfc50cb51fa', 'Семья'),
('5bbd4cf5-28d6-4627-8413-ec8dca5ad0e5', 'Экскурсионный отдых'),
('5fa72c14-5554-44b7-a5f0-f606b40d170c', 'Ездит один'),
('7bc484f5-fbce-4542-a504-7d004076b4b0', 'Горнолыжный отдых'),
('a75d66c4-b4cc-45d1-bac4-39c992537b06', 'Эконом'),
('b07828a0-9ed4-4108-a3e1-aefeaa9e3a45', 'Постоянный клиент'),
('f1315c23-42f2-4f87-9e59-f62a3a87d17d', 'Активный отдых'),
('fa107d07-cfb3-4667-9a27-68d4bade0efe', 'VIP');

-- --------------------------------------------------------

--
-- Структура таблицы `touristphones`
--

CREATE TABLE `touristphones` (
  `id` char(36) NOT NULL,
  `phone` varchar(32) NOT NULL,
  `sendSMS` tinyint(1) NOT NULL,
  `touristId` char(36) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `touristprofiles`
--

CREATE TABLE `touristprofiles` (
  `id` char(36) NOT NULL,
  `firstName` varchar(128) NOT NULL,
  `lastName` varchar(128) NOT NULL,
  `middleName` varchar(128) DEFAULT NULL,
  `comment` varchar(512) NOT NULL,
  `email` varchar(128) DEFAULT NULL,
  `noSendStatus` tinyint(1) NOT NULL,
  `noSendNews` tinyint(1) NOT NULL,
  `city` varchar(64) NOT NULL,
  `address` varchar(256) NOT NULL,
  `birthday` datetime(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `touristprofiles`
--

INSERT INTO `touristprofiles` (`id`, `firstName`, `lastName`, `middleName`, `comment`, `email`, `noSendStatus`, `noSendNews`, `city`, `address`, `birthday`) VALUES
('055b8af1-4aa9-45a9-a953-fe237731396a', 'Владимир', 'Тестовый', 'Иванович', 'Очень хороший человек', NULL, 0, 0, 'Киев', 'Живет где-то в Киеве', '1988-02-13 00:00:00.000000'),
('c18ddec9-0af4-4017-9e30-96651267ac99', 'Иван', 'Тестовый', 'Иванович', 'Просто хороший человек', NULL, 0, 0, 'Днепр', 'Живет где-то в Днепре', '1978-11-20 00:00:00.000000'),
('c6880bd9-0d27-409f-87c9-7ccc940b19a6', 'Тест', 'Иванов', 'Тестович', 'Просто хороший человек', NULL, 0, 0, 'Сухачевка', 'Живет где-то в Сухачевке', '1973-06-22 00:00:00.000000');

-- --------------------------------------------------------

--
-- Структура таблицы `tourists_tags`
--

CREATE TABLE `tourists_tags` (
  `touristId` char(36) NOT NULL,
  `tagId` char(36) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `tours`
--

CREATE TABLE `tours` (
  `id` char(36) NOT NULL,
  `name` varchar(128) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `tours_countries`
--

CREATE TABLE `tours_countries` (
  `countryId` char(36) NOT NULL,
  `tourId` char(36) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `tours_ tourtypes`
--

CREATE TABLE `tours_ tourtypes` (
  `tourTypeId` char(36) NOT NULL,
  `tourId` char(36) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `tourtypes`
--

CREATE TABLE `tourtypes` (
  `id` char(36) NOT NULL,
  `name` varchar(128) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `tps`
--

CREATE TABLE `tps` (
  `PhoneId` char(36) NOT NULL,
  `SocialId` char(36) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20241031095118_StartMigration', '8.0.10'),
('20241031132506_EntityTestMigration', '8.0.10'),
('20241031134610_EntityNoWarningMigration', '8.0.10'),
('20241031135854_ApiAuthMigration', '8.0.10');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetRoleClaims_RoleId` (`RoleId`);

--
-- Индексы таблицы `aspnetroles`
--
ALTER TABLE `aspnetroles`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `RoleNameIndex` (`NormalizedName`);

--
-- Индексы таблицы `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetUserClaims_UserId` (`UserId`);

--
-- Индексы таблицы `aspnetuserlogins`
--
ALTER TABLE `aspnetuserlogins`
  ADD PRIMARY KEY (`LoginProvider`,`ProviderKey`),
  ADD KEY `IX_AspNetUserLogins_UserId` (`UserId`);

--
-- Индексы таблицы `aspnetuserroles`
--
ALTER TABLE `aspnetuserroles`
  ADD PRIMARY KEY (`UserId`,`RoleId`),
  ADD KEY `IX_AspNetUserRoles_RoleId` (`RoleId`);

--
-- Индексы таблицы `aspnetusers`
--
ALTER TABLE `aspnetusers`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `UserNameIndex` (`NormalizedUserName`),
  ADD KEY `EmailIndex` (`NormalizedEmail`);

--
-- Индексы таблицы `aspnetusertokens`
--
ALTER TABLE `aspnetusertokens`
  ADD PRIMARY KEY (`UserId`,`LoginProvider`,`Name`);

--
-- Индексы таблицы `assets`
--
ALTER TABLE `assets`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `banks`
--
ALTER TABLE `banks`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `compaties`
--
ALTER TABLE `compaties`
  ADD PRIMARY KEY (`id`),
  ADD KEY `IX_compaties_BankId` (`BankId`);

--
-- Индексы таблицы `countries`
--
ALTER TABLE `countries`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `devicecodes`
--
ALTER TABLE `devicecodes`
  ADD PRIMARY KEY (`UserCode`),
  ADD UNIQUE KEY `IX_DeviceCodes_DeviceCode` (`DeviceCode`),
  ADD KEY `IX_DeviceCodes_Expiration` (`Expiration`);

--
-- Индексы таблицы `employees`
--
ALTER TABLE `employees`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_Employees_companyId` (`companyId`);

--
-- Индексы таблицы `individualpeople`
--
ALTER TABLE `individualpeople`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `legalperson`
--
ALTER TABLE `legalperson`
  ADD PRIMARY KEY (`id`),
  ADD KEY `IX_LegalPerson_bankId` (`bankId`);

--
-- Индексы таблицы `persistedgrants`
--
ALTER TABLE `persistedgrants`
  ADD PRIMARY KEY (`Key`),
  ADD KEY `IX_PersistedGrants_Expiration` (`Expiration`),
  ADD KEY `IX_PersistedGrants_SubjectId_ClientId_Type` (`SubjectId`,`ClientId`,`Type`),
  ADD KEY `IX_PersistedGrants_SubjectId_SessionId_Type` (`SubjectId`,`SessionId`,`Type`);

--
-- Индексы таблицы `sales`
--
ALTER TABLE `sales`
  ADD PRIMARY KEY (`id`),
  ADD KEY `IX_sales_agentId` (`agentId`),
  ADD KEY `IX_sales_tourId` (`tourId`),
  ADD KEY `IX_sales_touristId` (`touristId`);

--
-- Индексы таблицы `socialnetworks`
--
ALTER TABLE `socialnetworks`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `tags`
--
ALTER TABLE `tags`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `touristphones`
--
ALTER TABLE `touristphones`
  ADD PRIMARY KEY (`id`),
  ADD KEY `IX_touristPhones_touristId` (`touristId`);

--
-- Индексы таблицы `touristprofiles`
--
ALTER TABLE `touristprofiles`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `tourists_tags`
--
ALTER TABLE `tourists_tags`
  ADD PRIMARY KEY (`tagId`,`touristId`),
  ADD KEY `IX_tourists_tags_touristId` (`touristId`);

--
-- Индексы таблицы `tours`
--
ALTER TABLE `tours`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `tours_countries`
--
ALTER TABLE `tours_countries`
  ADD PRIMARY KEY (`tourId`,`countryId`),
  ADD KEY `IX_tours_countries_countryId` (`countryId`);

--
-- Индексы таблицы `tours_ tourtypes`
--
ALTER TABLE `tours_ tourtypes`
  ADD PRIMARY KEY (`tourId`,`tourTypeId`),
  ADD KEY `IX_tours_ tourTypes_tourTypeId` (`tourTypeId`);

--
-- Индексы таблицы `tourtypes`
--
ALTER TABLE `tourtypes`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `tps`
--
ALTER TABLE `tps`
  ADD PRIMARY KEY (`PhoneId`,`SocialId`),
  ADD KEY `IX_TPS_SocialId` (`SocialId`);

--
-- Индексы таблицы `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  ADD CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE;

--
-- Ограничения внешнего ключа таблицы `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  ADD CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Ограничения внешнего ключа таблицы `aspnetuserlogins`
--
ALTER TABLE `aspnetuserlogins`
  ADD CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Ограничения внешнего ключа таблицы `aspnetuserroles`
--
ALTER TABLE `aspnetuserroles`
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Ограничения внешнего ключа таблицы `aspnetusertokens`
--
ALTER TABLE `aspnetusertokens`
  ADD CONSTRAINT `FK_AspNetUserTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Ограничения внешнего ключа таблицы `compaties`
--
ALTER TABLE `compaties`
  ADD CONSTRAINT `FK_compaties_banks_BankId` FOREIGN KEY (`BankId`) REFERENCES `banks` (`id`);

--
-- Ограничения внешнего ключа таблицы `employees`
--
ALTER TABLE `employees`
  ADD CONSTRAINT `FK_Employees_AspNetUsers_Id` FOREIGN KEY (`Id`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_Employees_compaties_companyId` FOREIGN KEY (`companyId`) REFERENCES `compaties` (`id`) ON DELETE CASCADE;

--
-- Ограничения внешнего ключа таблицы `individualpeople`
--
ALTER TABLE `individualpeople`
  ADD CONSTRAINT `FK_IndividualPeople_touristProfiles_id` FOREIGN KEY (`id`) REFERENCES `touristprofiles` (`id`) ON DELETE CASCADE;

--
-- Ограничения внешнего ключа таблицы `legalperson`
--
ALTER TABLE `legalperson`
  ADD CONSTRAINT `FK_LegalPerson_banks_bankId` FOREIGN KEY (`bankId`) REFERENCES `banks` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_LegalPerson_touristProfiles_id` FOREIGN KEY (`id`) REFERENCES `touristprofiles` (`id`) ON DELETE CASCADE;

--
-- Ограничения внешнего ключа таблицы `sales`
--
ALTER TABLE `sales`
  ADD CONSTRAINT `FK_sales_Employees_agentId` FOREIGN KEY (`agentId`) REFERENCES `employees` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_sales_touristProfiles_touristId` FOREIGN KEY (`touristId`) REFERENCES `touristprofiles` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_sales_tours_tourId` FOREIGN KEY (`tourId`) REFERENCES `tours` (`id`) ON DELETE CASCADE;

--
-- Ограничения внешнего ключа таблицы `touristphones`
--
ALTER TABLE `touristphones`
  ADD CONSTRAINT `FK_touristPhones_touristProfiles_touristId` FOREIGN KEY (`touristId`) REFERENCES `touristprofiles` (`id`) ON DELETE CASCADE;

--
-- Ограничения внешнего ключа таблицы `tourists_tags`
--
ALTER TABLE `tourists_tags`
  ADD CONSTRAINT `FK_tourists_tags_tags_tagId` FOREIGN KEY (`tagId`) REFERENCES `tags` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_tourists_tags_touristProfiles_touristId` FOREIGN KEY (`touristId`) REFERENCES `touristprofiles` (`id`) ON DELETE CASCADE;

--
-- Ограничения внешнего ключа таблицы `tours_countries`
--
ALTER TABLE `tours_countries`
  ADD CONSTRAINT `FK_tours_countries_countries_countryId` FOREIGN KEY (`countryId`) REFERENCES `countries` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_tours_countries_tours_tourId` FOREIGN KEY (`tourId`) REFERENCES `tours` (`id`) ON DELETE CASCADE;

--
-- Ограничения внешнего ключа таблицы `tours_ tourtypes`
--
ALTER TABLE `tours_ tourtypes`
  ADD CONSTRAINT `FK_tours_ tourTypes_tourTypes_tourTypeId` FOREIGN KEY (`tourTypeId`) REFERENCES `tourtypes` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_tours_ tourTypes_tours_tourId` FOREIGN KEY (`tourId`) REFERENCES `tours` (`id`) ON DELETE CASCADE;

--
-- Ограничения внешнего ключа таблицы `tps`
--
ALTER TABLE `tps`
  ADD CONSTRAINT `FK_TPS_SocialNetworks_SocialId` FOREIGN KEY (`SocialId`) REFERENCES `socialnetworks` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_TPS_touristPhones_PhoneId` FOREIGN KEY (`PhoneId`) REFERENCES `touristphones` (`id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
