import 'package:flutter/material.dart';

List<String> languages = [
  'Dart',
  'Java',
  'Kotlin',
  'Swift',
  'Objective-C',
  'JavaScript',
  'Python',
  'C#',
  'C++',
  'Ruby',
  'Go',
  'Rust',
  'PHP',
  'TypeScript',
  'CSS',
  'SQL',
  'Shell',
  'Scala',
  'R',
  'Perl',
  'Haskell',
  'Lua',
  'Julia',
  'Groovy',
];


class Languages extends StatefulWidget {
  final String filter;
  const Languages({super.key, required this.filter});

  _filterLanguages(){
    return languages.where((element) => element.toLowerCase().contains(filter.toLowerCase())).toList();
  }
  @override
  State<Languages> createState() => _LanguagesState();
}

class _LanguagesState extends State<Languages> {

  List<String> languagesFiltered = [];

  @override
  void didUpdateWidget(Languages oldWidget) {
    if(oldWidget.filter != widget.filter){
      languagesFiltered = widget._filterLanguages();
    }
    super.didUpdateWidget(oldWidget);
  }

  @override
  void initState() {
    languagesFiltered = widget._filterLanguages();
    super.initState();
  }
  @override
  Widget build(BuildContext context) {
    return SizedBox(
      height: MediaQuery.of(context).size.height * 0.7,
      child: ListView.separated(
          itemBuilder: (BuildContext context, int indexLanguage) {
            return ListTile(
              leading: const Icon(Icons.rocket_launch_outlined),
              title: Text(languagesFiltered[indexLanguage]),
              subtitle: Text("Top"),
            );
          },
          separatorBuilder: (BuildContext context, int indexLanguage) {
            return Divider();
          },
          itemCount: languagesFiltered.length),
    );
  }
}
