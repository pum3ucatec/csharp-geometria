// Rectangulo.cs
using System;
using System.Drawing;
using Cairo;

public class Rectangulo
{
    public Punto PuntoInicial { get; set; }
    public Punto PuntoFinal { get; set; }
    public Gdk.Color Color { get; set; }

    public Rectangulo(Punto p1, Punto p2, Gdk.Color c)
    {
        this.PuntoInicial = p1;
        this.PuntoFinal = p2;
        this.Color = c;
    }

    public void Dibujar(Context context)
    {
        // Establecer el color
        context.SetSourceRGB(Color.Red / 255.0, Color.Green / 255.0, Color.Blue / 255.0);
        
        // Dibujar el rectángulo
        context.Rectangle(this.PuntoInicial.X, this.PuntoInicial.Y, Math.Abs(this.PuntoInicial.X - this.PuntoFinal.X), Math.Abs(this.PuntoInicial.Y - this.PuntoFinal.Y));
        context.Fill();
    }
}
