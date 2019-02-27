# Copiar-Colar-Arquivos-Organizando

Aplicativo que:
1.	Leia do console o path de um diretório.
2.	Caso o diretório não exista, mostre uma mensagem de erro e encerre a execução.
3.	Leia do console o path de outro diretório.
4.	Caso o outro diretório não exista, mostre uma mensagem de erro e encerre a execução.
5.	Percorra todos os arquivos existentes em todo o primeiro diretório lido (considerando pastas, subpastas, etc) e os organize no segundo diretório. Ao fim da execução, o segundo diretório deverá conter pastas de acordo com a seguinte regra:

a.	Pasta “Documentos”: Deverá conter todos arquivos com as extensões .doc, .docx, .pdf, .xls, e .xlsx.
b.	Pasta “Imagens”: Deverá conter todos arquivos com a extensão .png.
c.	Pasta “Videos”: Deverá conter todos arquivos com a extensão .avi.
d.	Pasta “Musica”: Deverá conter todos arquivos com a extensão .mp3.
e.	Pasta “Fontes”: Deverá conter todos arquivos com a extensão .cs e .js.
f.	Pasta “MXM”: Deverá conter todos os arquivos “MXM”, conforme regra da observação abaixo.
g.	Pasta “Outros”: Deverá conter todos arquivos que não pertencem a nenhuma categoria acima.

Na raiz do segundo diretório também deve ser criado um arquivo de texto com o nome “arquivosprocessados.txt”. Esse arquivo deverá conter o nome de todos os arquivos que foram organizados, um em cada linha.
Alguns métodos que podem ajudar (todas as classes são do namespace System.IO).
Directory.GetDirectories - Obter subdiretórios de um diretório
Directory.GetFiles - Obter arquivos de um diretório
Path.GetExtension - Obter a extensão de um arquivo
File.Copy - Copiar um arquivo

Utilize o aplicativo para organizar a pasta “Arquivos”, para testar.
