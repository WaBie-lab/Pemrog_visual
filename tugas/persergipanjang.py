#Robby Awaludin
#R3
#200511012
from tkinter import Frame,Label,Entry,Button,YES,BOTH,END,Tk,W

class Persegipanjang:
    def __init__(self,panjang,lebar):
        self.panjang = panjang
        self.lebar = lebar
    def luas(self):
        return self.panjang*self.lebar
    def keliling(self):
        return 2*(self.panjang+self.lebar)

class FrmPersegi:
    def __init__(self, parent, title):
        self.parent = parent
        self.parent.geometry("400x250")
        self.parent.title(title)
        self.parent.protocol("WM_DELETE_WINDOW", self.onKeluar)
        self.aturKomponen()

    def aturKomponen(self):
        Label(root, text="Luas Dan Keliling Persegi Panjang",font=('arial',15)).pack()
        mainFrame = Frame(self.parent, bd=10)
        mainFrame.pack(fill=BOTH, expand=YES)

        # pasang Label
        Label(mainFrame, text='Panjang :').grid(row=0, column=0,
        sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Lebar :").grid(row=1, column=0,
        sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Luas :").grid(row=3, column=0,
        sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Keliling :").grid(row=4, column=0,
        sticky=W, padx=5, pady=5)

        # pasang textbox
        self.txtPanjang = Entry(mainFrame)
        self.txtPanjang.grid(row=0, column=1, padx=5, pady=5)
        self.txtLebar = Entry(mainFrame)
        self.txtLebar.grid(row=1, column=1, padx=5, pady=5)
        self.txtLuas = Entry(mainFrame)
        self.txtLuas.grid(row=3, column=1, padx=5, pady=5)
        self.txtKel = Entry(mainFrame)
        self.txtKel.grid(row=4, column=1, padx=5, pady=5)

        # Pasang Button
        self.btnHitung = Button(mainFrame, text='Hitung',
        command=self.onHitung)
        self.btnHitung.grid(row=2, column=1, padx=5, pady=5)
        # fungsi untuk menghitung luas dan keliling persegi panjang

    def onHitung(self, event=None):
        # perhitungan dengan metode Pemrograman Tidak Terstruktur
        panjang = float(self.txtPanjang.get())
        lebar = float(self.txtLebar.get())
        pesegi_panjang=Persegipanjang(panjang,lebar)
        luas = pesegi_panjang.luas()
        self.txtLuas.delete(0,END)
        self.txtLuas.insert(END,str(luas))
        kel = pesegi_panjang.keliling()
        self.txtKel.delete(0,END)
        self.txtKel.insert(END,str(kel))

    def onKeluar(self, event=None):
        # memberikan perintah menutup aplikasi
        self.parent.destroy()
        
if __name__ == '__main__':
    root = Tk()
    aplikasi = FrmPersegi(root, "Program Luas dan Keliling Persegi Panjang")
    root.mainloop() 