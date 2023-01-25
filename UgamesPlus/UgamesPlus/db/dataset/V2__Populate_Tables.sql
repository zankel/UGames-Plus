INSERT INTO `genero` (`id`, `nome`) VALUES
	(2, 'Arcade'),
	(3, 'Terror'),
	(4, 'Corrida'),
	(5, 'Ação');

INSERT INTO `jogo` (`id`, `nome`) VALUES
	(1, 'Silent Hill 2'),
	(2, 'Gran Turismo 7');

INSERT INTO `tipo` (`id`, `descritivo`) VALUES
	(1, 'Tutorial'),
	(2, 'Curiosidade'),
	(3, 'Ajuda');


INSERT INTO `plataforma` (`id`, `nome`) VALUES
	(1, 'PC'),
	(2, 'Xbox Series'),
	(3, 'Play Station 5');

INSERT INTO `jogo_plataforma` (`id`, `id_plataforma`, `id_jogo`) VALUES
	(1, 1, 1),
	(2, 3, 1);

INSERT INTO `usuario` (`id`, `user_name`, `password`, `refresh_token`, `refresh_token_expiry_time`) VALUES
	(1, 'zanke', '24-0B-E5-18-FA-BD-27-24-DD-B6-F0-4E-EB-1D-A5-96-74-48-D7-E8-31-C0-8C-8F-A8-22-80-9F-74-C7-20-A9', 'h9lzVOoLlBoTbcQrh/e16/aIj+4p6C67lLdDbBRMsjE=', '2020-09-27 17:30:49');

INSERT INTO `post` (`id`, `id_tipo`, `id_usuario`, `id_jogo`, `conteudo`) VALUES
	(1, 2, 1, 1, 'Ao zerar pela primeira vez no começo do proximo save aparecera uma serra eletrica'),
	(2, 3, 1, 2, 'Como liberar Bugat Raro?');


