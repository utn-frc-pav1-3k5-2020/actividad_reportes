
# BugTracker - Actividad Reportes


## 1. Clonar Repositorio (Clone/Checkout)

**1.1. Ejecutar comando clone para descargar repositorio:** 
```sh
$ git clone https://github.com/utn-frc-pav1-3k5-2020/actividad_reportes
```
**1.2. Ubicarse en la carpeta generada con el nombre del repositorio: 

```sh
$ cd actividad_reportes
```

**1.3. Crear un nuevo branch (rama)**

Para crear una nueva rama (branch) y saltar a ella, en un solo paso, puedes utilizar el comando  `git checkout`  con la opción  `-b`, indicando el nombre del nuevo branch (reemplazando el nro de legajo) de la siguiente forma branch_{legajo}, para el legajo 12345:

```sh
$ git checkout -b branch_12345 
Switched to a new branch "12345"
```
Y para que se vea reflejada en GitHub:
```sh
$ git push --set-upstream origin branch_12345
```

## 2. Actividad: Paso a Paso - BugTracker Reportes

https://drive.google.com/file/d/1hvuPithyaVPhVJGjq4eGSwXcxKUxjPmV/view?usp=sharing

## 3. Versionar en GitHub los cambios locales (add / commit / push)

> A continuación vamos a crear el **commit** y subir los cambios al servidor GitHub.

3.1. **Status**. Verificamos los cambios pendientes de versionar.

```sh
$ git status
```

3.2. **Add**. Agregamos todos los archivos nuevos no versionados.

```sh
$ git add -A
```

3.3. **Commit**. Generamos un commit con todos los cambios y agregamos un comentario.

```sh
$ git commit -a -m "Comentario"
```

3.4. **Push**. Enviamos todos los commits locales a GitHub

```sh
$ git push
```

3.5. **Status**. Verificar que no quedaron cambios pendientes de versionar

```sh
$ git status
```

