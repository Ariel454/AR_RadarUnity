# AR_RadarUnity
# Configuración de Radar en Unity

## Requisitos
Unity: Versión 2022.3.10 o posterior.
## Créditos
Desarrollado por Ariel454.

## Configuración del Radar
Este README proporciona los pasos necesarios para configurar un sistema de radar en Unity.

## Creación del Terreno y Personaje
Comienza creando el terreno que contendrá tus objetos y personaje en Unity.
![image](https://github.com/Ariel454/AR_RadarUnity/assets/121766763/242db281-1126-49f3-9f63-f467f2664203)

## Configuración de la Cámara del Radar
Agrega una cámara al personaje para el radar, situándola encima de este y apuntando hacia el terreno para obtener una perspectiva aérea.
Ajusta los parámetros de la cámara:
Projection: Ortográfica.
Size: 10.
Culling Mask: Nada.
Clear Flags: Solo Profundidad.
![image](https://github.com/Ariel454/AR_RadarUnity/assets/121766763/cf31258f-e71a-4c08-a5a0-968da1fa56f0)

## Capa "Radar"
Crea una esfera para representar la posición del jugador y agrégala al First Person Controller.
Asigna la capa "Radar" a la esfera y a la cámara del radar.
Asegúrate de eliminar esta capa del Culling Mask de la cámara principal.
![image](https://github.com/Ariel454/AR_RadarUnity/assets/121766763/bf37a82a-fc5e-410f-984a-9eff95192f0d)

## Configuración de la Cámara del Radar (Continuación)
En la cámara del radar, ajusta el Viewport Rect a 0.7.
![image](https://github.com/Ariel454/AR_RadarUnity/assets/121766763/93471c92-ed93-4def-842f-0e23d73294e7)

## Creación de un RadarPoint
Crea una nueva esfera llamada RadarPoint y asígnale una textura roja.
Colócala en la capa "Radar" y guárdala como un prefab.
![image](https://github.com/Ariel454/AR_RadarUnity/assets/121766763/a79d74d3-012d-4925-945d-07c53f201c90)

## Script "Radar"
Crea un script llamado Radar y asígnalo al personaje.
![image](https://github.com/Ariel454/AR_RadarUnity/assets/121766763/862006a6-233e-4fc9-b6ab-0c4804ea8a68)

## Añadir GameObject Vacío
Añade un GameObject vacío llamado helpTransform al personaje.
![image](https://github.com/Ariel454/AR_RadarUnity/assets/121766763/8ba0aa6b-7508-4e96-baa9-a0bec61444f7)

## Configuración del Script "Radar"
![image](https://github.com/Ariel454/AR_RadarUnity/assets/121766763/4305fe05-b6cf-4809-aa9f-83b9a58490ea)

Agrega cada prefab y atributo necesario al script C# en tu personaje.

## Background Radar
Añade un background a nuestra cámara de radar, unicamente lo colocamos dentro de la jerarquía y lo posicionamos en el campo de visión de la cámara.
![image](https://github.com/Ariel454/AR_RadarUnity/assets/121766763/c82dfb00-6053-4faa-a4f7-252ee6f60d91)
