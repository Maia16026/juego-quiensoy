# Juego "Quién es Quién" - Lógica de Árboles Binarios

Este proyecto fue desarrollado para la materia **Complejidad Temporal, estructuras de datos y algoritmos (CTEDyA)** en la UNAJ. Representa la implementación de un sistema de adivinación basado en estructuras de datos dinámicas.

> **Estado del Proyecto:** Versión de cursada. 

## Conceptos Aplicados
El núcleo del juego es un **Árbol Binario de Decisión**, donde:
- **Nodos Internos:** Almacenan las preguntas que filtran las características de los personajes.
- **Hojas:** Almacenan los objetos de tipo "Personaje" o "Animal" a adivinar.
- **Recorrido:** Se utiliza una lógica recursiva para navegar el árbol según las respuestas del usuario (Sí/No).

## Estructuras de Datos Propias
A diferencia de usar librerías estándar, este proyecto utiliza implementaciones manuales de:
- **Árbol Binario:** Con métodos de inserción y recorrido.
- **Colas (Queue):** Utilizadas para la gestión de procesos internos.
- **Listas Enlazadas:** Para el manejo de colecciones de datos.

## Desafíos Técnicos Identificados
- **Acoplamiento:** Existe una dependencia fuerte entre la lógica del juego y las estructuras de datos base.
- **Reformulación de Preguntas:** El modo en que se escribieron las consultas pueden ser confusas.
- **Persistencia:** Mejora pendiente en la serialización del árbol para guardar el progreso del juego.

---
*Ingeniería Informática - Universidad Nacional Arturo Jauretche*
