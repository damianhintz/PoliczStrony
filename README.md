StronyA4 v1.4-beta, 21 listopada 2016
---
Policz strony A4 w plikach pdf lub jpg

# Cechy

* zliczanie stron A4 w plikach pdf (strony mniejsze od A4 traktowane są jak jedna strona A4)
* zliczanie stron A4 w plikach jpg

# Pomoc

Roboczy katalog:

StronyA4.exe [roboczy katalog] [rodzaj plików] [formaty stron]

Bez żadnych parametrów, wtedy przeliczy jeszcze raz z wcześniej utworzonego pliku StronyA4.tab:

StronyA4.exe

StronyA4.exe c:\Strony *.jpg

StronyA4.exe c:\Strony *.jpg A0,A1,A2,A3,A4

# Historia

Do zrobienia

2016-11-21 v1.4-beta

* [ ] nowość: zliczanie stron A4 w plikach jpg

2015-09-21 v1.3.2

* aktualizacja: aktualizacja iTextSharp do wersji 5.5.7
* poprawka: zapis formatu strony w pliku wynikowym

2015-08-04 v1.3.1

* aktualizacja: aktualizacja iTextSharp do wersji 5.5.6
* poprawka: aktualizacja nagłówka wynikowego pliku tab (dodanie jednostek rozmiaru punkty i zamiana cm na mm)

2015-08-03 v1.3

* aktualizacja: wykorzystanie tej samej metody przeliczania stron (wcześniej zastosowa była inna funkcja podczas przeliczania stron z pliku i z folderu)

2015-06-29 v1.2

* nowa funkcja: oczekiwany czas do końca

2015-06-16 v1.1

* nowa funkcja: zastosowanie metryki odległości do określania formatu strony (strony mniejsze od A4 traktowane są jak jedna strona A4)
* aktualizacja: nowy format pliku wyjściowego: Nazwa pliku| Numer strony | Wysokość | Szerokość | Wysokość[cm] | Szerokość[cm] | Format arkusza | Liczba stron A4

2015-06-15 v1.0.1

* aktualizacja: wyświetlenie liczby stron w bieżącym pliku
* aktualizacja: dodanie do pliku nagłówka 'max_size'

2014-07-02 v1.0-beta

* pierwsza wersja
