# Gestor de entrenamientos (C#)

Aplicación de consola en **C# / .NET 9** para registrar entrenamientos de carrera. Cada usuario crea su cuenta, inicia sesión y lleva su propio historial de sesiones con distancia, tiempo y ritmo medio.

> Proyecto del módulo de Fundamentos de Programación (1.º DAW, Universidad Europea).

## Funcionalidades

- **Registro e inicio de sesión** con email y contraseña. No deja registrar dos usuarios con el mismo email.
- **Historial por usuario**: cada cuenta guarda solo sus entrenamientos.
- **Registrar entrenamiento** (km y minutos). Calcula el **ritmo medio en min/km**.
- **Listar** y **vaciar** el historial.
- **Validación de entrada**: si escribes texto en lugar de un número, o un valor negativo, el programa avisa y sigue funcionando en lugar de cerrarse.

## Estructura

```
├── Program.cs        # Menú principal y lógica de sesión
├── Usuario.cs        # Email, contraseña y lista de entrenamientos
├── Entrenamiento.cs  # Distancia, tiempo y cálculo del ritmo
└── GestorEntrenamientos.csproj
```

El programa tiene dos menús: uno sin sesión (registrarse / entrar) y otro con sesión iniciada (gestionar entrenamientos). Cuál se muestra depende de si hay un `usuarioActivo`.

## Cómo ejecutarlo

Requiere el [SDK de .NET 9](https://dotnet.microsoft.com/download).

```bash
git clone https://github.com/Madurga1/Actividad-evaluable-2-trimestre-Fundamentos.git
cd Actividad-evaluable-2-trimestre-Fundamentos
dotnet run
```

## Ejemplo de uso

```
=== MENÚ PRINCIPAL ===
1. Registrar usuario
2. Iniciar sesión
0. Salir
Elige una opción: 1
Introduce tu correo: ana@mail.com
Introduce tu contraseña: ****
Usuario registrado correctamente.

...

=== MENÚ USUARIO: ana@mail.com ===
1. Registrar entrenamiento
2. Listar entrenamientos
3. Vaciar entrenamientos
4. Cerrar sesión
0. Salir
Elige una opción: 2

--- Tus entrenamientos ---
1. Distancia: 10 km | Tiempo: 52 min | Ritmo: 5,20 min/km
2. Distancia: 5 km | Tiempo: 24 min | Ritmo: 4,80 min/km
```

## Limitaciones conocidas y siguientes pasos

- Los datos se guardan **solo en memoria**: se pierden al cerrar el programa. Siguiente paso: guardarlos en JSON o en SQLite.
- Las contraseñas se guardan **en texto plano**. En una aplicación real habría que guardarlas con hash (por ejemplo, BCrypt).
- Separar la lógica del menú en clases de servicio para poder añadir tests unitarios.
- Estadísticas por usuario: kilómetros totales y mejor ritmo.
