'jpgExportFromWMP v0.0.1

Option Explicit

Dim objPlayer          : Set objPlayer          = CreateObject ("WMPlayer.OCX" )
Dim colMediaCollection : Set colMediaCollection = objPlayer.mediaCollection
Dim objPhotos          : Set objPhotos          = colMediaCollection.getByAttribute ("MediaType", "photo")
Dim i, j

WScript.StdOut.WriteLine "Wysokosc;Szerokosc;Rozmiar;Nazwa;Min;Max;Plik;Operat;Polozenie;Partia"
	
For i = 0 to objPhotos.Count - 1
	
	Dim objPhoto : Set objPhoto = objPhotos.Item(i)
		
	Dim h  : h  = objPhoto.getItemInfo ("WM/VideoHeight")
	Dim w  : w  = objPhoto.getItemInfo ("WM/VideoWidth")
	Dim fs : fs = objPhoto.getItemInfo ("FileSize")
	Dim fn : fn = objPhoto.getItemInfo ("SourceURL")
	    
	fn = Replace (fn, "\\338-39-4\Backup (E)\2625_Miñsk\", "")
	fn = Replace (fn, "\\338-39-4\e$\2625_Miñsk\", "")
	fn = Replace (fn, "\\338-39-4\2625_Miñsk\", "")
	fn = Trim (fn)
	    
	If h <> "" and w <> "" Then
	    
		WScript.StdOut.Write h & ";" & w & ";" & fs & ";" & fn
		WScript.StdOut.Write ";" & GetMin(h, w) & ";" & GetMax(h, w)
		    
		Dim cols, nazwaOperatu, polozenieOperatu, nazwaPliku, partia
		cols = Split (fn, "\")
		
		partia = cols (LBound (cols))
		nazwaPliku = cols (UBound (cols))
		nazwaOperatu = cols (UBound (cols)-1)
		polozenieOperatu = ""
			
		For j = LBound (cols) To Ubound (cols)-2
			polozenieOperatu = polozenieOperatu & "\" & cols (j)
		Next
			
		WScript.StdOut.WriteLine ";" & nazwaPliku & ";" & nazwaOperatu & ";" & polozenieOperatu & ";" & partia
			
	End If
Next

Function GetMin (x, y)
	If Eval (x) < Eval (y) Then
		GetMin = x
	Else
		GetMin = y
	End If
End Function

Function GetMax (x, y)
	If Eval (x) > Eval (y) Then
		GetMax = x
	Else
		GetMax = y
	End If
End Function
