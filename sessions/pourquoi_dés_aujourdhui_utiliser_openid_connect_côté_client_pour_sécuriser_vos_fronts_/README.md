# Pourquoi dés aujourd'hui utiliser OpenID Connect côté client pour sécuriser vos fronts ?

## Description

Vous créez à chaque fois un BFF (Back End For Front End) pour gérer l’authentification côté front ? Cela peut réduire votre « Time To Market », vous coûter plus cher que nécessaire et n’est aujourd’hui pas forcément plus sécurisé.

Dans cette présentation qui sera assez technique, nous allons vous présenter le protocole OpenID Connect. L’architecture de l’OIDC côté client ainsi que son concurrent et ami côté serveur. Nous expliquerons avec beaucoup de démos comment fonctionnent les échanges de clés JWT. Nous décrirons les avantages et inconvénients de chaque mode.

Ensuite, nous expliquerons toujours avec des démos pourquoi @axa-fr/oidc-client le mode avec l'utilisation du ServiceWorker est super sécurisé. Finalement, nous terminerons par expliquer le concept de « Demonstrating Proof of Possession » (DPoP) qui est une "killer feature" et qui rend vos "tokens" inutilisables hors du contexte navigateur, tout cela grâce à l’API WebCrypto.

Préparez vos cerveaux, ce sera pédagogique et progressif, mais restera très technique.

## Speakers

- [Speaker Name](https://x.com/speaker_x_handle)
- [Speaker LinkedIn](https://linkedin.com/in/speaker_linkedin_handle)
- [Speaker Company](https://speaker_company_url)
