# Proyecto React-asp .net

En esta parte vamos a cubrir los temas finales que no se vieron en la anteiores partes. Vamos a fusionar ambos trabajos y adaptarlos para que tenga sentidos.

## Fusion de los dos proyectos.

Comencemos con la fusion. Como ya se dieron cuenta ambos proyectos se crearon de manera separada a pesar de ser todo parte de un solo trabajo final. Si hicieron todo de manera separada al final tendran dos versiones que necesitan unificarse. No obstante, tenemos dos repositorios diferentes.

>Nota: si trabajaste en el mismo trabajo y quieres probar este ejercicio solo tienes que descargar los repositorios que dejo en aqui [link 1](https://github.com/leandroVece/React-Asp.net) [link 2](https://github.com/leandroVece/React-Asp.net-2).

>nota: en el repo dos termine subiendo la carpeta en vez de los archivos, por lo que tendran que entrar en la carpeta y recien iniciar los pasos(Dentro de la carpete).

Para comenzar necesitamos que ambos repositorios locales apunte a un mismo repositorio remoto. Para ello existe el siguiente comando.

    git remote add <name> https://...

Si ya tienes la sana costumbre de guardar tus repositorios en la nuve, sabras que cuando agregamos un repositorio remoto a nuestro proyectos locales tenemos que expecificar la ruta, como esta el ejemplo de arriba.

Para evitar perder el progreso, recomiendo clonar el repositorio uno y dos. Luego crear un tercer repositorio y agregar la direccion remota del nuevo repositorio. Para eso necesitaremos eliminar la referencia al anterior repositorio, para evitar perder el progreso.

    git remote rm <name>

Luego agregagaremos la nueva referencia y subir ambos proyectos como si fueran ramas en el mismo repositorio. Si eres un poco mas experimentado, no necesitaras hacer todo esto, pero si no sabes mucho sobre Git recomiendo hacer esto para evitar las perdidas.

De este punto lo unico que debes hacer es un git pull para obtener los cambios de la rama que te falta en el repositorio que elegiste quedar. Si no entiendes demaciado, simplemente clona el nuevo repositorio y comencemos a trabajar.

En el repositorio que decidiste quedarte vamos a hacer un merge para fusionar ambos trabajos.

    git merge origin 