#Robby Awaludin
#R3
#200511012
from tkinter import Frame,Label,Entry,Button,YES,BOTH,END,Tk,W

class Layang:
    def __init__(self,diagonala,diagonalb,sisia,sisib):
        self.diagonala = diagonala
        self.diagonalb = diagonalb
        self.sisia = sisia
        self.sisib = sisib
  
    def luas(self):
        return 0.5*self.diagonala*self.diagonalb
    def keliling(self):
        return 2*(self.sisia+self.sisib)
    
class FrmLayangLayang:

    def __init__(self, parent, title):
        self.parent = parent
        self.parent.geometry("450x300")
        self.parent.title(title)
        self.parent.protocol("WM_DELETE_WINDOW", self.onKeluar)
        self.aturKomponen()

    def aturKomponen(self):
        Label(root, text="Luas Dan Keliling Layang-Layang",font=('arial',15)).pack()
        mainFrame = Frame(self.parent, bd=10)
        mainFrame.pack(fill=BOTH, expand=YES)
        
        # pasang Label
        Label(mainFrame, text="Diagonal 1 :").grid(row=1, column=0,
            sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Diagonal 2 :").grid(row=2, column=0,
            sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Sisi Atas :").grid(row=3, column=0,
            sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Sisi Bawah :").grid(row=4, column=0,
            sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Luas :").grid(row=6, column=0,
            sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Keliling :").grid(row=7, column=0,
            sticky=W, padx=5, pady=5)

        # pasang textbox
        self.txtDiagonal1 = Entry(mainFrame)
        self.txtDiagonal1 .grid(row=1, column=1, padx=5, pady=5)
        self.txtDiagonal2 = Entry(mainFrame)
        self.txtDiagonal2 .grid(row=2, column=1, padx=5, pady=5)
        self.txtSisiA = Entry(mainFrame)
        self.txtSisiA .grid(row=3, column=1, padx=5, pady=5)
        self.txtSisiB = Entry(mainFrame)
        self.txtSisiB .grid(row=4, column=1, padx=5, pady=5)
        self.txtLuas = Entry(mainFrame)
        self.txtLuas.grid(row=6, column=1, padx=5, pady=5)
        self.txtKel= Entry(mainFrame)
        self.txtKel.grid(row=7, column=1, padx=5, pady=5)

        # Pasang Button
        self.btnHitung = Button(mainFrame, text='Hitung',
            command=self.onHitung)
        self.btnHitung.grid(row=5, column=1, padx=5, pady=5)


# fungsi untuk menghitung luas dan keliling segitiga
    def onHitung(self, event=None):
        # perhitungan dengan metode Pemrograman Tidak Terstruktur
        d1= int(self.txtDiagonal1.get())
        d2= int(self.txtDiagonal2.get())
        sa = int(self.txtSisiA.get())
        sb = int(self.txtSisiB.get())
        komponenlayang=Layang(d1,d2,sa,sb)

        luas = komponenlayang.luas()
        self.txtLuas.delete(0,END)
        self.txtLuas.insert(END,str(luas))

        kel = komponenlayang.keliling()
        self.txtKel.delete(0,END)
        self.txtKel.insert(END,str(kel))

    def onKeluar(self, event=None):
    # memberikan perintah menutup aplikasi
        self.parent.destroy()

if __name__ == '__main__':
    root = Tk()
    aplikasi = FrmLayangLayang(root, "Program Luas dan Keliling Layang Layang ")
    root.mainloop() 