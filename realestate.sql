/*
 Navicat Premium Dump SQL

 Source Server         : RealEstate
 Source Server Type    : MySQL
 Source Server Version : 80044 (8.0.44)
 Source Host           : localhost:3306
 Source Schema         : realestate

 Target Server Type    : MySQL
 Target Server Version : 80044 (8.0.44)
 File Encoding         : 65001

 Date: 22/12/2025 00:48:02
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for apartment
-- ----------------------------
DROP TABLE IF EXISTS `apartment`;
CREATE TABLE `apartment`  (
  `APARTMENT_ID` int NOT NULL AUTO_INCREMENT,
  `Metrage` int NOT NULL,
  `BuildYear` int NOT NULL,
  `Tabaghe` int NOT NULL,
  `BuildingName` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NULL DEFAULT NULL,
  `Address` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `RoomNumber` int NOT NULL,
  `Parking` tinyint(1) NOT NULL,
  `Anbary` tinyint(1) NOT NULL,
  `Asansor` tinyint(1) NOT NULL,
  PRIMARY KEY (`APARTMENT_ID`) USING BTREE,
  CONSTRAINT `apartment_ibfk_1` FOREIGN KEY (`APARTMENT_ID`) REFERENCES `property` (`Id`) ON DELETE CASCADE ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for land
-- ----------------------------
DROP TABLE IF EXISTS `land`;
CREATE TABLE `land`  (
  `LAND_ID` int NOT NULL AUTO_INCREMENT,
  `METRAGE` int NOT NULL,
  `MOJAVEZ` tinyint(1) NOT NULL,
  `ADDRESS` tinyint(1) NOT NULL,
  PRIMARY KEY (`LAND_ID`) USING BTREE,
  CONSTRAINT `land_ibfk_1` FOREIGN KEY (`LAND_ID`) REFERENCES `property` (`Id`) ON DELETE CASCADE ON UPDATE RESTRICT
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for property
-- ----------------------------
DROP TABLE IF EXISTS `property`;
CREATE TABLE `property`  (
  `Id` int NOT NULL AUTO_INCREMENT,
  `price` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `OwnerName` varchar(25) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `phoneNumber` varchar(11) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`Id`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for villa
-- ----------------------------
DROP TABLE IF EXISTS `villa`;
CREATE TABLE `villa`  (
  `VILLA_ID` int NOT NULL AUTO_INCREMENT,
  `LandMetrage` int NOT NULL,
  `BuildingMetrage` int NOT NULL,
  `BuildYear` int NOT NULL,
  `RoomNumber` int NOT NULL,
  `Address` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Parking` tinyint(1) NOT NULL,
  PRIMARY KEY (`VILLA_ID`) USING BTREE,
  CONSTRAINT `villa_ibfk_1` FOREIGN KEY (`VILLA_ID`) REFERENCES `property` (`Id`) ON DELETE CASCADE ON UPDATE RESTRICT
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_0900_ai_ci ROW_FORMAT = Dynamic;

SET FOREIGN_KEY_CHECKS = 1;
