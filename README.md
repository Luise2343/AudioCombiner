Este proyecto consiste en el desarrollo de una aplicación de Windows usando C# y .NET 6 que combina archivos de audio locales con texto sintetizado en voz (Text-to-Speech, TTS) para crear un mensaje de audio cohesivo. La aplicación permite al usuario seleccionar archivos MP3 desde su computadora y generar dinámicamente un segmento de audio en español para el nombre del cliente, integrando todo en una secuencia de reproducción organizada.

Funcionalidades
Carga de Archivos de Audio:

Permite al usuario seleccionar archivos MP3 que contienen los segmentos "Now Serving Customer", "at window number", y el número de ventana.
Entrada de Texto para TTS:

Proporciona un cuadro de texto donde el usuario puede ingresar el nombre del cliente. Este nombre se convertirá en audio usando el motor de TTS de Windows en español.
Reproducción Secuencial de Audio:

Reproduce los archivos de audio en el orden especificado, asegurando que el nombre del cliente se inserte correctamente en la secuencia.
Incluye una pausa ajustable entre cada segmento de audio para asegurar una transición suave y comprensible.
Tecnologías Utilizadas
C# y .NET 6: Plataforma principal de desarrollo.
Windows Forms: Framework para la creación de la interfaz gráfica de usuario.
NAudio: Biblioteca de procesamiento de audio utilizada para la reproducción y manipulación de archivos de audio.
System.Speech.Synthesis: Espacio de nombres de .NET para convertir texto a voz (TTS).
