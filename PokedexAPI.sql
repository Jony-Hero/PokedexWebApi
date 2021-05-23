-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 23-05-2021 a las 20:35:33
-- Versión del servidor: 8.0.21
-- Versión de PHP: 7.3.21




--
-- Base de datos: `pokedexapi`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pokemones`
--

CREATE DATABASE pokedexapi;
USE pokedexapi;

DROP TABLE IF EXISTS `pokemones`;
CREATE TABLE IF NOT EXISTS `pokemones` (
  `NumeroP` int NOT NULL,
  `Nombre` varchar(45) DEFAULT NULL,
  `Descripcion` varchar(500) DEFAULT NULL,
  `Altura` double DEFAULT NULL,
  `Peso` double DEFAULT NULL,
  `Categoria` varchar(45) DEFAULT NULL,
  `Habilidad` varchar(45) DEFAULT NULL,
  `Tipo` varchar(45) DEFAULT NULL,
  `Imagen` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`NumeroP`)
);

--
-- Volcado de datos para la tabla `pokemones`
--

INSERT INTO `pokemones` (`NumeroP`, `Nombre`, `Descripcion`, `Altura`, `Peso`, `Categoria`, `Habilidad`, `Tipo`, `Imagen`) VALUES
(1, 'Bulbasaur', 'Desde que nace, crece alimentándose de los nutrientes que contiene la semilla de su lomo.', 0.7, 6.9, 'Semilla', 'Espesura', 'Planta', 'https://assets.pokemon.com/assets/cms2/img/pokedex/full/001.png'),
(3, 'Venusaur', 'La planta florece cuando absorbe energía solar, lo cual le obliga a buscar siempre la luz del sol.', 2, 100, 'Semilla', 'Espesura', 'Planta,Veneno', 'https://assets.pokemon.com/assets/cms2/img/pokedex/full/003.png'),
(2, 'Ivysaur', 'La luz del sol lo fortalece y hace que le crezca el capullo que tiene en el lomo.', 1, 13, 'Semilla', 'Espesura', 'Planta', 'https://assets.pokemon.com/assets/cms2/img/pokedex/full/002.png'),
(4, 'Charmander', 'Prefiere las cosas calientes. Dicen que cuando llueve le sale vapor de la punta de la cola.', 0.6, 8.5, 'Lagartija', 'Mar Llamas', 'Fuego', 'https://assets.pokemon.com/assets/cms2/img/pokedex/full/004.png'),
(5, 'Charmeleon', 'Este Pokemon de naturaleza agresiva ataca en combate con su cola llameante y hace trizas al rival con sus afiladas garras.', 1.1, 19, 'LLamas', 'Mar Llamas', 'Fuego', 'https://assets.pokemon.com/assets/cms2/img/pokedex/full/005.png'),
(6, 'Charizard', 'Escupe un fuego tan caliente que funde las rocas. Causa incendios forestales sin querer.', 1.7, 90.5, 'LLamas', 'Mar LLamas', 'Fuego,Volador', 'https://assets.pokemon.com/assets/cms2/img/pokedex/full/006.png'),
(7, 'Squirtle', 'Cuando retrae su largo cuello en el caparazón, dispara agua a una presión increíble.', 0.5, 9, 'Tortuguita', 'Torrente', 'Agua', 'https://assets.pokemon.com/assets/cms2/img/pokedex/full/007.png'),
(8, 'Wartortle', 'Se lo considera un símbolo de longevidad. Los ejemplares más ancianos tienen musgo sobre el caparazón.', 1, 22.5, 'Tortuga', 'Torrente', 'Agua', 'https://assets.pokemon.com/assets/cms2/img/pokedex/full/008.png'),
(9, 'Blastoise', 'Dispara chorros de agua a través de los cañones de su caparazón, capaces de agujerear incluso el acero.', 1.6, 85.5, 'Armazon', 'Torrente', 'Agua', 'https://assets.pokemon.com/assets/cms2/img/pokedex/full/009.png'),
(10, 'Pikachu', 'Cuanto más potente es la energía eléctrica que genera este Pokémon, más suaves y elásticas se vuelven las bolsas de sus mejillas.', 0.4, 6, 'Raton', 'Electricidad Estática', 'Electrico', 'https://assets.pokemon.com/assets/cms2/img/pokedex/full/025.png');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE IF NOT EXISTS `usuarios` (
  `username` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  PRIMARY KEY (`username`)
);

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`username`, `password`) VALUES
('Jony', 'Excaliburth'),
('pipo', 'Pipo123'),
('lony', 'Thanos123');
