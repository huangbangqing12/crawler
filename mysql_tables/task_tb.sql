CREATE TABLE `task_tb` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `url` varchar(200) NOT NULL,
  `mark` varchar(100) DEFAULT NULL,
  `type` int(11) NOT NULL COMMENT '0  picture\n1  text\n2 audio\n3 video',
  `link_reg` json DEFAULT NULL,
  `next_reg` json DEFAULT NULL,
  `craw_flag` int(11) NOT NULL DEFAULT '0' COMMENT '0  not craw\n1 crawed',
  `delete_flag` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`),
  UNIQUE KEY `id` (`id`),
  UNIQUE KEY `url` (`url`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
