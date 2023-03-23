# Package GUI Tkinter
import tkinter as tk
from tkinter import ttk
from tkinter.messagebox import showinfo

app = tk.Tk()
app.configure(bg="white")
app.geometry("300x400")
app.resizable(False,False)
app.title("By Robby Awaludin")

# Function Rumus Layang - Layang
def hitung():
    diagonal_1 = float(diagonal_1_entry.get())
    diagonal_2 = float(diagonal_2_entry.get())
    sisi_1 = float(sisi_1_entry.get())
    sisi_2 = float(sisi_2_entry.get())
    sisi_3 = float(sisi_3_entry.get())
    sisi_4 = float(sisi_4_entry.get())
    
    luas = (diagonal_1 * diagonal_2) / 2
    keliling = sisi_1 + sisi_2 + sisi_3 + sisi_4
    
    showinfo("Hasil, By Robby Awaludin", "Luas        : {:.2f}\nKeliling   : {:.2f}".format(luas, keliling))
    
# Frame Input
input_frame = ttk.Frame(app)
# Penempatan (Grid, Place, Pack)
input_frame.pack(padx=10, pady=10, fill="x", expand=True)

# Komponen-komponen
diagonal_1_label = ttk.Label(input_frame, text="Menghitung Luas & Keliling Layang - Layang")
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
# 5. Label sisi_1
sisi_1_label = ttk.Label(input_frame, text="Masukkan sisi 1 :")
sisi_1_label.pack(padx=10, fill="x", expand=True)
# 6. Entry sisi_1
sisi_1_entry = ttk.Entry(input_frame)
sisi_1_entry.pack(padx=10, fill="x", expand=True)
# 7. Label sisi_2
sisi_2_label = ttk.Label(input_frame, text="Masukkan sisi 2 :")
sisi_2_label.pack(padx=10, fill="x", expand=True)
# 8. Entry sisi_2
sisi_2_entry = ttk.Entry(input_frame)
sisi_2_entry.pack(padx=10, fill="x", expand=True)
# 9. Label sisi_3
sisi_3_label = ttk.Label(input_frame, text="Masukkan sisi 3 :")
sisi_3_label.pack(padx=10, fill="x", expand=True)
# 10. Entry sisi_3
sisi_3_entry = ttk.Entry(input_frame)
sisi_3_entry.pack(padx=10, fill="x", expand=True)
# 11. Label sisi_4
sisi_4_label = ttk.Label(input_frame, text="Masukkan sisi 4 :")
sisi_4_label.pack(padx=10, fill="x", expand=True)
# 12. Entry sisi_4
sisi_4_entry = ttk.Entry(input_frame)
sisi_4_entry.pack(padx=10, fill="x", expand=True)
# 13. Tombol
tombol = ttk.Button(input_frame,text="Hitung", command=hitung)
tombol.pack(fill="x", expand="true", padx=80, pady=10)


app.mainloop()

