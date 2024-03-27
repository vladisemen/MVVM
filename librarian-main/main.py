from fastapi import FastAPI
from fastapi.responses import FileResponse
from base.tools.sqliter import Base
from random import randint

app = FastAPI()

base = Base("base/books.sqlite")


@app.get("/")
def root():
    return FileResponse("template/root.html")


@app.get("/books/{id}")
def read_root(id: int):
    book = base.execute_read(f"SELECT * from books WHERE rowid = {id}")
    if book:
        return {"title": book[0][0],
                "authors": book[0][1],
                "description": book[0][2],
                "category": book[0][3],
                "publisher": book[0][4],
                "price": book[0][5],
                "month": book[0][6],
                "year": book[0][7]}
    else:
        return {"title": "Not Found"}


@app.get("/books/")
def books_params(genre: str = "", author: str = "", year: str = ""):
    conditions = []

    if genre:
        genre = " " + genre + " "
        conditions.append(f"category = '{genre}'")
    if author:
        author = " " + author
        conditions.append(f"authors = '{author}'")
    if year:
        conditions.append(f"year = '{year}'")

    where_clause = " AND ".join(conditions)
    if where_clause:
        execute = f"SELECT * from books WHERE {where_clause}"
    else:
        execute = "SELECT * from books"

    book = base.execute_read(execute)
    print(execute)
    if book:
        indexation = randint(0, len(book) - 1)
        return {"title": book[indexation][0],
                "authors": book[indexation][1],
                "description": book[indexation][2],
                "category": book[indexation][3],
                "publisher": book[indexation][4],
                "price": book[indexation][5],
                "month": book[indexation][6],
                "year": book[indexation][7]}
    else:
        return {"title": "Not Found"}
