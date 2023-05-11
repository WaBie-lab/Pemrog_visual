# Package GUI Tkinter
import tkinter as tk
from tkinter import ttk
from tkinter.messagebox import showinfo

app = tk.Tk()
app.configure(bg="white")
app.geometry("300x200")
app.resizable(False,False)
app.title("By Robby Awaludin")

# Function Rumus Persegi / Bujur Sangkar
def hitung():
    sisi = float(sisi_entry.get())
    
    luas = sisi ** 2
    keliling = 4 * sisi
    
    showinfo("Hasil, By Robby Awaludin", "Luas        : {:.2f}\nKeliling   : {:.2f}".format(luas, keliling))
    
# Frame Input
input_frame = ttk.Frame(app)
# Penempatan (Grid, Place, Pack)
input_frame.pack(padx=10, pady=10, fill="x", expand=True)

# Komponen-komponen
sisi_label = ttk.Label(input_frame, text="Menghitung Luas & Keliling Persegi")
sisi_label.pack(padx=10, pady=20, fill="x", expand=True)
# 1. Label sisi
sisi_label = ttk.Label(input_frame, text="Masukkan sisi :")
sisi_label.pack(padx=10, fill="x", expand=True)
# 2. Entry sisi
sisi_entry = ttk.Entry(input_frame)
sisi_entry.pack(padx=10, fill="x", expand=True)
# 3. Tombol
tombol = ttk.Button(input_frame,text="Hitung", command=hitung)
tombol.pack(fill="x", expand="true", padx=80, pady=10)


app.mainloop()

