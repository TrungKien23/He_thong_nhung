/* USER CODE BEGIN Header */
/**
  ******************************************************************************
  * @file           : main.h
  * @brief          : Header for main.c file.
  *                   This file contains the common defines of the application.
  ******************************************************************************
  * @attention
  *
  * Copyright (c) 2022 STMicroelectronics.
  * All rights reserved.
  *
  * This software is licensed under terms that can be found in the LICENSE file
  * in the root directory of this software component.
  * If no LICENSE file comes with this software, it is provided AS-IS.
  *
  ******************************************************************************
  */
/* USER CODE END Header */

/* Define to prevent recursive inclusion -------------------------------------*/
#ifndef __MAIN_H
#define __MAIN_H

#ifdef __cplusplus
extern "C" {
#endif

/* Includes ------------------------------------------------------------------*/
#include "stm32f1xx_hal.h"

/* Private includes ----------------------------------------------------------*/
/* USER CODE BEGIN Includes */

/* USER CODE END Includes */

/* Exported types ------------------------------------------------------------*/
/* USER CODE BEGIN ET */

/* USER CODE END ET */

/* Exported constants --------------------------------------------------------*/
/* USER CODE BEGIN EC */

/* USER CODE END EC */

/* Exported macro ------------------------------------------------------------*/
/* USER CODE BEGIN EM */

/* USER CODE END EM */

/* Exported functions prototypes ---------------------------------------------*/
void Error_Handler(void);

/* USER CODE BEGIN EFP */

/* USER CODE END EFP */

/* Private defines -----------------------------------------------------------*/
#define PHAI_Pin GPIO_PIN_3
#define PHAI_GPIO_Port GPIOA
#define XANH_Pin GPIO_PIN_6
#define XANH_GPIO_Port GPIOA
#define VANG_Pin GPIO_PIN_0
#define VANG_GPIO_Port GPIOB
#define DO_Pin GPIO_PIN_10
#define DO_GPIO_Port GPIOB
#define TRAI_Pin GPIO_PIN_14
#define TRAI_GPIO_Port GPIOB
#define DUNG_Pin GPIO_PIN_15
#define DUNG_GPIO_Port GPIOB
#define EN_Pin GPIO_PIN_11
#define EN_GPIO_Port GPIOA
#define XUNG_Pin GPIO_PIN_12
#define XUNG_GPIO_Port GPIOA
#define CHIEU_Pin GPIO_PIN_15
#define CHIEU_GPIO_Port GPIOA

/* USER CODE BEGIN Private defines */

/* USER CODE END Private defines */

#ifdef __cplusplus
}
#endif

#endif /* __MAIN_H */
