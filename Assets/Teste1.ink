#VAR image = "Saber1"
 Voce chega numa porta grande de uma mansão
 
*[Tentar abrir a porta] -> Tentarabriraporta
*[Ir embora] -> IrEmbora
*[Jogar uma pedra na porta] -> PedraNaPorta

== Tentarabriraporta ==
#VAR image = "Saber2"
A porta abre com pouco esforço.
Diante de você uma mulher grande de quase 2 metros de altura aparece.
" Bom ver que finalmente chegou,jovem mestre." - Ela diz
Você não reconhece essa mulher,e ela lhe chamou de mestre?

* Quem é você?
Asuka,a criada principal da mansâo da sua familia!
* Que mansão é essa?
A mansâo da sua familia.
* Mestre? Quem? Eu?

-> END

== IrEmbora ==
#VAR image = "Saber3"
Voce vai embora com facilidade o jogo acaba e nada acontece.
-> END
== PedraNaPorta ==

Uma mulher abre a porta e antes de conseguir fazer qualquer coisa,você desmaia.
-> Dentrodoporao

== Dentrodoporao ==
#VAR image = "Saber4"
 Voce acorda em um quarto escuro.
 
 * [ ... ]
 Voce nao sabe quantas horas passaram.
 Voce só lembra de ter jogado uma pedra na porta de uma mansão.
 -> DepoisDeAcordar
 
 == DepoisDeAcordar ==
#VAR image = "Saber5"
* ["Porque diabos eu joguei uma pedra na porta?" Voce se perguta.]
 Você começa a notar que sua memoria esta faltando em varios lugares.
 Você nao se lembra como chegou na mansao,nem de onde veio.
 Pensando bem,você não se lembra de nada.
 Como assim? você pensa.
 Você tenta e tenta mas nada vem pra frente da sua mente.
 
 
 
 -> DONE
 


