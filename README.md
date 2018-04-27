# DEMO GAB Curitiba 2018

Esta é uma demo que utilizei na palestra **Monitorando APIs com Application Insights** no Global Azure BootCamp em Curitiba, no dia 21/04/2018.

Para execução, é necessário um servidor SQL Server, com a seguinte tabela, e inserir alguns dados de exemplo.

**NCM**

Campo | Tipo | Tamanho | Extras
----- | ---- | ------- | ------
Id | Integer | - | Identity(1,1) PK
Chapter | Varchar | 255 | -
ChapterDescription | Varchar | 255 | -
Position | Varchar | 255 | -
PositionDescription | Varchar | 255 | -
SubPosition | Varchar | 255 | -
SubPositionDescription | Varchar | 255 | -
Item | Varchar | 255 | -
ItemDescription | Varchar | 255 | -
SubItem | Varchar | 255 | -
SubItemDescription | Varchar | 255 | -
Unit | Varchar | 255 | -
UnitDescription | Varchar | 255 | -
LastUpdate | DateTime | - | -

**Application Insights**

É necessário criar um Application Insights em sua conta do Azure, anotar o Instrumentation Key e alterar no arquivo appsettings.json.
