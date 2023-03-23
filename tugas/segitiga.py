#Robby Awaludin
#R3
#200511012
from tkinter import Frame,Label,Entry,Button,YES,BOTH,END,Tk,W

class segitiga:
    def __init__(self,sisia,sisib,sisic):
        self.sisia = sisia
        self.sisib = sisib
        self.sisic = sisic
    def luas(self):
        return 0.5*self.sisia*self.sisib
    def keliling(self):
        return self.sisia+self.sisib+self.sisic
class FrmSegitiga:
    
    def __init__(self, parent, title):
        self.parent = parent
        self.parent.geometry("400x250")
        self.parent.title(title)
        self.parent.protocol("WM_DELETE_WINDOW", self.onKeluar)
        self.aturKomponen()

    def aturKomponen(self):
        Label(root, text="Luas Dan Keliling Segitiga",font=('arial',15)).pack()
        mainFrame = Frame(self.parent, bd=10)
        mainFrame.pack(fill=BOTH, expand=YES)
        
        # pasang Label

        Label(mainFrame, text='Alas :').grid(row=0, column=0,
            sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Tinggi :").grid(row=1, column=0,
            sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Sisi Miring :").grid(row=2, column=0,
            sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Luas :").grid(row=4, column=0,
            sticky=W, padx=5, pady=5)
        Label(mainFrame, text="Keliling :").grid(row=5, column=0,
            sticky=W, padx=5, pady=5)

        # pasang textbox
        self.txtSisiA = Entry(mainFrame)
        self.txtSisiA .grid(row=0, column=1, padx=5, pady=5)
        self.txtSisiB = Entry(mainFrame)
        self.txtSisiB .grid(row=1, column=1, padx=5, pady=5)
        self.txtSisiC = Entry(mainFrame)
        self.txtSisiC .grid(row=2, column=1, padx=5, pady=5)
        self.txtLuasS = Entry(mainFrame)
        self.txtLuasS.grid(row=4, column=1, padx=5, pady=5)
        self.txtKel = Entry(mainFrame)
        self.txtKel.grid(row=5, column=1, padx=5, pady=5)

        # Pasang Button
        self.btnHitung = Button(mainFrame, text='Hitung',
            command=self.onHitung)
        self.btnHitung.grid(row=3, column=1, padx=5, pady=5)


# fungsi untuk menghitung luas dan keliling segitiga
    def onHitung(self, event=None):
        # perhitungan dengan metode Pemrograman Tidak Terstruktur
        sisia= int(self.txtSisiA.get())
        sisib= int(self.txtSisiB.get())
        sisic= int(self.txtSisiC.get())
        ks=segitiga(sisia,sisib,sisic)
        luas = ks.luas()
        self.txtLuasS.delete(0,END)
        self.txtLuasS.insert(END,str(luas))
        kel = ks.keliling()
        self.txtKel.delete(0,END)
        self.txtKel.insert(END,str(kel))

    def onKeluar(self, event=None):
    # memberikan perintah menutup aplikasi
        self.parent.destroy()

if __name__ == '__main__':
    root = Tk()
    aplikasi = FrmSegitiga(root, "Program Luas dan Keliling Segitiga ")

root.mainloop() 
