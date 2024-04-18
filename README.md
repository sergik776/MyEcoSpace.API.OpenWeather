#MyEcoSpace.API.OpenWeather
Library for OpenWeather API client

##Description
This library is necessary for retrieving weather data from the OpenWeather API resource.

##Configuration
Create an appconfig.json file next to the executable file with the following structure:
```json
Copy code
{
    "APIKey": "",
    "BaseAddress": "api.openweathermap.org"
}
```
Where APIKey is your key, which can be generated in your personal account after registration.

##Examples
```csharp
Copy code
OpenWeather OP = new OpenWeather();
var result = await OP.FiveDaysThreeHours("40.730610","-73.935242");
Console.WriteLine(result.ToString());
```
Where "40.730610" and "-73.935242" are the coordinates of New York.

##License
This project is distributed under the [MIT](https://opensource.org/licenses/MIT) license, which allows free use, modification, and distribution of the code in accordance with the terms of the MIT license.

# MyEcoSpace.API.OpenWeather
Библиотека клиента OpenWeather API

## Описание
Библиотека необходимая для получения погоды с API ресурса OpenWeather.

## Настройка
Создать файл appconfig.json рядом с исполняемым файлом, с следующей структурой:
```json
{
    "APIKey": "",
    "BaseAddress": "api.openweathermap.org"
}
```
Где APIKey ваш ключ, который можно сгенерировать в личном кабинете после регистрации.

## Примеры
```csharp
OpenWeather OP = new OpenWeather();
var result = await OP.FiveDaysThreeHours("40.730610","-73.935242");
Console.WriteLine(result.ToString());
```
Где "40.730610" и "-73.935242" - координаты Нью-Йорка

## Лицензия
Этот проект распространяется под лицензией [MIT](https://opensource.org/licenses/MIT), которая разрешает свободное использование, изменение и распространение кода в соответствии с условиями лицензии MIT.