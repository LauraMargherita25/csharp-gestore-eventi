// See https://aka.ms/new-console-template for more information

using csharp_gestore_eventi;

// evento -> id
//        -> data
//        -> posti totali
//        -> posti prenotati // lista di clienti prenotati?
//        -> posti ancora disponibili
//        -> concluso(se la data di oggi > data evento)


// Gestionale che gestisce gli eventi
//--lista eventi
//--()crea evento


//cliente -> ()prenota --> evento.numero prenotazioni +1
//        -> ()disdici --> evento.numero prenotazioni -1 ?? voglio evitaare che un cliente disdica senza aver mai prenotato 


Event nuovoEvento = new Event("aerosmith", DateTime.Now, 1000000);
Console.WriteLine(nuovoEvento.ToString());