# -*- coding: utf-8 -*-
"""
Created on Wed Sep 22 17:05:50 2021

@author: NOEMI
"""
from pyswip import Prolog
prolog = Prolog()
prolog.assertz("padrede('Juan', 'María')")
prolog.assertz("padrede('Pablo', 'Juan')")
prolog.assertz("padrede('Pablo', 'Marcela')")
prolog.assertz("padrede('Carlos', 'Débora')")


#A es hijo de B si B es padre de A
prolog.assertz("hijode(A,B) :- padrede(B,A)")

prolog.assertz("abuelode(A,B) :- padrede(A,C),padrede(C,B)")

prolog.assertz("hermanode(A,B) :- padrede(C,A),padrede(C,B),A\==B")

prolog.assertz("familiarde(A,B) :- padrede(A,B)")
prolog.assertz("familiarde(A,B) :- hijode(A,B)")
prolog.assertz("familiarde(A,B) :- hermanode(A,B)")

for elemento in prolog.query("familiarde(X,Y)"):
    print(elemento["X"],"es el familiar de",elemento["Y"])
