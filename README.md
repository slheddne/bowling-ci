# Intégration continue sur le projet Kata Bowling

## Équipe
Notre équipe est composée des membres suivants :
- Salah-Eddine ET-TALEBY
- Elias OMARI
- Valentin DEVAUD
- Mathis FLINOIS
- Loïc RAULIN

## Choix de l'outil d'intégration continue
Pour mener à bien ce projet, le choix d'un client lourd nous a été imposé.
Nous avons donc opté pour l'outil TeamCity développé par JetBrains, dans sa version professionnelle et gratuite pour tous les usages (même commerciaux).

TeamCity, à l'instar de ses concurrents (Jenkins, CircleCI, Bitbucket, etc.), offre énormément de possibilités et de fonctionnalités pour faire de l'intégration continue.

En effet, avec cet outil, il est possible de configurer l'intégration continue de son projet en spécifiant toutes les étapes (création de pipelines, hooks...). Il fournit des tests unitaires continus prêts à l'emploi, une analyse de la qualité du code et des rapports rapides sur les problèmes de génération et propose également une prise en charge du framework .NET pour être intégré à plusieurs IDE comme Eclipse, Visual Studio, etc.

Teamcity est facilement configurable et son interface graphique le rend assez simple d'utilisation.

Enfin, TeamCity dispose d'une communauté assez large et est bien documenté.

C'est pour ces raisons que nous avons décidé de choisir cette solution.

