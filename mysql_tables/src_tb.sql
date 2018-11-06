CREATE TABLE `src_tb` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `href` varchar(300) NOT NULL,
  `flag` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`),
  UNIQUE KEY `href` (`href`)
) ENGINE=InnoDB AUTO_INCREMENT=198 DEFAULT CHARSET=utf8;
