#Robby Awaludin
#R3
#200511012
from tkinter import Frame,Label,Entry,Button,YES,BOTH,END,Tk,W

class Trapesium:
    def __init__(self,sisia,sisib,tinggi,sisim):
        self.sisia = sisia
        self.sisib = sisib
        self.tinggi = tinggi
        self.sisim = sisim
    def luas(self):
        return 0.5*(self.sisia*self.sisib)*self.tinggi
    def keliling(self):
        return self.sisia+self.sisib+self.tinggi+self.sisim
    
class FrmTrapesium:
    def __init__(self, parent, title):
        self.parent = parent
        self.parent.geometry("500x250")
        self.parent.title(title)
        self.parent.protocol("WM_DELETE_WINDOW", self.onKeluar)
        self.aturKomponen()
        
    def aturKomponen(self):
        Label(root, text="Luas Dan Keliling Trapesium",font=('arial',15)).pack()
        mainFrame = Frame(self.parent, bd=10)
        mainFrame.pack(fill=BOTH, expand=YES)
        
        # pasang Label
        Label(mainFrame, text='Sisi Atas :').grid(row=0, column=0,
            sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Sisi Bawah :').grid(row=1, column=0,
            sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Sisi Miring :').grid(row=0, column=2,
            sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Tinggi :').grid(row=1, column=2,
            sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Luas :').grid(row=4, column=0,
            sticky=W, padx=5, pady=5)
        Label(mainFrame, text='Keliling :').grid(row=5, column=0,
            sticky=W, padx=5, pady=5)
        
        # pasang textbox
        self.txtSisiA = Entry(mainFrame)
        self.txtSisiA.grid(row=0, column=1, padx=5, pady=5)
        self.txtSisiB = Entry(mainFrame)
        self.txtSisiB.grid(row=1, column=1, padx=5, pady=5)
        self.txttinggi = Entry(mainFrame)
        self.txttinggi.grid(row=1, column=4, padx=5, pady=5)
        self.txtsisiM = Entry(mainFrame)
        self.txtsisiM.grid(row=0, column=4, padx=5, pady=5)
        self.txtLuas = Entry(mainFrame)
        self.txtLuas.grid(row=4, column=1, padx=5, pady=5)
        self.txtKel = Entry(mainFrame)
        self.txtKel.grid(row=5, column=1, padx=5, pady=5)


        # Pasang Button
        self.btnHitung = Button(mainFrame, text='Hitung',
            command=self.onHitung)
        self.btnHitung.grid(row=3, column=2, padx=5, pady=5)


# fungsi untuk menghitung luas dan keliling lingkaran
    def onHitung(self, event=None):
        # perhitungan dengan metode Pemrograman Tidak Terstruktur
    
        sA= int(self.txtSisiA.get())
        sB= int(self.txtSisiB.get())
        tinggi= int(self.txttinggi.get()) 
        sisim= int(self.txtsisiM.get())
        kt=Trapesium(sA,sB,tinggi,sisim)
        
        luas = kt.luas()
        self.txtLuas.delete(0,END)
        self.txtLuas.insert(END,str(luas))

        kel = kt.keliling()
        self.txtKel.delete(0,END)
        self.txtKel.insert(END,str(kel))

    def onKeluar(self, event=None):
    # memberikan perintah menutup aplikasi
        self.parent.destroy()

if __name__ == '__main__':
    root = Tk()
    aplikasi = FrmTrapesium(root, "Program Luas dan Keliling Trapesium")
    root.mainloop() 