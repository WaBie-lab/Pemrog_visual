# Package GUI Tkinter
import tkinter as tk
from tkinter import ttk
from tkinter.messagebox import showinfo

app = tk.Tk()
app.configure(bg="white")
app.geometry("300x250")
app.resizable(False,False)
app.title("By Robby Awaludin")

# Function Rumus Persegi Panjang
def hitung():
    panjang = float(panjang_entry.get())
    lebar = float(lebar_entry.get())
    
    luas = panjang * lebar
    keliling = 2 * (panjang + lebar)
    
    showinfo("Hasil, By Robby Awaludin", "Luas        : {:.2f}\nKeliling   : {:.2f}".format(luas, keliling))
    
# Frame Input
input_frame = ttk.Frame(app)
# Penempatan (Grid, Place, Pack)
input_frame.pack(padx=10, pady=10, fill="x", expand=True)

# Komponen-komponen
panjang_label = ttk.Label(input_frame, text="Menghitung Luas & Keliling Persegi Panjang")
panjang_label.pack(padx=10, pady=20, fill="x", expand=True)
# 1. Label Panjang
panjang_label = ttk.Label(input_frame, text="Masukkan Panjang :")
panjang_label.pack(padx=10, fill="x", expand=True)
# 2. Entry Panjang
panjang_entry = ttk.Entry(input_frame)
panjang_entry.pack(padx=10, fill="x", expand=True)
# 3. Label Lebar
lebar_label = ttk.Label(input_frame, text="Masukkan Lebar :")
lebar_label.pack(padx=10, fill="x", expand=True)
# 4. Entry Lebar
lebar_entry = ttk.Entry(input_frame)
lebar_entry.pack(padx=10, fill="x", expand=True)
# 5. Tombol
tombol = ttk.Button(input_frame,text="Hitung", command=hitung)
tombol.pack(fill="x", expand="true", padx=80, pady=10)


app.mainloop()

