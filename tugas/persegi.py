#Robby Awaludin
#R3
#200511012
from tkinter import Frame,Label,Entry,Button,YES,BOTH,END,Tk,W


class Persegi:
    def __init__(self,sisi):
        self.sisi = sisi
    def luas(self):
        return self.sisi**2
    def keliling(self):
        return 4*self.sisi

class FrmPersegi:

    def __init__(self, parent, title):
        self.parent = parent
        self.parent.geometry("400x200")
        self.parent.title(title)
        self.parent.protocol("WM_DELETE_WINDOW", self.onKeluar)
        self.aturKomponen()

    def aturKomponen(self):
        Label(root, text="Luas Dan Keliling Persegi",font=('arial',15)).pack()
        mainFrame = Frame(self.parent, bd=10)
        mainFrame.pack(fill=BOTH, expand=YES)
        
        # pasang Label
        Label(mainFrame, text="Sisi :").grid(row=2, column=0,
            sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Luas :").grid(row=4, column=0,
            sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Keliling :").grid(row=5, column=0,
            sticky=W, padx=5, pady=5)

        # pasang textbox
        self.txtSisi = Entry(mainFrame)
        self.txtSisi .grid(row=2, column=1, padx=5, pady=5)
        self.txtLuas = Entry(mainFrame)
        self.txtLuas.grid(row=4, column=1, padx=5, pady=5)
        self.txtKel = Entry(mainFrame)
        self.txtKel.grid(row=5, column=1, padx=5, pady=5)

        # Pasang Button
        self.btnHitung = Button(mainFrame, text='Hitung',
            command=self.onHitung)
        self.btnHitung.grid(row=3, column=1, padx=5, pady=5)


# fungsi untuk menghitung luas dan keliling segitiga
    def onHitung(self, event=None):
        # perhitungan dengan metode Pemrograman Tidak Terstruktur
        SisiP= int(self.txtSisi.get())
        psg=Persegi(SisiP)
        luasP = psg.luas()
        self.txtLuas.delete(0,END)
        self.txtLuas.insert(END,str(luasP))
        kelilingP = psg.keliling()
        self.txtKel.delete(0,END)
        self.txtKel.insert(END,str(kelilingP))

    def onKeluar(self, event=None):
    # memberikan perintah menutup aplikasi
        self.parent.destroy()

if __name__ == '__main__':
    root = Tk()
    aplikasi = FrmPersegi(root, "Program Luas dan Keliling Persegi ")
    root.mainloop() 