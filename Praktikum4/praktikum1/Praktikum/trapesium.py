# Package GUI Tkinter
import tkinter as tk
from tkinter import ttk
from tkinter.messagebox import showinfo

app = tk.Tk()
app.configure(bg="white")
app.geometry("300x430")
app.resizable(False,False)
app.title("By Robby Awaludin")

# Function Rumus Trapesium
def hitung():
    ab = float(ab_entry.get())
    cd = float(cd_entry.get())
    t = float(t_entry.get())
    ab = float(ab_entry.get())
    cd = float(cd_entry.get())
    bc = float(bc_entry.get())
    da = float(da_entry.get())
    
    luas = ((ab+cd)*t)/2
    keliling = ab + bc + cd + da
    showinfo("Hasil, by Robby Awaludin", f"Luas        : {luas} \nKeliling   : {keliling}")
    
    
# Frame Input
input_frame = ttk.Frame(app)
# Penempatan (Grid, Place, Pack)
input_frame.pack(padx=10, pady=10, fill="x", expand=True)

# Komponen-komponen
ab_label = ttk.Label(input_frame, text="Menghitung Luas & Keliling Trapesium")
ab_label.pack(padx=10, pady=20, fill="x", expand=True)
# 1. Label ab
ab_label = ttk.Label(input_frame, text="Masukkan sisi ab :")
ab_label.pack(padx=10, fill="x", expand=True)
# 2. Entry ab
ab_entry = ttk.Entry(input_frame)
ab_entry.pack(padx=10, fill="x", expand=True)
# 3. Label cd
cd_label = ttk.Label(input_frame, text="Masukkan sisi cd :")
cd_label.pack(padx=10, fill="x", expand=True)
# 4. Entry cd
cd_entry = ttk.Entry(input_frame)
cd_entry.pack(padx=10, fill="x", expand=True)
# 5. Label bc
bc_label = ttk.Label(input_frame, text="Masukkan sisi bc :")
bc_label.pack(padx=10, fill="x", expand=True)
# 6. Entry bc
bc_entry = ttk.Entry(input_frame)
bc_entry.pack(padx=10, fill="x", expand=True)
# 7. Label da
da_label = ttk.Label(input_frame, text="Masukkan sisi da :")
da_label.pack(padx=10, fill="x", expand=True)
# 8. Entry da
da_entry = ttk.Entry(input_frame)
da_entry.pack(padx=10, fill="x", expand=True)
# 9. Label t
t_label = ttk.Label(input_frame, text="Masukkan tinggi :")
t_label.pack(padx=10, fill="x", expand=True)
# 10. Entry t
t_entry = ttk.Entry(input_frame)
t_entry.pack(padx=10, fill="x", expand=True)
# 11. Tombol
tombol = ttk.Button(input_frame,text="Hitung", command=hitung)
tombol.pack(fill="x", expand="true", padx=80, pady=10)


app.mainloop()

