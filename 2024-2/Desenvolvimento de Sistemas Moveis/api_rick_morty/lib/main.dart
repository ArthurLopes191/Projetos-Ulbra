import 'package:api_rick_morty/models/character.dart';
import 'package:api_rick_morty/services/character_service.dart';
import 'package:api_rick_morty/widgets/list_builder.dart';
import 'package:flutter/material.dart';

void main() {
  runApp(MyApp());
}

class MyApp extends StatefulWidget {
  const MyApp({super.key});

  @override
  State<MyApp> createState() => _MyAppState();
}

class _MyAppState extends State<MyApp> {

  String newFilter = "";



  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      home: Scaffold(
        appBar: AppBar(
          title: const Text("Personagens"),
        ),
        body: Column(
          children: [
            Padding(
              padding: const EdgeInsets.all(8.0),
              child: TextField(
          onChanged: (value){
            setState(() {
              newFilter = value;
            });
            /*var novaLista = lista
                .where((cadaItem) =>
                cadaItem.name.toLowerCase().contains(value)
                    .toList();
                setState(() {
                  listaFiltrados = novaLista;
                });*/
                },
                decoration: const InputDecoration(
                    border: OutlineInputBorder(), labelText: "Filtro"
                  ),
              ),
            ),
            ListBuilder(filter: newFilter,),
          ],
        ),
      ),
    );
  }
}