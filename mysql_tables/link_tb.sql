CREATE TABLE `link_tb` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `url` varchar(200) NOT NULL,
  `href` varchar(200) DEFAULT NULL,
  `craw_flag` int(11) NOT NULL DEFAULT '0',
  `reg` json DEFAULT NULL,
  `delete_flag` int(11) DEFAULT '0',
  PRIMARY KEY (`id`),
  UNIQUE KEY `href` (`href`)
) ENGINE=InnoDB AUTO_INCREMENT=73 DEFAULT CHARSET=utf8 COMMENT='资源链接地址表';
