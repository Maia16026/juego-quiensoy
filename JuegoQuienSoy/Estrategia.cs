
using System;
using System.Collections.Generic;


namespace WiW
{

	class Estrategia
	{

		public String Consulta1(ArbolBinario<DecisionData> arbol)
		{
			List<string> predicciones= new List<string>();
			ObtenerPredicciones(arbol,predicciones);
			return string.Join("\n",predicciones);
		}
		
		private void ObtenerPredicciones(ArbolBinario<DecisionData> nodo , List<string> predicciones){
			if(nodo== null)return;
			if (nodo.esHoja()){
				predicciones.Add(nodo.getDatoRaiz().ToString());
			}
			else{
				ObtenerPredicciones(nodo.getHijoIzquierdo(), predicciones);
				ObtenerPredicciones(nodo.getHijoDerecho(), predicciones);
			}
		}


		public String Consulta2(ArbolBinario<DecisionData> arbol)
		{

			List<string> caminos= new List<string>();
			ConstruirCaminos(arbol,"", caminos);
			return string.Join("   ", caminos);
		}
		
		private void ConstruirCaminos(ArbolBinario<DecisionData> nodo, string caminoActual, List<string>caminos){
			if(nodo==null)return;
			if (nodo.esHoja()){
				caminos.Add(caminoActual + "Prediccion: "+ nodo.getDatoRaiz().ToString());
			}
			else{
				string pregunta = nodo.getDatoRaiz().ToString();
				ConstruirCaminos(nodo.getHijoIzquierdo(), caminoActual + pregunta+ "-> si\n", caminos);
				ConstruirCaminos(nodo.getHijoDerecho(), caminoActual + pregunta + "no\n", caminos);
			}
		}


		public String Consulta3(ArbolBinario<DecisionData> arbol)
		{
			Cola<Tuple<ArbolBinario<DecisionData>,int>> cola= new Cola<Tuple<ArbolBinario<DecisionData>, int>>();
			cola.encolar(Tuple.Create(arbol, 0));
			
			int nivelActual= -1;
			string resultado= "";
			while(!cola.esVacia()){
				var nodoNivel = cola.desencolar();
				var nodo= nodoNivel.Item1;
				int nivel= nodoNivel.Item2;
				
				if (nivel!= nivelActual){
					resultado+="\nNivel"+ nivel+ ":\n";
					nivelActual= nivel;
				}
				resultado+="-" + nodo.getDatoRaiz().ToString()+"\n";
				
				if(nodo.getHijoIzquierdo()!= null)
					cola.encolar(Tuple.Create(nodo.getHijoIzquierdo(), nivel + 1));
				if(nodo.getHijoDerecho()!= null)
					cola.encolar(Tuple.Create(nodo.getHijoDerecho(), nivel + 1));
			
			}
				
			
			return resultado.Trim();
			}
			
			
			
		
		

		public ArbolBinario<DecisionData> CrearArbol(Clasificador clasificador)
		{
			if (clasificador.crearHoja()){
			 var hoja= new
			 DecisionData(clasificador.obtenerDatoHoja());
			 return new ArbolBinario<DecisionData>(hoja);
			}
			else{
				var pregunta= clasificador.obtenerPregunta();
				var nodo= new ArbolBinario<DecisionData>(new DecisionData(pregunta));
				nodo.agregarHijoIzquierdo(CrearArbol(clasificador.obtenerClasificadorIzquierdo()));
				nodo.agregarHijoDerecho(CrearArbol(clasificador.obtenerClasificadorDerecho()));
				return nodo;
			}

			
		}
	}
}