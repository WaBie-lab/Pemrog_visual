# Package GUI Tkinter
import tkinter as tk
from tkinter import ttk
from tkinter.messagebox import showinfo

app = tk.Tk()
app.configure(bg="white")
app.geometry("300x200")
app.resizable(False,False)
app.title("By Robby Awaludin")

# Function Rumus Lingkaran
def hitung():
    jari_jari = float(jari_jari_entry.get())
    
    luas = 22/7 * jari_jari ** 2
    keliling = 2 * 22/7 * jari_jari
    
   
    
    showinfo("Hasil, By Robby Awaludin", "Luas        : {:.2f}\nKeliling   : {:.2f}".format(luas, keliling))
    
# Frame Input
input_frame = ttk.Frame(app)
# Penempatan (Grid, Place, Pack)
input_frame.pack(padx=10, pady=10, fill="x", expand=True)

# Komponen-komponen
jari_jari_label = ttk.Label(input_frame, text="Menghitung Luas & Keliling Lingkaran")
jari_jari_label.pack(padx=10, pady=20, fill="x", expand=True)
# 1. Label jari_jari
jari_jari_label = ttk.Label(input_frame, text="Masukkan jari_jari :")
jari_jari_label.pack(padx=10, fill="x", expand=True)
# 2. Entry jari_jari
jari_jari_entry = ttk.Entry(input_frame)
jari_jari_entry.pack(padx=10, fill="x", expand=True)
# 3. Tombol
tombol = ttk.Button(input_frame,text="Hitung", command=hitung)
tombol.pack(fill="x", expand="true", padx=80, pady=10)


app.mainloop()

