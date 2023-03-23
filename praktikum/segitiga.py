# Package GUI Tkinter
import tkinter as tk
from tkinter import ttk
from tkinter.messagebox import showinfo

app = tk.Tk()
app.configure(bg="white")
app.geometry("300x350")
app.resizable(False,False)
app.title("By Robby Awaludin")

# Function Rumus Segitiga
def hitung():
    alas = float(alas_entry.get())
    tinggi = float(tinggi_entry.get())
    sisi1 = float(sisi1_entry.get())
    sisi2 = float(sisi2_entry.get())
    sisi3 = float(sisi3_entry.get())
    
    luas = (alas * tinggi) / 2
    keliling = sisi1 + sisi2 + sisi3
    
    showinfo("Hasil, By Robby Awaludin", "Luas        : {:.2f}\nKeliling   : {:.2f}".format(luas, keliling))
    
# Frame Input
input_frame = ttk.Frame(app)
# Penempatan (Grid, Place, Pack)
input_frame.pack(padx=10, pady=10, fill="x", expand=True)

# Komponen-komponen
alas_label = ttk.Label(input_frame, text="Menghitung Luas & Keliling Segitiga")
alas_label.pack(padx=10, pady=20, fill="x", expand=True)
# 1. Label alas
alas_label = ttk.Label(input_frame, text="Masukkan alas :")
alas_label.pack(padx=10, fill="x", expand=True)
# 2. Entry alas
alas_entry = ttk.Entry(input_frame)
alas_entry.pack(padx=10, fill="x", expand=True)
# 3. Label tinggi
tinggi_label = ttk.Label(input_frame, text="Masukkan tinggi :")
tinggi_label.pack(padx=10, fill="x", expand=True)
# 4. Entry tinggi
tinggi_entry = ttk.Entry(input_frame)
tinggi_entry.pack(padx=10, fill="x", expand=True)
# 5. Label sisi1
sisi1_label = ttk.Label(input_frame, text="Masukkan sisi1 :")
sisi1_label.pack(padx=10, fill="x", expand=True)
# 6. Entry sisi1
sisi1_entry = ttk.Entry(input_frame)
sisi1_entry.pack(padx=10, fill="x", expand=True)
# 7. Label sisi2
sisi2_label = ttk.Label(input_frame, text="Masukkan sisi2 :")
sisi2_label.pack(padx=10, fill="x", expand=True)
# 8. Entry sisi2
sisi2_entry = ttk.Entry(input_frame)
sisi2_entry.pack(padx=10, fill="x", expand=True)
# 9. Label sisi3
sisi3_label = ttk.Label(input_frame, text="Masukkan sisi3 :")
sisi3_label.pack(padx=10, fill="x", expand=True)
# 10. Entry sisi3
sisi3_entry = ttk.Entry(input_frame)
sisi3_entry.pack(padx=10, fill="x", expand=True)
# 11. Tombol
tombol = ttk.Button(input_frame,text="Hitung", command=hitung)
tombol.pack(fill="x", expand="true", padx=80, pady=10)


app.mainloop()

