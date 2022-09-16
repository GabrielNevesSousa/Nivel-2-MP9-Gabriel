public class ProductoRefrigerado extends Producto {
	private int codigoSupervisionAlimenticia;
	
	public ProductoRefrigerado (String nombreProducto, int numeroLote, int codigoSupervisionAlimenticia) {
		super(nombreProducto, numeroLote);
		
		this.codigoSupervisionAlimenticia = codigoSupervisionAlimenticia;
		
	}
	
	public int getcodigoSupervision() {
		return this.codigoSupervisionAlimenticia;
		
	}
	
	public void setfechaEnvasado(int codigoSupervisionAlimenticia) {
		this.codigoSupervisionAlimenticia = codigoSupervisionAlimenticia;
		
	}
	
	public void mostrarProductoRefrigerado() {
		super.mostrar();
		System.out.println(this.codigoSupervisionAlimenticia);
	}

}
