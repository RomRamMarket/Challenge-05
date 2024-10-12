# Challenge-05


<h2>Preparando las herramientas necesarias.</h2>


<p>Configuramos inicialmente el sistema nuevo de entradas de Unity.</p>
<image
  src="Challenge05/newInput1.png"
  width = 60%
  height = 60%>


<p>Luego, dentro de <code>Window -> Package Manager</code> instalamos el <code>Input System</code>. Vea la imagen a continuación de apoyo.</p>
<image
  src="Challenge05/newInput2.png"
  width = 60%
  height = 60%>



<p>Para poder darle movimiento a algún elemento buscamos en el Asset Store el paquete de Assets que usaremos y una vez lo elegimos lo descargamos en la misma opción de <code>Package Manager</code>.</p>
<image
  src="Challenge05/importRobot.png"
  width = 60%
  height = 60%>


<h2>Añadimos terreno</h2>
<p>Utilizando <code>Game 3D Object</code> creamos un <code>Terrain</code>. Configuramos su ancho, alto y largo en 50.</p>
<image
  src="Challenge05/terrainSet.png"
  width = 30%
  height = 30%>



<p>Buscamos cualquier textura que quisieramos para el terreno. </p>
<image
  src="Challenge05/textura.png"
  width = 30%
  height = 30%>

  
<p>Le añadimos la textura al terreno.</p>
<image
  src="Challenge05/addTexture.png"
  width = 60%
  height = 60%>


<p>Ponemos un asset del packete que importamos encima del terreno.</p>
<image
  src="Challenge05/putRobot.png"
  width = 60%
  height = 60%>


<h2>Comenzamos a configurar las acciones.</h2>

<p>En el robot o seleccionamos <code>Add component</code> buscamos <code>Input player</code>.</p>
<image
  src="Challenge05/addPlayerInputComp.png"
  width = 40%
  height = 40%>
  
<p>Al haber realizados los pasos anteriores le aparecerá un icono como el de la siguiente imagen dentro de su carpeta de <code>Assets</code>.</p>
<image
  src="Challenge05/newInput3.png"
  width = 60%
  height = 60%>

<h3>Creando acción de <code>Horizontal Movement</code></h3>

<p>Al presionar el icono aparecerán varias acciones que unity tiene ya definidas, pero que como no las usaremos podemos eliminarlas y crear las nuestras desde cero o adaptar las prehechas. Para crear una acción referente a <code>Horizontal Movement</code> tenemos que presionar el botón de <code>+</code> y elegir el nombre de nuestra acción. En este caso se llamará <code>HorizontalMovement</code>. Esta es una acción tipo <code>Value</code> con un Control type de <code>Vector 2</code>.</p>
<image
  src="Challenge05/horizontalMovementAction.png"
  width = 60%
  height = 60%>



<p>Dentro de la acción tenemos que determinar que teclas son las que activan dicha acción. En este caso de <code>HorizontalMovement</code> las teclas que activan esta acción son <code>A</code>, <code>D</code>, <code>Left arrow</code> y <code>Right arrow</code>. El conjunto de estas teclas (en la imagen como "AD<-->") es de tipo <code>2D vector</code> mismo tipo que el Control type de la acción.</p>


<image
  src="Challenge05/AD.png"
  width = 60%
  height = 60%>


  <p>En el siguiente GIF puede ver como al presionar <code>A</code> o <code>Left arrow</code> el robot se mueve hacia la izquierda y si se presionan  <code>D</code> o <code>Right arrow</code> el robot se mueve hacia la derecha. Importante notar que la velocidad con la que hace esto es una relativamente baja (ver valor en código proporcionado más adelante).</p>


![GIF1](Challenge05/horizontal.gif)
<p>NOTA: Pudiera pasar que en algunos momentos se presenta poca fluidez en la grabación debido a problemas técnicos del equipo.</p>

<h3>Creando acción de <code>Fast Horizontal Movement</code></h3>

<p>Ahora creamos la acción llamada <code>fastHorizontalMovement</code> que see basará en que cuando se presione <code>shift + A</code> o <code>shift + D</code> o <code>shift + left arrow</code> o <code>shift + right arrow</code> entonces la velocidad subirá a un valor determinado. Esta acción es de tipo <code>Button</code> pues solo queremos saber en que instantes se estan presionando las combinaciones de teclas antes menncionadas. </p>


<image
  src="Challenge05/fHori.png"
  width = 60%
  height = 60%>

<p>En este caso las teclas que tenemos que configurar se basan en un <code>Modifier</code> que en esencia quiere decir que la acción solo va a ser activada si se presiona la tecla <code>modifier</code> y otra tecla escogida. En nuestro caso la tecla <code>modifier</code> es <code>shift</code>.</p>

<image
  src="Challenge05/modifier.png"
  width = 60%
  height = 60%>


<image
  src="Challenge05/shift.png"
  width = 60%
  height = 60%>


<p>Le añadimos un componenete que sea un <code>script</code> para poder decidir qué se va a realizar en cada acción. En nuestro caso lo llamamos <code>playerM</code>.</p>
<image
  src="Challenge05/addPlayerM.png"
  width = 40%
  height = 40%>

![GIF2](Challenge05/fastHorizontal.gif)
<p>NOTA: Pudiera pasar que en algunos momentos se presenta poca fluidez en la grabación debido a problemas técnicos del equipo.</p>


<h3>Código en C#</h3>
<p>Vea código que es pertinente para realizar las acciones <code>HorizontalMovement</code> y <code>FastHorizontalMovement</code>. Note que los metodos comienzan con <code>On</code> esto es para que se activen cuando la acción estó siendo llamada. Los métodos usualmente tienen en su nombre: <code>OnActionName</code>. </p>
<image
  src="Challenge05/horizontalScript.png"
  width = 60%
  height = 60%>


<h3>Visual Graph</h3>

<p>Para poder replicar lo que ya tenemos, pero con <code>Visual Graph</code> creamos un visual script y lo añadimos como componente del robot.</p>
<image
  src="Challenge05/setVisual.png"
  width = 35%
  height = 35%>

<image
  src="Challenge05/visual.png"
  width = 60%
  height = 60%>




![GIF3](Challenge05/visualGif.gif)
<p>NOTA: Pudiera pasar que en algunos momentos se presenta poca fluidez en la grabación debido a problemas técnicos del equipo.</p>


