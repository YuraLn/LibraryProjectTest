# LibraryProjectTest
A library project based on Mvvm light,
Project will include classes: AbstructItem, Book and Journal will inherit from AbstructItem.
Book will include a unique key (ISBN) which will be genrerated by constructor on default
The client will be able to add or remove book or journal type items, the input will be stored inside ObservableCollection list.

Client will be able to View the book list in few options: 
1) All items overall (including Journal and Books),
2) Book list(Only),
3) Journal List(Only),
4) Show by Property (for example Book: Genere),

Client possible operations on data will include:
1) Add a new book
2) Add new Journal
3) Remove item (book or journal)
4) Sort by price (Asc/Des)
5) Serch by char

Project Notes:
Will need to be splitted in future to 3 Projects:  Model, View, ViewModel
