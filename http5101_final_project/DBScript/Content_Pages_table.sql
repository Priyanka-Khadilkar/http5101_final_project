
CREATE TABLE `content_pages` (
  `page_id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `pagetitle` varchar(255) DEFAULT NULL,
  `pagebody` mediumtext DEFAULT NULL,
  `publishdate` datetime NOT NULL,
  PRIMARY KEY (`page_id`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4