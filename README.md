Facebook Analytics & Unity Ads
======

Temps passé
------
Environ 6h, incluant la recherche.

Choix techniques
------
Intégration de fonctions générique passant les paramètres des divers appels vers Unity Ads ou Facebook Analytics semblaient le plus indiqué pour le projet demandé. ScriptableObject utilisé afin de faciliter la configuration des placementId et gameId.

Difficultés rencontrées
------
La configuration d'une app Facebook et la réception des events a été particulièrement difficile dû au manque d'expérience avec l'environnement Facebook.

Possibilités d'amélioration
------
Intégrer un singleton regroupant des fonctions génériques pour les appels vers Unity Ads et Facebook API. Regrouper les calls vers Facebook Analytics dans une seule fonction comprenant des paramètres facultatifs pour rendre les différents évènements plus simples à appeler à partir d'une seule fonction.

Exemple des calls vers Facebook Analytics
------
https://gyazo.com/cab06b02def41adde0e59c94c5754ee9
