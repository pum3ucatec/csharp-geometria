using Gtk;
using System;
using Gdk;
using Cairo;

class Program
{
    static void Main(string[] args)
    {
        Application.Init();

        // Crear una nueva ventana
        Gtk.Window ventana = new Gtk.Window("Dibujo de Rectángulo");
        ventana.SetDefaultSize(400, 300);
        ventana.DeleteEvent += delegate { Application.Quit(); };

        // Crear un área de dibujo
        DrawingArea areaDibujo = new DrawingArea();

        // Crear una instancia de Rectangulo
        var esquinaInferiorIzquierda = new Punto(50, 50);
        var esquinaSuperiorDerecha = new Punto(250, 150);
        var color = new Gdk.Color(0, 0, 255); // Azul
        Rectangulo rectangulo = new Rectangulo(esquinaInferiorIzquierda, esquinaSuperiorDerecha, color);

        // Pasar la instancia del rectángulo a la función de dibujo
        areaDibujo.Drawn += (sender, args) => rectangulo.Dibujar(args.Cr);

        ventana.Add(areaDibujo);
        ventana.ShowAll();

        Application.Run();
    }
}
