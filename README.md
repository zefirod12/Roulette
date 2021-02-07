Este programa fue creado por Miguel Daniel Arturo Ariza Quintero.
Todos los derechos Reservados.

Endpoints:

Agregar Ruleta:
http://localhost:11951/api/CreationRoulette/Add

{
"Name": "Miguel",
"LastName": "Ariza"
}

Abrir Ruleta:
http://localhost:11951/api/CreationRoulette/Open

{
"Id": "1"
}

Consultar Ruleta:
http://localhost:11951/api/CreationRoulette/Bet
{
"Selection": "2",
"Number": "17",
"color" : "white",
"Money" : "5000"
}

