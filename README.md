# Classe Client - Crédit-Céleste

## Vue d'ensemble

La classe **Client** gère les informations des clients du garage, notamment leur civilité, nom, et prénom. Elle permet de créer des objets **Client** avec différents niveaux de détails selon les constructeurs, et offre des méthodes pour accéder et modifier ces informations.

## Attributs

- **civClient** : Civilité du client (ex. : "Mr", "Mme").
- **nomClient** : Nom de famille du client.
- **prenomClient** : Prénom du client.

## Constructeurs

1. **Client()** : Initialise un client avec des valeurs par défaut ("Mr", "Soares", "Daniels").
   ```csharp
   Client client = new Client();
   ```

2. **Client(string civClient)** : Initialise un client avec une civilité spécifiée, et des valeurs par défaut pour le nom et le prénom.
   ```csharp
   Client client = new Client("Mme");
   ```

3. **Client(string civClient, string nomClient)** : Initialise un client avec une civilité et un nom spécifiés, et un prénom par défaut.
   ```csharp
   Client client = new Client("Mr", "Dupont");
   ```

4. **Client(string civClient, string nomClient, string prenomClient)** : Initialise un client avec une civilité, un nom, et un prénom spécifiés.
   ```csharp
   Client client = new Client("Mme", "Martin", "Julie");
   ```

## Méthodes

1. **setClient(string civClient, string nomClient, string prenomClient)** : Permet de mettre à jour les informations d'un client.
   ```csharp
   client.setClient("Mr", "Durand", "Paul");
   ```

2. **getCivClient()** : Retourne la civilité du client.
   ```csharp
   string civilite = client.getCivClient();
   ```

3. **getNomClient()** : Retourne le nom de famille du client.
   ```csharp
   string nom = client.getNomClient();
   ```

4. **getPrenomClient()** : Retourne le prénom du client.
   ```csharp
   string prenom = client.getPrenomClient();
   ```

## Exemple d'utilisation

```csharp
// Création d'un client avec le constructeur par défaut
Client client1 = new Client();

// Création d'un client avec une civilité personnalisée
Client client2 = new Client("Mme");

// Création d'un client avec une civilité et un nom
Client client3 = new Client("Mr", "Dupont");

// Création d'un client avec toutes les informations
Client client4 = new Client("Mme", "Martin", "Julie");

// Mise à jour des informations d'un client
client4.setClient("Mr", "Durand", "Paul");

// Récupération des informations du client
string civ = client4.getCivClient();
string nom = client4.getNomClient();
string prenom = client4.getPrenomClient();
```
