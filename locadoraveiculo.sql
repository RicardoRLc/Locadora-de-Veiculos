-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 25-Maio-2021 às 05:16
-- Versão do servidor: 10.4.8-MariaDB
-- versão do PHP: 7.3.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `locadoraveiculo`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `clientes`
--

CREATE TABLE `clientes` (
  `IdCliente` int(11) NOT NULL,
  `NomeCliente` longtext DEFAULT NULL,
  `DataNascimento` longtext NOT NULL,
  `CpfCliente` longtext DEFAULT NULL,
  `DiasDevolucao` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `clientes`
--

INSERT INTO `clientes` (`IdCliente`, `NomeCliente`, `DataNascimento`, `CpfCliente`, `DiasDevolucao`) VALUES
(1, 'Ricardo Legal', '87/87/8978', '000.000.000-00', 3),
(2, 'Kadu Gostoso', '21/21/2121', '111.111.111-11', 1),
(3, 'Joao Medina', '45/45/4545', '111.111.111-11', 3),
(5, 'Teste', '11/11/1111', '111.111.111-11', 7),
(6, 'Teste 2', '22/22/2222', '222.222.222-22', 4),
(7, 'Teste 3', '33/33/3333', '333.333.333-33', 2),
(8, 'Teste 4', '55/55/5555', '555.555.555-55', 1),
(9, 'Teste 6', '66/66/6666', '666.666.666-66', 3),
(10, 'fabio', '11/11/1111', '000.000.000-00', 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `locacaoveiculo`
--

CREATE TABLE `locacaoveiculo` (
  `Id` int(11) NOT NULL,
  `IdLocacao` int(11) NOT NULL,
  `LocacaoIdLocacao` int(11) DEFAULT NULL,
  `IdVeiculo` int(11) NOT NULL,
  `VeiculoIdVeiculo` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `locacoes`
--

CREATE TABLE `locacoes` (
  `IdLocacao` int(11) NOT NULL,
  `ClienteIdCliente` int(11) DEFAULT NULL,
  `IdCliente` int(11) NOT NULL,
  `DataLocacao` datetime(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `veiculos`
--

CREATE TABLE `veiculos` (
  `IdVeiculo` int(11) NOT NULL,
  `Marca` longtext DEFAULT NULL,
  `Modelo` longtext DEFAULT NULL,
  `Ano` int(11) NOT NULL,
  `ValorLocacaoVeiculo` double NOT NULL,
  `EstoqueVeiculo` int(11) NOT NULL,
  `VeiculoLocado` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estrutura da tabela `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(95) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20210414001940_InitialDB', '3.1.5');

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`IdCliente`);

--
-- Índices para tabela `locacaoveiculo`
--
ALTER TABLE `locacaoveiculo`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_LocacaoVeiculo_LocacaoIdLocacao` (`LocacaoIdLocacao`),
  ADD KEY `IX_LocacaoVeiculo_VeiculoIdVeiculo` (`VeiculoIdVeiculo`);

--
-- Índices para tabela `locacoes`
--
ALTER TABLE `locacoes`
  ADD PRIMARY KEY (`IdLocacao`),
  ADD KEY `IX_Locacoes_ClienteIdCliente` (`ClienteIdCliente`);

--
-- Índices para tabela `veiculos`
--
ALTER TABLE `veiculos`
  ADD PRIMARY KEY (`IdVeiculo`);

--
-- Índices para tabela `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `clientes`
--
ALTER TABLE `clientes`
  MODIFY `IdCliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT de tabela `locacaoveiculo`
--
ALTER TABLE `locacaoveiculo`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `locacoes`
--
ALTER TABLE `locacoes`
  MODIFY `IdLocacao` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `veiculos`
--
ALTER TABLE `veiculos`
  MODIFY `IdVeiculo` int(11) NOT NULL AUTO_INCREMENT;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `locacaoveiculo`
--
ALTER TABLE `locacaoveiculo`
  ADD CONSTRAINT `FK_LocacaoVeiculo_Locacoes_LocacaoIdLocacao` FOREIGN KEY (`LocacaoIdLocacao`) REFERENCES `locacoes` (`IdLocacao`),
  ADD CONSTRAINT `FK_LocacaoVeiculo_Veiculos_VeiculoIdVeiculo` FOREIGN KEY (`VeiculoIdVeiculo`) REFERENCES `veiculos` (`IdVeiculo`);

--
-- Limitadores para a tabela `locacoes`
--
ALTER TABLE `locacoes`
  ADD CONSTRAINT `FK_Locacoes_Clientes_ClienteIdCliente` FOREIGN KEY (`ClienteIdCliente`) REFERENCES `clientes` (`IdCliente`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
