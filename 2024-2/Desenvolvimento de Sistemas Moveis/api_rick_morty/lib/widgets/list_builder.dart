import 'package:api_rick_morty/widgets/lista_characters.dart';
import 'package:flutter/material.dart';

import '../models/character.dart';
import '../services/character_service.dart';

class ListBuilder extends StatefulWidget{

  final String filter;
  const ListBuilder({required this.filter});
  @override
  State<ListBuilder> createState() => _ListBuilderState();
}

class _ListBuilderState extends State<ListBuilder> {

  // FUTURE
  late Future<List<Character>> listaFuture;

  late List<Character> lista = List.empty();
  late List<Character> listaFiltrados = List.empty();

  @override
  void initState() {
    super.initState();
    var service = CharacterService();
    listaFuture = service.getCharacters();
  }

  @override
  void didUpdateWidget(covariant ListBuilder oldWidget) {
    if(oldWidget.filter != widget.filter){
      listaFiltrados = lista
          .where((cadaItem) =>
          cadaItem.name.toLowerCase().contains(widget.filter))
          .toList();
    }
  }


  @override
  Widget build(BuildContext context) {
    return FutureBuilder<List<Character>>(
        future: listaFuture,
        builder: (context, snapshot) {
          if (snapshot.hasData) {
            if(lista.isEmpty){
              lista = snapshot.data ?? List.empty();

            }
            return Expanded(
              child: ListaCharacters(lista: listaFiltrados),
            );
          }

          if (snapshot.hasError) {
            debugPrint(snapshot.error.toString());
            return Text("Error");
          }

          return Center(child: CircularProgressIndicator());
        },
    );
  }
}

