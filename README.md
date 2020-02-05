# ArticleApi
Jeg har tilføjet et id til artiklerne for at have et klar kriterie til at slette samt lookup i forhold til.
i en general applikation skal der højst sandsynligt være checks der sikkre id er unikke.
Man kan få en fuld liste af articles med en get request /api/Article.
Man kan få en specifik med /api/Article/# hvor # representere id et på artiklen du leder efter.
Man kan slette med /api/Article/# hvor # representere id et på artiklen du vil slette.
En post request forventer at få et article object med i bodyen i et json format eller lign.
For at lave en effectiv søgemaskine burde man vægte forskellige information forskelligt så som titel og forfatter vægtes højere end brødtekst.
Samtidig vil man vægte mere almindelige ord lavere en mere område specifikke ord.
Derudover er data lavet i filen og nulstilles efter hvert kald i en reel situation ville man gemme det i en fil.

