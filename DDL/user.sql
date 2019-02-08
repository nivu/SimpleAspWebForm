CREATE SCHEMA `simple_asp_form` ;

CREATE TABLE `simple_asp_form`.`user` (
  `id` INT NOT NULL,
  `first_name` VARCHAR(45) NULL,
  `mobile` VARCHAR(15) NULL,
  `email` VARCHAR(30) NULL,
  PRIMARY KEY (`id`));

  ALTER TABLE `simple_asp_form`.`user` 
CHANGE COLUMN `id` `id` INT(11) NOT NULL AUTO_INCREMENT ;

