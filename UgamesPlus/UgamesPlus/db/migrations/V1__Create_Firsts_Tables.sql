CREATE TABLE IF NOT EXISTS `genero` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `nome` varchar(30) NOT NULL,
  PRIMARY KEY (`id`)
);

CREATE TABLE IF NOT EXISTS `jogo` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `nome` varchar(30) NOT NULL,
  PRIMARY KEY (`id`)
);

CREATE TABLE IF NOT EXISTS `tipo` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `descritivo` varchar(30) NOT NULL,
  PRIMARY KEY (`id`)
);


CREATE TABLE IF NOT EXISTS `plataforma` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `nome` varchar(30) NOT NULL,
  PRIMARY KEY (`id`)
);

CREATE TABLE IF NOT EXISTS `usuario` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `user_name` varchar(50) NOT NULL DEFAULT '0',
  `password` varchar(130) NOT NULL DEFAULT '0',
  `refresh_token` varchar(500) DEFAULT '0',
  `refresh_token_expiry_time` datetime DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `user_name` (`user_name`)
);

CREATE TABLE IF NOT EXISTS `post` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `id_tipo` bigint(20) NOT NULL,
  `id_usuario` bigint(20) NOT NULL,
  `id_jogo` bigint(20) NOT NULL,
  `conteudo` varchar(500) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `id_tipo` (`id_tipo`),
  KEY `id_usuario` (`id_usuario`),
  KEY `id_jogo` (`id_jogo`),
  CONSTRAINT `post_ibfk_1` FOREIGN KEY (`id_tipo`) REFERENCES `tipo` (`id`),
  CONSTRAINT `post_ibfk_2` FOREIGN KEY (`id_usuario`) REFERENCES `usuario` (`id`),
  CONSTRAINT `post_ibfk_3` FOREIGN KEY (`id_jogo`) REFERENCES `jogo` (`id`)
);

CREATE TABLE IF NOT EXISTS `jogo_genero` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `id_genero` bigint(20) NOT NULL,
  `id_jogo` bigint(20) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `id_genero` (`id_genero`),
  KEY `id_jogo` (`id_jogo`),
  CONSTRAINT `jogo_genero_ibfk_1` FOREIGN KEY (`id_genero`) REFERENCES `genero` (`id`),
  CONSTRAINT `jogo_genero_ibfk_2` FOREIGN KEY (`id_jogo`) REFERENCES `jogo` (`id`)
);

CREATE TABLE IF NOT EXISTS `jogo_plataforma` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `id_plataforma` bigint(20) NOT NULL,
  `id_jogo` bigint(20) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `id_plataforma` (`id_plataforma`),
  KEY `id_jogo` (`id_jogo`),
  CONSTRAINT `jogo_plataforma_ibfk_1` FOREIGN KEY (`id_plataforma`) REFERENCES `plataforma` (`id`),
  CONSTRAINT `jogo_plataforma_ibfk_2` FOREIGN KEY (`id_jogo`) REFERENCES `jogo` (`id`)
)