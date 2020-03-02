# JSON-Convert
La classe Serializer a une fonction Serialize(o) qui prend un objet o de n'importe quel type de retourne un Dictionary<string, object>.
Les clefs du dictionnaire sont le nom des variables, la valeur est la valeur de cette variable (cela peut être un dictionnaire si la variable était un objet).
Deux classes de tests ont été créées pour tester la méthode Serialization : TestClass et TestClass2.
Dans le main, un objet TestClass est passé en paramètre de la fonction Serialization.
Le nom des variables utilisées permet de connaitre le type de variable. Exemples :
  "Pr_pub_int" est un attriut de la classe principale (TestClass), public et entier
  "Pr_pri_SsClasse" est un attribut de la classe principale, privé, qui est un objet de la "sous classe" TestClass2
  "Sc_pri_dbl" est un attribut de la "sous-classe", privé, de type double
La classe main cré un objet de la classe TestClass, qui contient des attributs de différents types primitifs, privés ou publics.
Cet objet contient également des liste et des objets de la classe TestClass2.
Après avoir créé cet objet, la fonction main affiche le dictionnaire retourné par la fonction  Serialize de la classe Serialization.
