import sqlite3
from sqlite3 import Error


class Base:
    def __init__(self, file):
        try:
            self.connection = sqlite3.connect(file, check_same_thread=False)
            self.cursor = None
            print("Successfully connection!")
        except Error as e:
            print("ERROR: - ", e)

    def execute_write(self, query):
        self.cursor = self.connection.cursor()

        try:
            self.cursor.execute(query)
            self.connection.commit()
            print("Successfully write!")
        except Error as e:
            print("ERROR: - ", e)

    def execute_read(self, query):
        self.cursor = self.connection.cursor()

        try:
            self.cursor.execute(query)
            result = self.cursor.fetchall()
            return result
        except Error as e:
            print("ERROR: - ", e)
