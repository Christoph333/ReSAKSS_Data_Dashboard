# ReSAKSS Data Challenge Projet

## Présentation

Ce projet contient une application Excel VSTO nommée **ResakssAddIn / ResakssOne** permettant d'accéder hors ligne aux données ReSAKSS et de les visualiser dans Excel.

L'objectif principal est de rendre les données ReSAKSS utilisables sans connexion Internet, avec une interface adaptée aux utilisateurs Excel, des graphiques interactifs et des exports vers Excel et image.

## Fonctionnalités principales

- Intégration directe dans Excel via un complément VSTO.
- Sélection de nombreux indicateurs ReSAKSS répartis en niveaux et catégories.
- Comparaison de pays sur plusieurs années.
- Visualisation via graphiques et cartes (LiveCharts).
- Export des données SQLite vers une feuille Excel.
- Enregistrement des graphiques et cartes au format image (PNG, JPG, etc.).
- Interface tabulaire contenant les résultats et les descriptions des données.

## Contenu du dépôt

- `ResakssAddIn.sln` : solution principale.
- `ResakssAddIn/` : projet principal du complément Excel.
- `WinFormsView/` : projet de vues WinForms.
- `WpfView/` : projet de vues WPF.
- `Core40/` : bibliothèque de charting et composants core.
- `CntProceduralTextures/` : outil graphique séparé.
- `Core/` : code de base et définitions pour les chartes.
- `Documentation du logiciel.pdf` : guide d'installation et de prise en main.
- `Application Executable/` : installation et fichiers de publication.

## Installation

### Installation en mode utilisateur

1. Ouvrez le dossier `Application Executable/`.
2. Double-cliquez sur `setup.exe`.
3. Suivez les étapes de l'installateur et acceptez l'installation.
4. Après installation, ouvrez Excel.
5. Un nouvel onglet **ResakssOne** doit apparaître dans le ruban Excel.

### Installation depuis le code source

1. Ouvrez `ResakssAddIn.sln` avec Visual Studio compatible .NET Framework 4.7.2.
2. Assurez-vous que le package `Microsoft.Data.Sqlite` et les références LiveCharts sont disponibles.
3. Compilez et déployez le complément VSTO.

## Utilisation

- Dans Excel, sélectionnez l'onglet **ResakssOne**.
- Choisissez un indicateur parmi les menus disponibles.
- Une nouvelle vue s'ouvre dans un onglet interne de l'application.
- Vous pouvez afficher les données, tracer des graphiques et exporter vers Excel.
- Utilisez les options de la barre d'outils pour enregistrer des images ou voir les données.

## Structure du flux d'exécution

- `ThisAddIn.cs` : code de démarrage du complément Excel.
- `rubanPrincipal.cs` : boutons du ruban Excel et sélection des indicateurs.
- `Form_Principal.cs` : création d'onglets pour chaque indicateur.
- `Form_BD.cs` : chargement des données SQLite, affichage des graphiques et des cartes.
- `DialogueForm.cs` : export des données vers Excel et affichage de la description des tables.

## Base de données

- `ResakssDB.db` : base de données SQLite embarquée contenant les données ReSAKSS.
- Le projet lit la base depuis `AppDomain.CurrentDomain.BaseDirectory`.

## Documentation

Ce README est une synthèse du document `Documentation du logiciel.pdf`, qui couvre notamment :

- l'objectif de l'application,
- les fonctionnalités principales,
- le guide d'installation,
- la prise en main du complément Excel,
- l'export des données vers Excel,
- l'enregistrement des graphiques et cartes.

## Notes importantes

- Le complément cible `Microsoft Excel` et nécessite l'environnement VSTO approprié.
- Le code utilise `.NET Framework 4.7.2`.
- Aucune licence explicite n'est fournie dans ce dépôt.

## Aide et support

Pour un guide détaillé, consultez `Documentation du logiciel.pdf`.
