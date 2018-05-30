# DEMO GAB Curitiba 2018

Esta é uma demo que utilizei na palestra **Monitorando APIs com Application Insights** no Global Azure BootCamp em Curitiba, no dia 21/04/2018.

Para execução, é utilizado um arquivo de banco de dados do SQLite. Abaixo a tabela do banco:

**NCM**

Campo | Tipo | Tamanho | Extras
----- | ---- | ------- | ------
Id | Integer | - | Identity(1,1) PK
Code | Varchar | 255 | -
Description | Varchar | 255 | -

**Application Insights**

É necessário criar um Application Insights em sua conta do Azure, anotar o Instrumentation Key e alterar no arquivo appsettings.json.
