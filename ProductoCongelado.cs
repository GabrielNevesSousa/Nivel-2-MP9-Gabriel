public class ProductoCongelado extends Producto{
	private double temperaturaCongelacion;
	
	public ProductoCongelado(String nombreProducto, int numeroLote, double temperaturaCongelacion) {
		super(nombreProducto, numeroLote);
		this.temperaturaCongelacion = temperaturaCongelacion;
	}
	
	public double getTemperaturaCongelacion() {
		return this.temperaturaCongelacion;
		
	}
	
	public void setfechaEnvasado(double temperaturaCongelacion) {
		this.temperaturaCongelacion = temperaturaCongelacion;
		
	}
	
	public void mostrarProductoCongelado() {
		super.mostrar();
		System.out.println(this.temperaturaCongelacion);
	}

}
