using Godot;
using System;
using System.Collections;

public class Node2D : Godot.Spatial
{
    private MeshInstance cubo;
    private MeshInstance triangulo;
    private ulong started;
    private int contador = 0;
    private int limitador = 1000000;
    private ulong tiempoTranscurrido;
    
    /// Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        started = OS.GetSystemTimeMsecs();
        cubo = GetNode<MeshInstance>("cubo");
        triangulo = GetNode<MeshInstance>("triangulo");
    
        //cubo = (GetTree().GetNodesInGroup("cubo")[0]as MeshInstance);
        //triangulo = (GetTree().GetNodesInGroup("triangulo")[0]as MeshInstance);

        //#esto es para probar el rendimiento
        while (contador < limitador)
        { 
            prueba();
        }
        tiempoTranscurrido = OS.GetSystemTimeMsecs() - started;
        GD.Print("Result C#: ", tiempoTranscurrido);
        GetTree().Quit();//*/
       
    }

    //Probar desde teclado si se hace visible/invisible
    /*public override void _Process(float delta){
        if(Input.IsActionJustPressed("w")){
            prueba();
        }
    }//*/


    //en esta funcion uso la variable donde ya esta pre cargado el nodo
    private void prueba()
    {
        cubo.Visible = !cubo.Visible;
        triangulo.Visible = !triangulo.Visible;
        contador++;
    }//*/


    //en esta función llamo al nodo directamente	
    /*private void prueba()
    {
        GetNode<MeshInstance>("cubo").Visible = !GetNode<MeshInstance>("cubo").Visible;
        GetNode<MeshInstance>("triangulo").Visible =  !GetNode<MeshInstance>("triangulo").Visible;
        contador++;
    }//*/


    //en esta funcion uso los grupos para hacerlos visible/invisible
    /*private void prueba()
    {
        (GetTree().GetNodesInGroup("cubo")[0]as MeshInstance).Visible = !(GetTree().GetNodesInGroup("cubo")[0]as MeshInstance).Visible;
        (GetTree().GetNodesInGroup("triangulo")[0]as MeshInstance).Visible =  !(GetTree().GetNodesInGroup("triangulo")[0]as MeshInstance).Visible;
        contador++;
    }//*/

}
