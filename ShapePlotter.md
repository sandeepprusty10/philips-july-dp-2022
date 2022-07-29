using System;
using System.Collections.Generic;

//Object Structure
public class Image{

	List<Shape> _structure=new List<Shape>();
	public void Plot(List<ShapePlotter> plotters){
	
	//M*N cartesian product
		foreach(Shape s in _structure){
			foreach(ShapePlotter p in plotters){
				p.Plot(s);
			}
		}
	}
}

public abstract class Shape{
	
	public abstract void Plot(ShapePlotter plotter);
}

public abstract class Rectangle:Shape{
	
	public string GeHeightAndWidth(){ return "R.H.W";}
	
	public override void Plot(ShapePlotter plotter) { plotter.Plot(this);}
}
public abstract class Circle:Shape{
	public string GetRadius(){ return "C.R";}
	
	public override void Plot(ShapePlotter plotter) { plotter.Plot(this);}
}
public abstract class Polygon:Shape{
	public string GetSides(){ return "P.S";}
	
	public override void Plot(ShapePlotter plotter) { plotter.Plot(this);}
}

public abstract class ShapePlotter{

	public abstract void Plot(Rectangle r);
	public abstract void Plot(Circle c);
	public abstract void Plot(Polygon p);
}

public class LaserPrinter : ShapePlotter{

	public override void Plot(Rectangle r) { r.GeHeightAndWidth();}
	public override void Plot(Circle c) {c.GetRadius();}
	public override void Plot(Polygon p) {p.GetSides();}
}
public class InkJetPrinter : ShapePlotter{
	
	public override void Plot(Rectangle r) { r.GeHeightAndWidth();}
	public override void Plot(Circle c) {c.GetRadius();}
	public override void Plot(Polygon p) {p.GetSides();}
}

