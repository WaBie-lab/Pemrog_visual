# Package GUI Tkinter
import tkinter as tk
from tkinter import ttk
from tkinter.messagebox import showinfo

app = tk.Tk()
app.configure(bg="white")
app.geometry("300x250")
app.resizable(False,False)
app.title("By Robby Awaludin")

# Function Rumus Belah Ketupat
def hitung():
    diagonal_1 = float(diagonal_1_entry.get())
    diagonal_2 = float(diagonal_2_entry.get())
    sisi = float(sisi_entry.get())
    
    luas = 0.5 * diagonal_1 * diagonal_2
    keliling = 4 * sisi
    
    showinfo("Hasil, By Robby Awaludin", "Luas        : {:.2f}\nKeliling   : {:.2f}".format(luas, keliling))
    
# Frame Input
input_frame = ttk.Frame(app)
# Penempatan (Grid, Place, Pack)
input_frame.pack(padx=10, pady=10, fill="x", expand=True)

# Komponen-komponen
diagonal_1_label = ttk.Label(input_frame, text="Menghitung Luas & Keliling Belah Ketupat")
diagonal_1_label.pack(padx=10, pady=20, fill="x", expand=True)
# 1. Label diagonal_1
diagonal_1_label = ttk.Label(input_frame, text="Masukkan diagonal 1 :")
diagonal_1_label.pack(padx=10, fill="x", expand=True)
# 2. Entry diagonal_1
diagonal_1_entry = ttk.Entry(input_frame)
diagonal_1_entry.pack(padx=10, fill="x", expand=True)
# 3. Label diagonal_2
diagonal_2_label = ttk.Label(input_frame, text="Masukkan diagonal 2 :")
diagonal_2_label.pack(padx=10, fill="x", expand=True)
# 4. Entry diagonal_2
diagonal_2_entry = ttk.Entry(input_frame)
diagonal_2_entry.pack(padx=10, fill="x", expand=True)
# 5. Label sisi
sisi_label = ttk.Label(input_frame, text="Masukkan sisi :")
sisi_label.pack(padx=10, fill="x", expand=True)
# 6. Entry sisi
sisi_entry = ttk.Entry(input_frame)
sisi_entry.pack(padx=10, fill="x", expand=True)
# 7. Tombol
tombol = ttk.Button(input_frame,text="Hitung", command=hitung)
tombol.pack(fill="x", expand="true", padx=80, pady=10)


app.mainloop()

