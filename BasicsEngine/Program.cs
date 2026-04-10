using Silk.NET.Windowing; //llamar a la libreria Silk.NET.Windowing para poder crear y manejar ventanas.
using Silk.NET.OpenGL; //llamar a la libreria Silk.NET.OpenGL para poder usar OpenGL en la ventana.

WindowOptions options = WindowOptions.Default with //crea una variable opciones donde se asigna los valores que tendra por default la ventana.
{
    Size = new(1000, 1000),
    Title = "GL/Silk"
};

IWindow window = Window.Create(options); //asigna los valores a la ventana previamente creada.
GL gl = null!; // crea una var GL donde se le asigna null para que este vacia, y el ! para indicar que sera asignada posteriormente.

window.Load += () => // usa += () => como una funcion lambda para asignar lo que se cargara en la ventana.
{
    gl = GL.GetApi(window); // se asigna a var gl antes vacia, ahora llamando a GL.GetApi(window) para que carge la ventana creada antes.
};

window.Render += (double deltaTime) => // la func lambda ahora tendra el double deltaTime para asignar el tiempo que tarda en renderizar cada frame, y dentro de esta se asigna lo que se renderizara.
{
    gl.ClearColor(0.2f, 0.3f, 0.3f, 1.0f); //establece el color de fondo de la ventana.
    gl.Clear(ClearBufferMask.ColorBufferBit);
};

window.Run(); //se ejecuta load y render, y se mantiene la ventana abierta hasta que el usuario decida cerrarla.
window.Dispose(); //cierra la ventana y libera los recursos utilizados en el proceso.